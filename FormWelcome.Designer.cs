namespace RH
{
    partial class FormWelcome
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            lblBrand = new Label();
            lblTagline = new Label();
            pnlRight = new Panel();
            lblTitle = new Label();
            lblSub = new Label();
            lblUserLbl = new Label();
            pnlUser = new Panel();
            txtUsername = new TextBox();
            lblPassLbl = new Label();
            pnlPass = new Panel();
            txtPassword = new TextBox();
            lblError = new Label();
            btnSignIn = new Button();
            btnSignUp = new Button();
            lblOr = new Label();

            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();

            // ── Left decorative panel ─────────────────────────────────
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Size = new Size(420, 650);
            pnlLeft.BackColor = Color.FromArgb(60, 30, 160);
            pnlLeft.Controls.AddRange(new Control[] { lblBrand, lblTagline });
            pnlLeft.Paint += new PaintEventHandler(pnlLeft_Paint);

            lblBrand.AutoSize = false;
            lblBrand.Text = "🧠 BrainRush";
            lblBrand.Font = new Font("Segoe UI", 26, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.BackColor = Color.Transparent;
            lblBrand.Location = new Point(35, 215);
            lblBrand.Size = new Size(350, 55);

            lblTagline.AutoSize = false;
            lblTagline.Text = "Train your mind. Beat your friends.";
            lblTagline.Font = new Font("Segoe UI", 12);
            lblTagline.ForeColor = Color.FromArgb(190, 190, 255);
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Location = new Point(35, 278);
            lblTagline.Size = new Size(360, 36);

            // ── Right form panel ──────────────────────────────────────
            pnlRight.Location = new Point(420, 0);
            pnlRight.Size = new Size(580, 650);
            pnlRight.BackColor = Color.FromArgb(12, 12, 30);
            pnlRight.Controls.AddRange(new Control[]
            {
                lblTitle, lblSub, lblUserLbl, pnlUser,
                lblPassLbl, pnlPass, lblError, btnSignIn, lblOr, btnSignUp
            });

            lblTitle.AutoSize = false;
            lblTitle.Text = "Welcome back!";
            lblTitle.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(235, 235, 255);
            lblTitle.Location = new Point(90, 90);
            lblTitle.Size = new Size(400, 48);

            lblSub.AutoSize = false;
            lblSub.Text = "Sign in to your account";
            lblSub.Font = new Font("Segoe UI", 12);
            lblSub.ForeColor = Color.FromArgb(120, 120, 155);
            lblSub.Location = new Point(90, 142);
            lblSub.Size = new Size(400, 28);

            lblUserLbl.AutoSize = false;
            lblUserLbl.Text = "USERNAME";
            lblUserLbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblUserLbl.ForeColor = Color.FromArgb(108, 73, 255);
            lblUserLbl.Location = new Point(90, 206);
            lblUserLbl.Size = new Size(200, 20);

            pnlUser.Location = new Point(90, 230);
            pnlUser.Size = new Size(400, 46);
            pnlUser.BackColor = Color.FromArgb(28, 28, 58);
            pnlUser.Controls.Add(txtUsername);

            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.BackColor = Color.FromArgb(28, 28, 58);
            txtUsername.ForeColor = Color.FromArgb(235, 235, 255);
            txtUsername.Font = new Font("Segoe UI", 13);
            txtUsername.Location = new Point(12, 10);
            txtUsername.Size = new Size(376, 26);

            lblPassLbl.AutoSize = false;
            lblPassLbl.Text = "PASSWORD";
            lblPassLbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblPassLbl.ForeColor = Color.FromArgb(108, 73, 255);
            lblPassLbl.Location = new Point(90, 296);
            lblPassLbl.Size = new Size(200, 20);

            pnlPass.Location = new Point(90, 320);
            pnlPass.Size = new Size(400, 46);
            pnlPass.BackColor = Color.FromArgb(28, 28, 58);
            pnlPass.Controls.Add(txtPassword);

            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.BackColor = Color.FromArgb(28, 28, 58);
            txtPassword.ForeColor = Color.FromArgb(235, 235, 255);
            txtPassword.Font = new Font("Segoe UI", 13);
            txtPassword.PasswordChar = '●';
            txtPassword.Location = new Point(12, 10);
            txtPassword.Size = new Size(376, 26);

            lblError.AutoSize = false;
            lblError.Text = string.Empty;
            lblError.Font = new Font("Segoe UI", 10);
            lblError.ForeColor = Color.FromArgb(255, 71, 87);
            lblError.Location = new Point(90, 375);
            lblError.Size = new Size(400, 22);
            lblError.Visible = false;

            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.Text = "Sign In";
            btnSignIn.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            btnSignIn.BackColor = Color.FromArgb(108, 73, 255);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(90, 405);
            btnSignIn.Size = new Size(400, 52);
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.Click += new EventHandler(btnSignIn_Click);

            lblOr.AutoSize = false;
            lblOr.Text = "— Don't have an account? —";
            lblOr.Font = new Font("Segoe UI", 10);
            lblOr.ForeColor = Color.FromArgb(90, 90, 120);
            lblOr.TextAlign = ContentAlignment.MiddleCenter;
            lblOr.Location = new Point(90, 467);
            lblOr.Size = new Size(400, 24);

            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.FlatAppearance.BorderSize = 1;
            btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 120);
            btnSignUp.Text = "Create Account";
            btnSignUp.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            btnSignUp.BackColor = Color.FromArgb(22, 22, 48);
            btnSignUp.ForeColor = Color.FromArgb(190, 190, 255);
            btnSignUp.Location = new Point(90, 500);
            btnSignUp.Size = new Size(400, 52);
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.Click += new EventHandler(btnSignUp_Click);

            // ── Form ──────────────────────────────────────────────────
            ClientSize = new Size(1000, 650);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "BrainRush";
            BackColor = Color.FromArgb(12, 12, 30);
            Controls.AddRange(new Control[] { pnlLeft, pnlRight });

            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlLeft, pnlRight, pnlUser, pnlPass;
        private Label lblBrand, lblTagline, lblTitle, lblSub;
        private Label lblUserLbl, lblPassLbl, lblError, lblOr;
        private TextBox txtUsername, txtPassword;
        private Button btnSignIn, btnSignUp;
    }
}