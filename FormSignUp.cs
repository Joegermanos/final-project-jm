using System;
using System.Drawing;
using System.Windows.Forms;

namespace RH
{
    public partial class FormSignUp : Form
    {
        private readonly FormWelcome _welcome;

        public FormSignUp(FormWelcome fw)
        {
            InitializeComponent();
            _welcome = fw;

            // --- DESIGN LOGIC (Moved here to keep the Designer from breaking) ---

            // 1. Left Panel Gradient and Shapes
            pnlLeft.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using var grad = new System.Drawing.Drawing2D.LinearGradientBrush(
                    new Point(0, 0), new Point(pnlLeft.Width, pnlLeft.Height),
                    Color.FromArgb(90, 55, 220), Color.FromArgb(35, 20, 100));
                g.FillRectangle(grad, 0, 0, pnlLeft.Width, pnlLeft.Height);

                using var pen = new Pen(Color.FromArgb(50, 255, 255, 255), 2);
                g.DrawEllipse(pen, -60, 350, 290, 290);
                g.DrawEllipse(pen, 210, 430, 200, 200);
                g.DrawEllipse(pen, 90, 50, 170, 170);
            };

            // 2. Input Field Borders
            PaintPanelBorder(pnlUser);
            PaintPanelBorder(pnlPass);
            PaintPanelBorder(pnlConf);
        }

        // Helper method for drawing the borders on text box containers
        private void PaintPanelBorder(Panel pnl)
        {
            pnl.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(80, 80, 140), 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);
            };
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))
            {
                ShowError("Please fill in all fields.");
                return;
            }

            if (username.Length < 3)
            {
                ShowError("Username must be at least 3 characters.");
                return;
            }

            string pwErr = User.ValidatePassword(password);
            if (pwErr != null)
            {
                ShowError(pwErr);
                return;
            }

            if (password != confirm)
            {
                ShowError("Passwords do not match.");
                txtPassword.Clear();
                txtConfirm.Clear();
                return;
            }

            if (User.UsernameExists(username))
            {
                ShowError("Username is already taken.");
                return;
            }

            User.SignUp(username, password);
            SoundManager.PlaySuccess();

            MessageBox.Show("Account created! You can now sign in.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            _welcome.ResetForm();
            _welcome.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _welcome.ResetForm();
            _welcome.Show();
            this.Close();
        }

        private void ShowError(string msg)
        {
            lblError.Text = "⚠  " + msg;
            lblError.Visible = true;
        }
    }
}