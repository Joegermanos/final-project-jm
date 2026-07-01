namespace RH
{
    partial class FormSignUp
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
            lblRules = new Label();
            lblUserLbl = new Label();
            pnlUser = new Panel();
            txtUsername = new TextBox();
            lblPassLbl = new Label();
            pnlPass = new Panel();
            txtPassword = new TextBox();
            lblConfLbl = new Label();
            pnlConf = new Panel();
            txtConfirm = new TextBox();
            lblError = new Label();
            btnRegister = new Button();
            btnBack = new Button();

            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();

            // ── Left panel ────────────────────────────────────────────
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Size = new Size(420, 650);
            pnlLeft.BackColor = Color.FromArgb(55, 30, 160);
            pnlLeft.Controls.AddRange(new Control[] { lblBrand, lblTagline });

            lblBrand.AutoSize = false;
            lblBrand.Text = "🧠 BrainRush";
            lblBrand.Font = new Font("Segoe UI", 26, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.BackColor = Color.Transparent;
            lblBrand.Location = new Point(35, 215);
            lblBrand.Size = new Size(350, 55);

            lblTagline.AutoSize = false;
            lblTagline.Text = "Join the challenge today!";
            lblTagline.Font = new Font("Segoe UI", 12);
            lblTagline.ForeColor = Color.FromArgb(190, 190, 255);
            lblTagline.BackColor = Color.Transparent;
            lblTagline.Location = new Point(35, 278);
            lblTagline.Size = new Size(360, 36);

            // ── Right panel ───────────────────────────────────────────
            pnlRight.Location = new Point(420, 0);
            pnlRight.Size = new Size(580, 650);
            pnlRight.BackColor = Color.FromArgb(12, 12, 30);
            pnlRight.Controls.AddRange(new Control[]
            {
                lblTitle, lblSub, lblRules,
                lblUserLbl, pnlUser,
                lblPassLbl, pnlPass,
                lblConfLbl, pnlConf,
                lblError, btnRegister, btnBack
            });

            lblTitle.AutoSize = false;
            lblTitle.Text = "Create Account";
            lblTitle.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(235, 235, 255);
            lblTitle.Location = new Point(75, 50);
            lblTitle.Size = new Size(430, 46);

            lblSub.AutoSize = false;
            lblSub.Text = "Fill in the details below";
            lblSub.Font = new Font("Segoe UI", 11);
            lblSub.ForeColor = Color.FromArgb(120, 120, 155);
            lblSub.Location = new Point(75, 100);
            lblSub.Size = new Size(430, 26);

            lblRules.AutoSize = false;
            lblRules.Text = "🔒 Password: 6+ chars · uppercase · lowercase · number";
            lblRules.Font = new Font("Segoe UI", 9);
            lblRules.ForeColor = Color.FromArgb(0, 212, 255);
            lblRules.Location = new Point(75, 130);
            lblRules.Size = new Size(430, 20);

            lblUserLbl.AutoSize = false;
            lblUserLbl.Text = "USERNAME";
            lblUserLbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblUserLbl.ForeColor = Color.FromArgb(108, 73, 255);
            lblUserLbl.Location = new Point(75, 168);
            lblUserLbl.Size = new Size(200, 18);

            pnlUser.Location = new Point(75, 190);
            pnlUser.Size = new Size(430, 44);
            pnlUser.BackColor = Color.FromArgb(28, 28, 58);
            pnlUser.Controls.Add(txtUsername);

            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.BackColor = Color.FromArgb(28, 28, 58);
            txtUsername.ForeColor = Color.FromArgb(235, 235, 255);
            txtUsername.Font = new Font("Segoe UI", 13);
            txtUsername.Location = new Point(12, 9);
            txtUsername.Size = new Size(406, 26);

            lblPassLbl.AutoSize = false;
            lblPassLbl.Text = "PASSWORD";
            lblPassLbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblPassLbl.ForeColor = Color.FromArgb(108, 73, 255);
            lblPassLbl.Location = new Point(75, 250);
            lblPassLbl.Size = new Size(200, 18);

            pnlPass.Location = new Point(75, 272);
            pnlPass.Size = new Size(430, 44);
            pnlPass.BackColor = Color.FromArgb(28, 28, 58);
            pnlPass.Controls.Add(txtPassword);

            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.BackColor = Color.FromArgb(28, 28, 58);
            txtPassword.ForeColor = Color.FromArgb(235, 235, 255);
            txtPassword.Font = new Font("Segoe UI", 13);
            txtPassword.PasswordChar = '●';
            txtPassword.Location = new Point(12, 9);
            txtPassword.Size = new Size(406, 26);

            lblConfLbl.AutoSize = false;
            lblConfLbl.Text = "CONFIRM PASSWORD";
            lblConfLbl.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblConfLbl.ForeColor = Color.FromArgb(108, 73, 255);
            lblConfLbl.Location = new Point(75, 332);
            lblConfLbl.Size = new Size(250, 18);

            pnlConf.Location = new Point(75, 354);
            pnlConf.Size = new Size(430, 44);
            pnlConf.BackColor = Color.FromArgb(28, 28, 58);
            pnlConf.Controls.Add(txtConfirm);

            txtConfirm.BorderStyle = BorderStyle.None;
            txtConfirm.BackColor = Color.FromArgb(28, 28, 58);
            txtConfirm.ForeColor = Color.FromArgb(235, 235, 255);
            txtConfirm.Font = new Font("Segoe UI", 13);
            txtConfirm.PasswordChar = '●';
            txtConfirm.Location = new Point(12, 9);
            txtConfirm.Size = new Size(406, 26);

            lblError.AutoSize = false;
            lblError.Text = string.Empty;
            lblError.Font = new Font("Segoe UI", 10);
            lblError.ForeColor = Color.FromArgb(255, 71, 87);
            lblError.Location = new Point(75, 406);
            lblError.Size = new Size(430, 22);
            lblError.Visible = false;

            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Text = "Create Account";
            btnRegister.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            btnRegister.BackColor = Color.FromArgb(108, 73, 255);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(75, 436);
            btnRegister.Size = new Size(430, 52);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Click += new EventHandler(btnRegister_Click);

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 120);
            btnBack.Text = "← Back to Login";
            btnBack.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(22, 22, 48);
            btnBack.ForeColor = Color.FromArgb(190, 190, 255);
            btnBack.Location = new Point(75, 502);
            btnBack.Size = new Size(430, 46);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += new EventHandler(btnBack_Click);

            ClientSize = new Size(1000, 650);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "BrainRush — Sign Up";
            BackColor = Color.FromArgb(12, 12, 30);
            Controls.AddRange(new Control[] { pnlLeft, pnlRight });

            pnlLeft.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlLeft, pnlRight, pnlUser, pnlPass, pnlConf;
        private Label lblBrand, lblTagline, lblTitle, lblSub, lblRules;
        private Label lblUserLbl, lblPassLbl, lblConfLbl, lblError;
        private TextBox txtUsername, txtPassword, txtConfirm;
        private Button btnRegister, btnBack;
    }
}