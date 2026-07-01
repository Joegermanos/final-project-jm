using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace djoe
{
    public partial class FormLeaderboard : Form
    {
        private readonly string _username;
        private string _selectedGame = "Guess";

        public FormLeaderboard(string username)
        {
            InitializeComponent();
            _username = username;
            SetupCustomUI();

            LoadLeaderboard("Guess");
            HighlightGameBtn(btnGuess);
        }

        private void SetupCustomUI()
        {
            // Move painting logic here to keep the Designer clean
            pnlHeader.Paint += (s, e) =>
            {
                using var grad = new LinearGradientBrush(
                    new Point(0, 0), new Point(1000, 0),
                    Color.FromArgb(200, 160, 0), Color.FromArgb(12, 12, 30));
                e.Graphics.FillRectangle(grad, 0, 0, 1000, 90);
            };

            pnlTable.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(60, 60, 100), 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlTable.Width - 1, pnlTable.Height - 1);
            };

            pnlColHead.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(108, 73, 255), 2);
                e.Graphics.DrawLine(pen, 0, pnlColHead.Height - 1, pnlColHead.Width, pnlColHead.Height - 1);
            };
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            _selectedGame = "Guess";
            LoadLeaderboard("Guess");
            HighlightGameBtn(btnGuess);
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            _selectedGame = "Memory";
            LoadLeaderboard("Memory");
            HighlightGameBtn(btnMemory);
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            _selectedGame = "MathQuiz";
            LoadLeaderboard("MathQuiz");
            HighlightGameBtn(btnMath);
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            _selectedGame = "QuickPick";
            LoadLeaderboard("QuickPick");
            HighlightGameBtn(btnQuick);
        }

        private void LoadLeaderboard(string game)
        {
            List<(string Username, int Score)> entries = Scoreboard.GetLeaderboard(game);

            pnlRows.Controls.Clear();

            if (entries.Count == 0)
            {
                var empty = new Label
                {
                    Text = "No scores yet! Be the first to play.",
                    Font = new Font("Segoe UI", 14),
                    ForeColor = Color.FromArgb(100, 100, 140),
                    AutoSize = false,
                    Size = new Size(860, 60),
                    Location = new Point(0, 30),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                pnlRows.Controls.Add(empty);
                return;
            }

            for (int i = 0; i < entries.Count; i++)
            {
                string medal = i switch
                {
                    0 => "🥇",
                    1 => "🥈",
                    2 => "🥉",
                    _ => $"#{i + 1}"
                };

                Color rowBg = i switch
                {
                    0 => Color.FromArgb(50, 45, 10),
                    1 => Color.FromArgb(35, 35, 45),
                    2 => Color.FromArgb(40, 25, 10),
                    _ => Color.FromArgb(22, 22, 45)
                };

                bool isMe = entries[i].Username == _username;

                var row = new Panel
                {
                    Location = new Point(0, i * 58),
                    Size = new Size(860, 52),
                    BackColor = isMe ? Color.FromArgb(30, 20, 60) : rowBg
                };

                row.Paint += (s, e) =>
                {
                    using var pen = new Pen(Color.FromArgb(50, 50, 80), 1);
                    e.Graphics.DrawLine(pen, 0, row.Height - 1, row.Width, row.Height - 1);

                    if (isMe)
                    {
                        using var accentPen = new Pen(Color.FromArgb(108, 73, 255), 3);
                        e.Graphics.DrawLine(accentPen, 0, 0, 0, row.Height);
                    }
                };

                var lblRank = new Label
                {
                    Text = medal,
                    Font = new Font("Segoe UI", 18),
                    ForeColor = Color.White,
                    AutoSize = false,
                    Location = new Point(10, 8),
                    Size = new Size(60, 36)
                };

                var lblName = new Label
                {
                    Text = entries[i].Username + (isMe ? " (you)" : ""),
                    Font = new Font("Segoe UI", 14, isMe ? FontStyle.Bold : FontStyle.Regular),
                    ForeColor = isMe ? Color.FromArgb(160, 130, 255) : Color.FromArgb(220, 220, 255),
                    AutoSize = false,
                    Location = new Point(80, 10),
                    Size = new Size(560, 32)
                };

                var lblPts = new Label
                {
                    Text = $"{entries[i].Score} pts",
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    ForeColor = Color.FromArgb(255, 215, 0),
                    AutoSize = false,
                    Location = new Point(680, 10),
                    Size = new Size(170, 32),
                    TextAlign = ContentAlignment.MiddleRight
                };

                row.Controls.AddRange(new Control[] { lblRank, lblName, lblPts });
                pnlRows.Controls.Add(row);
            }

            pnlRows.Height = Math.Max(entries.Count * 58, 400);
        }

        private void HighlightGameBtn(Button active)
        {
            var all = new[] { btnGuess, btnMemory, btnMath, btnQuick };
            foreach (var b in all)
            {
                b.BackColor = Color.FromArgb(28, 28, 58);
                b.ForeColor = Color.FromArgb(160, 160, 210);
            }
            active.BackColor = Color.FromArgb(108, 73, 255);
            active.ForeColor = Color.White;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form2(_username).Show();
            this.Close();
        }
    }
}
