using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RH
{
    public partial class FormMemory : Form
    {
        private readonly string _username;
        private readonly Random _rnd = new Random();

        private string _target = string.Empty;
        private int _timeLeft = 0;
        private int _score = 0;
        private bool _canType = false;

        public FormMemory(string username)
        {
            InitializeComponent();
            _username = username;
            lblBest.Text = $"Best: {Scoreboard.GetBest(username, "Memory")}";

            SetupCustomUI();
        }

        private void SetupCustomUI()
        {
            // Move complex painting logic here to keep Designer happy
            pnlHeader.Paint += (s, e) =>
            {
                using var grad = new LinearGradientBrush(
                    new Point(0, 0), new Point(1000, 0),
                    Color.FromArgb(30, 180, 80), Color.FromArgb(12, 12, 30));
                e.Graphics.FillRectangle(grad, 0, 0, 1000, 80);
            };

            pnlCard.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(46, 200, 100), 2);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
            };

            pnlAnswer.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(70, 150, 100), 2);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlAnswer.Width - 1, pnlAnswer.Height - 1);
            };

            txtAnswer.KeyPress += (s, e) =>
            {
                if (e.KeyChar == '\r' && btnSubmit.Enabled)
                    btnSubmit.PerformClick();
            };

            this.Load += FormMemory_Load;
            this.FormClosed += FormMemory_FormClosed;
        }

        private void FormMemory_Load(object sender, EventArgs e)
        {
            SoundManager.StartBackground();
            SetIdle();
        }

        private void FormMemory_FormClosed(object sender, FormClosedEventArgs e)
        {
            SoundManager.StopBackground();
            timer1.Stop();
        }

        private void SetIdle()
        {
            lblNumber.Text = "— — —";
            lblNumber.ForeColor = Color.FromArgb(100, 100, 150);
            lblTimer.Text = "Press Ready!";
            lblResult.Text = string.Empty;
            txtAnswer.Text = string.Empty;
            txtAnswer.Enabled = false;
            btnSubmit.Enabled = false;
            btnReady.Enabled = true;
            _canType = false;
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            int len = _rnd.Next(3, 7);
            _target = string.Empty;
            for (int i = 0; i < len; i++)
                _target += _rnd.Next(0, 10).ToString();

            lblNumber.Text = _target;
            lblNumber.ForeColor = Color.FromArgb(108, 73, 255);
            lblResult.Text = string.Empty;
            txtAnswer.Text = string.Empty;
            txtAnswer.Enabled = false;
            btnSubmit.Enabled = false;
            btnReady.Enabled = false;
            _canType = false;

            _timeLeft = 30; // 3.0 seconds
            lblTimer.Text = $"Memorize! {_timeLeft / 10}.{_timeLeft % 10}s";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timeLeft--;

            if (!_canType)
            {
                lblTimer.Text = $"Memorize! {_timeLeft / 10}.{_timeLeft % 10}s";

                if (_timeLeft <= 0)
                {
                    lblNumber.Text = "? ? ?";
                    lblNumber.ForeColor = Color.FromArgb(255, 140, 50);
                    lblTimer.Text = "Type the number!";
                    txtAnswer.Enabled = true;
                    btnSubmit.Enabled = true;
                    txtAnswer.Focus();
                    _canType = true;
                    _timeLeft = 150; // 15 seconds to answer
                }
            }
            else
            {
                lblTimer.Text = $"Time left: {_timeLeft / 10}.{_timeLeft % 10}s";

                if (_timeLeft <= 0)
                {
                    timer1.Stop();
                    lblResult.Text = $"⏰ Too slow! It was: {_target}";
                    lblResult.ForeColor = Color.FromArgb(255, 71, 87);
                    txtAnswer.Enabled = false;
                    btnSubmit.Enabled = false;
                    btnReady.Enabled = true;
                    SoundManager.PlayGameOver();
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string ans = txtAnswer.Text.Trim();

            if (ans == _target)
            {
                _score++;
                lblScore.Text = $"Score: {_score}";
                lblResult.Text = $"🎉 Correct! +1 point";
                lblResult.ForeColor = Color.FromArgb(46, 232, 122);
                Scoreboard.Save(_username, "Memory", _score);
                lblBest.Text = $"Best: {Scoreboard.GetBest(_username, "Memory")}";
                SoundManager.PlayCorrect();
            }
            else
            {
                lblResult.Text = $"❌ Wrong! It was: {_target}";
                lblResult.ForeColor = Color.FromArgb(255, 71, 87);
                SoundManager.PlayWrong();
            }

            txtAnswer.Enabled = false;
            btnSubmit.Enabled = false;
            btnReady.Enabled = true;
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