namespace RH
{
    partial class FormRandom
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
            lblHeader = new Label();
            lblBest = new Label();
            pnlContent = new Panel();
            lblQuestion = new Label();
            lblFeedback = new Label();
            pnlAnswer = new Panel();
            txtAnswer = new TextBox();
            lblTimer = new Label();
            lblScore = new Label();
            btnSubmit = new Button();
            btnNext = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            timer1 = new System.Windows.Forms.Timer();

            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();

            // Header Panel
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(1000, 80);
            pnlHeader.BackColor = Color.FromArgb(0, 180, 230);
            pnlHeader.Controls.AddRange(new Control[] { lblHeader, lblBest });

            lblHeader.AutoSize = false;
            lblHeader.Text = "➗ Math Quiz";
            lblHeader.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Location = new Point(30, 14);
            lblHeader.Size = new Size(500, 44);

            lblBest.AutoSize = false;
            lblBest.Text = "Best: 0";
            lblBest.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblBest.ForeColor = Color.FromArgb(200, 240, 255);
            lblBest.BackColor = Color.Transparent;
            lblBest.Location = new Point(800, 22);
            lblBest.Size = new Size(160, 30);

            // Content Panel
            pnlContent.Location = new Point(80, 115);
            pnlContent.Size = new Size(840, 220);
            pnlContent.BackColor = Color.FromArgb(20, 20, 48);
            pnlContent.Controls.AddRange(new Control[] { lblQuestion, lblFeedback });

            lblQuestion.AutoSize = false;
            lblQuestion.Text = "...";
            lblQuestion.Font = new Font("Segoe UI", 36, FontStyle.Bold);
            lblQuestion.ForeColor = Color.FromArgb(235, 235, 255);
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestion.Location = new Point(0, 30);
            lblQuestion.Size = new Size(840, 100);

            lblFeedback.AutoSize = false;
            lblFeedback.Text = string.Empty;
            lblFeedback.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            lblFeedback.ForeColor = Color.FromArgb(46, 232, 122);
            lblFeedback.BackColor = Color.Transparent;
            lblFeedback.TextAlign = ContentAlignment.MiddleCenter;
            lblFeedback.Location = new Point(0, 148);
            lblFeedback.Size = new Size(840, 50);

            // Answer Panel
            pnlAnswer.Location = new Point(300, 365);
            pnlAnswer.Size = new Size(400, 52);
            pnlAnswer.BackColor = Color.FromArgb(28, 28, 58);
            pnlAnswer.Controls.Add(txtAnswer);

            txtAnswer.BorderStyle = BorderStyle.None;
            txtAnswer.BackColor = Color.FromArgb(28, 28, 58);
            txtAnswer.ForeColor = Color.FromArgb(235, 235, 255);
            txtAnswer.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            txtAnswer.TextAlign = HorizontalAlignment.Center;
            txtAnswer.Location = new Point(10, 10);
            txtAnswer.Size = new Size(380, 32);

            lblTimer.AutoSize = false;
            lblTimer.Text = "10.0s";
            lblTimer.Font = new Font("Segoe UI", 26, FontStyle.Bold);
            lblTimer.ForeColor = Color.FromArgb(0, 212, 255);
            lblTimer.TextAlign = ContentAlignment.MiddleRight;
            lblTimer.Location = new Point(720, 355);
            lblTimer.Size = new Size(200, 70);

            lblScore.AutoSize = false;
            lblScore.Text = "Score: 0";
            lblScore.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblScore.ForeColor = Color.FromArgb(108, 73, 255);
            lblScore.Location = new Point(80, 370);
            lblScore.Size = new Size(200, 50);

            // Buttons
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Text = "Submit ✓";
            btnSubmit.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btnSubmit.BackColor = Color.FromArgb(0, 180, 230);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(350, 440);
            btnSubmit.Size = new Size(300, 52);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Click += new EventHandler(btnSubmit_Click);

            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.Text = "Next ➜";
            btnNext.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btnNext.BackColor = Color.FromArgb(108, 73, 255);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(350, 508);
            btnNext.Size = new Size(300, 52);
            btnNext.Cursor = Cursors.Hand;
            btnNext.Enabled = false;
            btnNext.Click += new EventHandler(btnNext_Click);

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 110);
            btnBack.Text = "← Back";
            btnBack.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(18, 18, 40);
            btnBack.ForeColor = Color.FromArgb(160, 160, 210);
            btnBack.Location = new Point(30, 530);
            btnBack.Size = new Size(150, 46);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += new EventHandler(btnBack_Click);

            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Text = "Logout";
            btnLogout.Font = new Font("Segoe UI", 11);
            btnLogout.BackColor = Color.FromArgb(12, 12, 30);
            btnLogout.ForeColor = Color.FromArgb(90, 90, 130);
            btnLogout.Location = new Point(820, 530);
            btnLogout.Size = new Size(150, 46);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Click += new EventHandler(btnLogout_Click);

            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);

            ClientSize = new Size(1000, 600);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "BrainRush — Math Quiz";
            BackColor = Color.FromArgb(12, 12, 30);
            Controls.AddRange(new Control[]
            {
                pnlHeader, pnlContent, pnlAnswer,
                lblTimer, lblScore,
                btnSubmit, btnNext, btnBack, btnLogout
            });

            pnlHeader.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlHeader, pnlContent, pnlAnswer;
        private Label lblHeader, lblBest, lblQuestion, lblFeedback, lblTimer, lblScore;
        private TextBox txtAnswer;
        private Button btnSubmit, btnNext, btnBack, btnLogout;
        private System.Windows.Forms.Timer timer1;
    }
}