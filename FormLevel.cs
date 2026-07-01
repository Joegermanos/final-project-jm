using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RH
{
    public partial class FormLevel : Form
    {
        private readonly string _username;

        public FormLevel(string username)
        {
            InitializeComponent();
            _username = username;
            SetupCustomUI();
        }

        private void SetupCustomUI()
        {
            // Custom Gradient painting moved here to prevent Designer issues
            pnlHeader.Paint += (s, e) =>
            {
                using var grad = new LinearGradientBrush(
                    new Point(0, 0), new Point(1000, 0),
                    Color.FromArgb(108, 73, 255), Color.FromArgb(12, 12, 30));
                e.Graphics.FillRectangle(grad, 0, 0, 1000, 100);
            };
        }

        private void OpenGame(int min, int max, string level)
        {
            new FormGuess(min, max, level, _username).Show();
            this.Close();
        }

        private void btnEasy_Click(object sender, EventArgs e) => OpenGame(0, 25, "Easy");
        private void btnMedium_Click(object sender, EventArgs e) => OpenGame(0, 75, "Medium");
        private void btnHard_Click(object sender, EventArgs e) => OpenGame(0, 200, "Hard");
        private void btnImpossible_Click(object sender, EventArgs e) => OpenGame(0, 500, "Impossible");

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form2(_username).Show();
            this.Close();
        }
    }
}