using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RH
{
    public partial class Form2 : Form
    {
        private readonly string _username;

        public Form2(string username)
        {
            InitializeComponent();
            _username = username;
            lblWelcome.Text = $"Welcome back, {_username}! 👋";
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using var grad = new LinearGradientBrush(
                new Point(0, 0), new Point(pnlHeader.Width, 0),
                Color.FromArgb(80, 50, 200), Color.FromArgb(12, 12, 30));
            e.Graphics.FillRectangle(grad, 0, 0, pnlHeader.Width, pnlHeader.Height);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            new FormLevel(_username).Show();
            this.Close();
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            new FormRandom(_username).Show();
            this.Close();
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            new FormMemory(_username).Show();
            this.Close();
        }

        private void btnQuickPick_Click(object sender, EventArgs e)
        {
            new FormQuickPick(_username).Show();
            this.Close();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            new FormLeaderboard(_username).Show();
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            new FormCalculator(_username).Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormWelcome fw = new FormWelcome();
            fw.Show();
            this.Close();
        }
    }
}
