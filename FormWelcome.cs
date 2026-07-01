using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RH
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();

            // Add panel borders here where it won't break the Designer
            PaintPanelBorder(pnlUser);
            PaintPanelBorder(pnlPass);
        }

        private void PaintPanelBorder(Panel pnl)
        {
            pnl.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(80, 80, 140), 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);
            };
        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using var grad = new LinearGradientBrush(
                new Point(0, 0), new Point(pnlLeft.Width, pnlLeft.Height),
                Color.FromArgb(90, 55, 220), Color.FromArgb(35, 20, 100));
            g.FillRectangle(grad, 0, 0, pnlLeft.Width, pnlLeft.Height);

            using var p1 = new Pen(Color.FromArgb(55, 255, 255, 255), 2);
            g.DrawEllipse(p1, -80, 360, 320, 320);
            g.DrawEllipse(p1, 200, 430, 220, 220);
            g.DrawEllipse(p1, 80, 40, 180, 180);
            g.DrawEllipse(p1, 280, 120, 110, 110);

            using var p2 = new Pen(Color.FromArgb(25, 0, 212, 255), 1);
            g.DrawEllipse(p2, 30, 280, 380, 380);
            g.DrawEllipse(p2, 120, 80, 280, 280);

            using var dotBrush = new SolidBrush(Color.FromArgb(70, 255, 255, 255));
            for (int i = 0; i < 12; i++)
            {
                int x = (i * 61 + 30) % (pnlLeft.Width - 10);
                int y = (i * 83 + 50) % (pnlLeft.Height - 10);
                g.FillEllipse(dotBrush, x, y, 4, 4);
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowError("Please enter your username and password.");
                return;
            }

            string result = User.SignIn(username, password);

            if (result != null)
            {
                new Form2(username).Show();
                this.Hide();
            }
            else
            {
                ShowError("Incorrect username or password.");
                SoundManager.PlayWrong();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            new FormSignUp(this).Show();
            this.Hide();
        }

        private void ShowError(string msg)
        {
            lblError.Text = "⚠  " + msg;
            lblError.Visible = true;
        }

        public void ResetForm()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            lblError.Visible = false;
            txtUsername.Focus();
        }
    }
}