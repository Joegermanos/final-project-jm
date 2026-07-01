namespace RH
{
    partial class FormMemory
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
            pnlCard = new Panel();
            lblPrompt = new Label();
            lblNumber = new Label();
            lblTimer = new Label();
            pnlAnswer = new Panel();
            txtAnswer = new TextBox();
            lblResult = new Label();
            lblScore = new Label();
            btnReady = new Button();
            btnSubmit = new Button();
            btnBack = new Button();
            btnLogout = new Button();
            timer1 = new System.Windows.Forms.Timer();

            pnlHeader.SuspendLayout();
            pnlCard.SuspendLayout();
            pnlAnswer.SuspendLayout();
            SuspendLayout();

            // pnlHeader
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(1000, 80);
            pnlHeader.BackColor = Color.FromArgb(46, 200, 100);
            pnlHeader.Controls.AddRange(new Control[] { lblHeader, lblBest });

            lblHeader.AutoSize = false;
            lblHeader.Text = "🧠 Memory Game";
            lblHeader.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Location = new Point(30, 14);
            lblHeader.Size = new Size(500, 44);

            lblBest.AutoSize = false;
            lblBest.Text = "Best: 0";
            lblBest.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            lblBest.ForeColor = Color.FromArgb(220, 255, 220);
            lblBest.BackColor = Color.Transparent;
            lblBest.Location = new Point(800, 22);
            lblBest.Size = new Size(160, 30);

            // pnlCard
            pnlCard.Location = new Point(150, 115);
            pnlCard.Size = new Size(700, 300);
            pnlCard.BackColor = Color.FromArgb(20, 20, 48);
            pnlCard.Controls.AddRange(new Control[] { lblPrompt, lblNumber, lblTimer });

            lblPrompt.AutoSize = false;
            lblPrompt.Text = "Memorize this number:";
            lblPrompt.Font = new Font("Segoe UI", 13);
            lblPrompt.ForeColor = Color.FromArgb(130, 130, 170);
            lblPrompt.BackColor = Color.Transparent;
            lblPrompt.TextAlign = ContentAlignment.MiddleCenter;
            lblPrompt.Location = new Point(0, 30);
            lblPrompt.Size = new Size(700, 30);

            lblNumber.AutoSize = false;
            lblNumber.Text = "— — —";
            lblNumber.Font = new Font("Segoe UI", 60, FontStyle.Bold);
            lblNumber.ForeColor = Color.FromArgb(108, 73, 255);
            lblNumber.BackColor = Color.Transparent;
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            lblNumber.Location = new Point(0, 70);
            lblNumber.Size = new Size(700, 120);

            lblTimer.AutoSize = false;
            lblTimer.Text = "Press Ready!";
            lblTimer.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTimer.ForeColor = Color.FromArgb(0, 212, 255);
            lblTimer.BackColor = Color.Transparent;
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblTimer.Location = new Point(0, 200);
            lblTimer.Size = new Size(700, 40);

            // pnlAnswer
            pnlAnswer.Location = new Point(300, 440);
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
            txtAnswer.Enabled = false;

            // Labels
            lblResult.AutoSize = false;
            lblResult.Text = string.Empty;
            lblResult.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            lblResult.ForeColor = Color.FromArgb(46, 232, 122);
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Location = new Point(150, 508);
            lblResult.Size = new Size(700, 36);

            lblScore.AutoSize = false;
            lblScore.Text = "Score: 0";
            lblScore.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblScore.ForeColor = Color.FromArgb(108, 73, 255);
            lblScore.TextAlign = ContentAlignment.MiddleRight;
            lblScore.Location = new Point(720, 440);
            lblScore.Size = new Size(230, 52);

            // Buttons
            btnReady.FlatStyle = FlatStyle.Flat;
            btnReady.FlatAppearance.BorderSize = 0;
            btnReady.Text = "✅ Ready!";
            btnReady.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btnReady.BackColor = Color.FromArgb(46, 200, 100);
            btnReady.ForeColor = Color.White;
            btnReady.Location = new Point(50, 440);
            btnReady.Size = new Size(220, 52);
            btnReady.Cursor = Cursors.Hand;
            btnReady.Click += new EventHandler(btnReady_Click);

            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Text = "Submit ✓";
            btnSubmit.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            btnSubmit.BackColor = Color.FromArgb(108, 73, 255);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(350, 555);
            btnSubmit.Size = new Size(300, 50);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Enabled = false;
            btnSubmit.Click += new EventHandler(btnSubmit_Click);

            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 110);
            btnBack.Text = "← Back";
            btnBack.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(18, 18, 40);
            btnBack.ForeColor = Color.FromArgb(160, 160, 210);
            btnBack.Location = new Point(30, 555);
            btnBack.Size = new Size(150, 50);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += new EventHandler(btnBack_Click);

            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Text = "Logout";
            btnLogout.Font = new Font("Segoe UI", 11);
            btnLogout.BackColor = Color.FromArgb(12, 12, 30);
            btnLogout.ForeColor = Color.FromArgb(90, 90, 130);
            btnLogout.Location = new Point(820, 555);
            btnLogout.Size = new Size(150, 50);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Click += new EventHandler(btnLogout_Click);

            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);

            // Form
            ClientSize = new Size(1000, 625);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "BrainRush — Memory";
            BackColor = Color.FromArgb(12, 12, 30);
            Controls.AddRange(new Control[]
            {
                pnlHeader, pnlCard, pnlAnswer,
                lblResult, lblScore,
                btnReady, btnSubmit, btnBack, btnLogout
            });

            pnlHeader.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlAnswer.ResumeLayout(false);
            pnlAnswer.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlHeader, pnlCard, pnlAnswer;
        private Label lblHeader, lblBest, lblPrompt, lblNumber, lblTimer, lblResult, lblScore;
        private TextBox txtAnswer;
        private Button btnReady, btnSubmit, btnBack, btnLogout;
        private System.Windows.Forms.Timer timer1;
    }
}