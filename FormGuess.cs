using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RH
{
    public partial class FormGuess : Form
    {
        private readonly string _username;
        private readonly int _min, _max, _maxAttempts;
        private readonly string _levelName;
        private readonly Random _rnd = new Random();

        private int _secret, _attempts, _score;

        public FormGuess(int min, int max, string level, string username)
        {
            InitializeComponent();
            _username = username;
            _min = min;
            _max = max;
            _levelName = level;
            _maxAttempts = level switch
            {
                "Easy" => 6,
                "Medium" => 5,
                "Hard" => 4,
                "Impossible" => 2,
                _ => 5
            };
            lblLevel.Text = $"🎯 {level}  |  Range: {min} – {max}  |  Best: {Scoreboard.GetBest(username, "Guess")}";

            SetupCustomUI();

            // Events
            this.Load += FormGuess_Load;
            this.FormClosed += FormGuess_FormClosed;
            txtGuess.KeyPress += (s, e) => {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnCheck.PerformClick();
                    e.Handled = true;
                }
            };
        }

        private void SetupCustomUI()
        {
            // Move painting logic here to avoid breaking the Designer
            pnlHeader.Paint += (s, e) =>
            {
                using var grad = new LinearGradientBrush(
                    new Point(0, 0), new Point(1000, 0),
                    Color.FromArgb(108, 73, 255), Color.FromArgb(50, 30, 150));
                e.Graphics.FillRectangle(grad, 0, 0, 1000, 80);
            };

            pnlContent.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(70, 70, 130), 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlContent.Width - 1, pnlContent.Height - 1);
            };

            pnlInput.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(108, 73, 255), 2);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlInput.Width - 1, pnlInput.Height - 1);
            };
        }

        private void FormGuess_Load(object sender, EventArgs e)
        {
            SoundManager.StartBackground();
            StartGame();
        }

        private void FormGuess_FormClosed(object sender, FormClosedEventArgs e)
        {
            SoundManager.StopBackground();
        }

        private void StartGame()
        {
            _secret = _rnd.Next(_min, _max + 1);
            _attempts = 0;
            _score = 0;

            lblFeedback.Text = "Enter a number and press Check!";
            lblFeedback.ForeColor = Color.FromArgb(180, 180, 220);
            lblAttempts.Text = $"Attempts: 0 / {_maxAttempts}";
            lblEmoji.Text = "🤔";
            txtGuess.Text = string.Empty;
            txtGuess.Focus();
            btnCheck.Enabled = true;
            pnlContent.BackColor = Color.FromArgb(20, 20, 48);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGuess.Text, out int guess))
            {
                SetFeedback("❗ Enter a valid number!", Color.FromArgb(255, 215, 0), "😐");
                return;
            }

            _attempts++;
            lblAttempts.Text = $"Attempts: {_attempts} / {_maxAttempts}";

            if (guess < _min || guess > _max)
            {
                SetFeedback($"⚠ Out of range! Enter between {_min} and {_max}.",
                    Color.FromArgb(255, 140, 50), "😬");
                CheckLoss();
                return;
            }

            if (guess == _secret)
            {
                _score = Math.Max(1, (_maxAttempts - _attempts + 1) * 10);
                Scoreboard.Save(_username, "Guess", _score);
                SetFeedback($"🎉 Correct! Found in {_attempts} attempt(s)! +{_score} pts",
                    Color.FromArgb(46, 232, 122), "🎉");
                pnlContent.BackColor = Color.FromArgb(10, 50, 25);
                btnCheck.Enabled = false;
                SoundManager.PlayCorrect();
                return;
            }

            if (guess > _secret)
            {
                SetFeedback("📉 Too high! Go lower.", Color.FromArgb(255, 71, 87), "🔽");
                SoundManager.PlayWrong();
            }
            else
            {
                SetFeedback("📈 Too low! Go higher.", Color.FromArgb(0, 212, 255), "🔼");
                SoundManager.PlayWrong();
            }

            CheckLoss();
            txtGuess.SelectAll();
            txtGuess.Focus();
        }

        private void CheckLoss()
        {
            if (_attempts >= _maxAttempts)
            {
                SetFeedback($"💀 Game over! The number was {_secret}.",
                    Color.FromArgb(255, 71, 87), "💀");
                pnlContent.BackColor = Color.FromArgb(50, 10, 15);
                btnCheck.Enabled = false;
                SoundManager.PlayGameOver();
            }
        }

        private void SetFeedback(string text, Color color, string emoji)
        {
            lblFeedback.Text = text;
            lblFeedback.ForeColor = color;
            lblEmoji.Text = emoji;
        }

        private void btnRestart_Click(object sender, EventArgs e) => StartGame();

        private void btnBack_Click(object sender, EventArgs e)
        {
            new FormLevel(_username).Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FormWelcome().Show();
            this.Close();
        }
    }
}