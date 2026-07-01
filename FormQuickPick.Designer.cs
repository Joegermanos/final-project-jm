namespace RH
{
    partial class FormQuickPick
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
            lblTimer = new Label();
            lblScore = new Label();
            lblLives = new Label();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            btnNext = new Button();
            btnRestart = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            timer1 = new System.Windows.Forms.Timer();

            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();

            // Header Panel
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(1000, 80);
            pnlHeader.BackColor = Color.FromArgb(255, 140, 50);
            pnlHeader.Controls.AddRange(new Control[] { lblHeader, lblBest });

            lblHeader.AutoSize = false;
            lblHeader.Text = "⚡ Quick Pick";
            lblHeader.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Location = new Point(30, 14);
            lblHeader.Size = new Size(500, 44);

            lblBest.AutoSize = false;
            lblBest.Text = "Best: 0";
            lblBest.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblBest.ForeColor = Color.FromArgb(255, 235, 180);
            lblBest.BackColor = Color.Transparent;
            lblBest.Location = new Point(800, 22);
            lblBest.Size = new Size(160, 30);

            // Content Panel
            pnlContent.Location = new Point(80, 100);
            pnlContent.Size = new Size(840, 140);
            pnlContent.BackColor = Color.FromArgb(20, 20, 48);
            pnlContent.Controls.AddRange(new Control[] { lblQuestion, lblFeedback });

            lblQuestion.AutoSize = false;
            lblQuestion.Text = "...";
            lblQuestion.Font = new Font("Segoe UI", 38, FontStyle.Bold);
            lblQuestion.ForeColor = Color.FromArgb(235, 235, 255);
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            lblQuestion.Location = new Point(0, 10);
            lblQuestion.Size = new Size(840, 80);

            lblFeedback.AutoSize = false;
            lblFeedback.Text = string.Empty;
            lblFeedback.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblFeedback.ForeColor = Color.FromArgb(46, 232, 122);
            lblFeedback.BackColor = Color.Transparent;
            lblFeedback.TextAlign = ContentAlignment.MiddleCenter;
            lblFeedback.Location = new Point(0, 100);
            lblFeedback.Size = new Size(840, 36);

            // Labels
            lblTimer.AutoSize = false;
            lblTimer.Text = "8.0s";
            lblTimer.Font = new Font("Segoe UI", 30, FontStyle.Bold);
            lblTimer.ForeColor = Color.FromArgb(0, 212, 255);
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblTimer.Location = new Point(430, 256);
            lblTimer.Size = new Size(140, 60);

            lblScore.AutoSize = false;
            lblScore.Text = "Score: 0";
            lblScore.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            lblScore.ForeColor = Color.FromArgb(108, 73, 255);
            lblScore.Location = new Point(80, 262);
            lblScore.Size = new Size(200, 50);

            lblLives.AutoSize = false;
            lblLives.Text = "❤️ ❤️ ❤️";
            lblLives.Font = new Font("Segoe UI", 16);
            lblLives.ForeColor = Color.White;
            lblLives.TextAlign = ContentAlignment.MiddleRight;
            lblLives.Location = new Point(700, 262);
            lblLives.Size = new Size(220, 50);

            // Answer Buttons - Basic Setup (Styles in Main Code)
            btnA.Location = new Point(80, 330);
            btnB.Location = new Point(530, 330);
            btnC.Location = new Point(80, 440);
            btnD.Location = new Point(530, 440);

            // Game Control Buttons
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.Text = "Next ➜";
            btnNext.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            btnNext.BackColor = Color.FromArgb(108, 73, 255);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(380, 554);
            btnNext.Size = new Size(240, 48);
            btnNext.Cursor = Cursors.Hand;
            btnNext.Enabled = false;
            btnNext.Click += new EventHandler(btnNext_Click);

            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.FlatAppearance.BorderSize = 0;
            btnRestart.Text = "🔄 Restart";
            btnRestart.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnRestart.BackColor = Color.FromArgb(60, 60, 110);
            btnRestart.ForeColor = Color.FromArgb(180, 180, 230);
            btnRestart.Location = new Point(640, 554);
            btnRestart.Size = new Size(160, 48);
            btnRestart.Cursor = Cursors.Hand;
            btnRestart.Click += new EventHandler(btnRestart_Click);

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 110);
            btnBack.Text = "← Back";
            btnBack.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(18, 18, 40);
            btnBack.ForeColor = Color.FromArgb(160, 160, 210);
            btnBack.Location = new Point(30, 554);
            btnBack.Size = new Size(150, 48);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += new EventHandler(btnBack_Click);

            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Text = "Logout";
            btnLogout.Font = new Font("Segoe UI", 11);
            btnLogout.BackColor = Color.FromArgb(12, 12, 30);
            btnLogout.ForeColor = Color.FromArgb(90, 90, 130);
            btnLogout.Location = new Point(820, 554);
            btnLogout.Size = new Size(150, 48);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Click += new EventHandler(btnLogout_Click);

            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);

            ClientSize = new Size(1000, 620);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "BrainRush — Quick Pick";
            BackColor = Color.FromArgb(12, 12, 30);
            Controls.AddRange(new Control[]
            {
                pnlHeader, pnlContent,
                lblTimer, lblScore, lblLives,
                btnA, btnB, btnC, btnD,
                btnNext, btnRestart, btnBack, btnLogout
            });

            pnlHeader.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlHeader, pnlContent;
        private Label lblHeader, lblBest, lblQuestion, lblFeedback;
        private Label lblTimer, lblScore, lblLives;
        private Button btnA, btnB, btnC, btnD;
        private Button btnNext, btnRestart, btnBack, btnLogout;
        private System.Windows.Forms.Timer timer1;
    }
}