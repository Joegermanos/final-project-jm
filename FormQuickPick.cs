using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RH
{
    public partial class FormQuickPick : Form
    {
        private readonly string _username;
        private readonly Random _rnd = new Random();

        private int _score = 0;
        private int _lives = 3;
        private int _streak = 0;
        private int _timeLeft = 0;
        private int _correct;

        private readonly Color[] _btnColors = new Color[]
        {
            Color.FromArgb(108, 73, 255),
            Color.FromArgb(255, 107, 53),
            Color.FromArgb(46, 200, 100),
            Color.FromArgb(0, 180, 230)
        };

        public FormQuickPick(string username)
        {
            InitializeComponent();
            _username = username;
            lblBest.Text = $"Best: {Scoreboard.GetBest(username, "QuickPick")}";

            SetupCustomUI();
        }

        private void SetupCustomUI()
        {
            // Custom Painting
            pnlHeader.Paint += (s, e) =>
            {
                using var grad = new LinearGradientBrush(
                    new Point(0, 0), new Point(1000, 0),
                    Color.FromArgb(220, 100, 20), Color.FromArgb(12, 12, 30));
                e.Graphics.FillRectangle(grad, 0, 0, 1000, 80);
            };

            pnlContent.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(255, 140, 50), 2);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlContent.Width - 1, pnlContent.Height - 1);
            };

            // Answer Button Styling
            Button[] btns = { btnA, btnB, btnC, btnD };
            foreach (var btn in btns)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 22, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.Size = new Size(390, 90);
                btn.Cursor = Cursors.Hand;
                btn.Click += Answer_Click;
            }

            this.Load += FormQuickPick_Load;
            this.FormClosed += FormQuickPick_FormClosed;
        }

        private void FormQuickPick_Load(object sender, EventArgs e)
        {
            SoundManager.StartBackground();
            GenerateQuestion();
        }

        private void FormQuickPick_FormClosed(object sender, FormClosedEventArgs e)
        {
            SoundManager.StopBackground();
            timer1.Stop();
        }

        private void GenerateQuestion()
        {
            timer1.Stop();

            int a = _rnd.Next(2, 15);
            int b = _rnd.Next(2, 15);
            int opIdx = _rnd.Next(0, 3);
            string[] ops = { "+", "-", "×" };

            _correct = opIdx switch
            {
                0 => a + b,
                1 => a - b,
                _ => a * b
            };

            lblQuestion.Text = $"{a} {ops[opIdx]} {b} = ?";

            int[] choices = new int[4];
            choices[0] = _correct;
            for (int i = 1; i < 4; i++)
            {
                int wrong;
                do { wrong = _correct + _rnd.Next(-8, 9); }
                while (wrong == _correct || (Array.IndexOf(choices, wrong) >= 0 && i > 1));
                choices[i] = wrong;
            }

            Shuffle(choices);

            var btns = new[] { btnA, btnB, btnC, btnD };
            for (int i = 0; i < 4; i++)
            {
                btns[i].Text = choices[i].ToString();
                btns[i].Tag = choices[i];
                btns[i].BackColor = _btnColors[i];
                btns[i].Enabled = true;
            }

            lblFeedback.Text = string.Empty;
            pnlContent.BackColor = Color.FromArgb(20, 20, 48);

            _timeLeft = 80;
            lblTimer.Text = "8.0s";
            lblTimer.ForeColor = Color.FromArgb(0, 212, 255);
            timer1.Start();
        }

        private void Shuffle(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = _rnd.Next(0, i + 1);
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var btn = (Button)sender;
            int pick = (int)btn.Tag;

            DisableAnswers();

            if (pick == _correct)
            {
                _streak++;
                int pts = 10 + (_streak >= 3 ? 5 : 0);
                _score += pts;
                lblScore.Text = $"Score: {_score}";
                lblFeedback.Text = _streak >= 3
                    ? $"🔥 Streak x{_streak}! +{pts} pts"
                    : $"✅ Correct! +{pts} pts";
                lblFeedback.ForeColor = Color.FromArgb(46, 232, 122);
                btn.BackColor = Color.FromArgb(30, 160, 70);
                pnlContent.BackColor = Color.FromArgb(10, 45, 20);
                Scoreboard.Save(_username, "QuickPick", _score);
                lblBest.Text = $"Best: {Scoreboard.GetBest(_username, "QuickPick")}";
                SoundManager.PlayCorrect();
            }
            else
            {
                _streak = 0;
                _lives--;
                UpdateLives();
                lblFeedback.Text = $"❌ Wrong! Answer: {_correct}";
                lblFeedback.ForeColor = Color.FromArgb(255, 71, 87);
                btn.BackColor = Color.FromArgb(160, 30, 30);
                pnlContent.BackColor = Color.FromArgb(45, 10, 15);
                SoundManager.PlayWrong();
            }

            if (_lives <= 0)
            {
                lblFeedback.Text = $"💀 Game Over! Final score: {_score}";
                lblFeedback.ForeColor = Color.FromArgb(255, 71, 87);
                btnNext.Enabled = false;
                SoundManager.PlayGameOver();
                return;
            }

            btnNext.Enabled = true;
        }

        private void DisableAnswers()
        {
            btnA.Enabled = btnB.Enabled = btnC.Enabled = btnD.Enabled = false;
        }

        private void UpdateLives()
        {
            lblLives.Text = _lives switch
            {
                3 => "❤️ ❤️ ❤️",
                2 => "❤️ ❤️ 🖤",
                1 => "❤️ 🖤 🖤",
                _ => "🖤 🖤 🖤"
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            lblTimer.Text = $"{_timeLeft / 10}.{_timeLeft % 10}s";

            if (_timeLeft <= 20) lblTimer.ForeColor = Color.FromArgb(255, 71, 87);

            if (_timeLeft <= 0)
            {
                timer1.Stop();
                DisableAnswers();
                _lives--;
                _streak = 0;
                UpdateLives();
                lblFeedback.Text = $"⏰ Too slow! Answer: {_correct}";
                lblFeedback.ForeColor = Color.FromArgb(255, 140, 50);
                SoundManager.PlayGameOver();

                if (_lives <= 0)
                {
                    btnNext.Enabled = false;
                    lblFeedback.Text = $"💀 Game Over! Score: {_score}";
                }
                else
                {
                    btnNext.Enabled = true;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e) => GenerateQuestion();

        private void btnRestart_Click(object sender, EventArgs e)
        {
            _lives = 3;
            _streak = 0;
            _score = 0;
            lblScore.Text = "Score: 0";
            UpdateLives();
            GenerateQuestion();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form2(_username).Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FormWelcome().Show();
            this.Close();
        }
    }
}