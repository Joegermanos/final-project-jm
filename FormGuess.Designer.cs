namespace RH
{
    partial class FormGuess
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblLevel = new Label();
            lblAttempts = new Label();
            pnlContent = new Panel();
            lblEmoji = new Label();
            lblFeedback = new Label();
            pnlInput = new Panel();
            txtGuess = new TextBox();
            btnCheck = new Button();
            btnRestart = new Button();
            btnBack = new Button();
            btnLogout = new Button();

            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlInput.SuspendLayout();
            SuspendLayout();

            // pnlHeader
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(1000, 80);
            pnlHeader.BackColor = Color.FromArgb(108, 73, 255);
            pnlHeader.Controls.AddRange(new Control[] { lblLevel, lblAttempts });

            // lblLevel
            lblLevel.AutoSize = false;
            lblLevel.Text = "🎯 Number Guess";
            lblLevel.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            lblLevel.ForeColor = Color.White;
            lblLevel.BackColor = Color.Transparent;
            lblLevel.Location = new Point(30, 12);
            lblLevel.Size = new Size(700, 30);

            // lblAttempts
            lblAttempts.AutoSize = false;
            lblAttempts.Text = "Attempts: 0 / 0";
            lblAttempts.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblAttempts.ForeColor = Color.FromArgb(230, 230, 255);
            lblAttempts.BackColor = Color.Transparent;
            lblAttempts.Location = new Point(30, 44);
            lblAttempts.Size = new Size(500, 28);

            // pnlContent
            pnlContent.Location = new Point(150, 120);
            pnlContent.Size = new Size(700, 280);
            pnlContent.BackColor = Color.FromArgb(20, 20, 48);
            pnlContent.Controls.AddRange(new Control[] { lblEmoji, lblFeedback, pnlInput });

            // lblEmoji
            lblEmoji.AutoSize = false;
            lblEmoji.Text = "🤔";
            lblEmoji.Font = new Font("Segoe UI", 56);
            lblEmoji.ForeColor = Color.White;
            lblEmoji.BackColor = Color.Transparent;
            lblEmoji.TextAlign = ContentAlignment.MiddleCenter;
            lblEmoji.Location = new Point(0, 20);
            lblEmoji.Size = new Size(700, 90);

            // lblFeedback
            lblFeedback.AutoSize = false;
            lblFeedback.Text = "Enter a number and press Check!";
            lblFeedback.Font = new Font("Segoe UI", 14);
            lblFeedback.ForeColor = Color.FromArgb(180, 180, 220);
            lblFeedback.BackColor = Color.Transparent;
            lblFeedback.TextAlign = ContentAlignment.MiddleCenter;
            lblFeedback.Location = new Point(20, 120);
            lblFeedback.Size = new Size(660, 60);

            // pnlInput
            pnlInput.Location = new Point(175, 194);
            pnlInput.Size = new Size(350, 50);
            pnlInput.BackColor = Color.FromArgb(30, 30, 62);
            pnlInput.Controls.Add(txtGuess);

            // txtGuess
            txtGuess.BorderStyle = BorderStyle.None;
            txtGuess.BackColor = Color.FromArgb(30, 30, 62);
            txtGuess.ForeColor = Color.FromArgb(235, 235, 255);
            txtGuess.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            txtGuess.TextAlign = HorizontalAlignment.Center;
            txtGuess.Location = new Point(8, 10);
            txtGuess.Size = new Size(334, 30);

            // btnCheck
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.Text = "Check ✓";
            btnCheck.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btnCheck.BackColor = Color.FromArgb(108, 73, 255);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(350, 440);
            btnCheck.Size = new Size(300, 55);
            btnCheck.Cursor = Cursors.Hand;
            btnCheck.Click += new EventHandler(btnCheck_Click);

            // btnRestart
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.FlatAppearance.BorderSize = 1;
            btnRestart.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 130);
            btnRestart.Text = "🔄 Restart";
            btnRestart.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnRestart.BackColor = Color.FromArgb(20, 20, 48);
            btnRestart.ForeColor = Color.FromArgb(180, 180, 230);
            btnRestart.Location = new Point(130, 440);
            btnRestart.Size = new Size(190, 55);
            btnRestart.Cursor = Cursors.Hand;
            btnRestart.Click += new EventHandler(btnRestart_Click);

            // btnBack
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 130);
            btnBack.Text = "← Back";
            btnBack.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(20, 20, 48);
            btnBack.ForeColor = Color.FromArgb(180, 180, 230);
            btnBack.Location = new Point(30, 520);
            btnBack.Size = new Size(160, 46);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += new EventHandler(btnBack_Click);

            // btnLogout
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Text = "Logout";
            btnLogout.Font = new Font("Segoe UI", 11);
            btnLogout.BackColor = Color.FromArgb(12, 12, 30);
            btnLogout.ForeColor = Color.FromArgb(100, 100, 140);
            btnLogout.Location = new Point(820, 520);
            btnLogout.Size = new Size(150, 46);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Click += new EventHandler(btnLogout_Click);

            // Form Properties
            ClientSize = new Size(1000, 590);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "BrainRush — Number Guess";
            BackColor = Color.FromArgb(12, 12, 30);
            Controls.AddRange(new Control[]
            {
                pnlHeader, pnlContent,
                btnCheck, btnRestart, btnBack, btnLogout
            });

            pnlHeader.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlHeader, pnlContent, pnlInput;
        private Label lblLevel, lblAttempts, lblFeedback, lblEmoji;
        private TextBox txtGuess;
        private Button btnCheck, btnRestart, btnBack, btnLogout;
    }
}