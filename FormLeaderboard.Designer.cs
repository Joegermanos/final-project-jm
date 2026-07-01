namespace RH
{
    partial class FormLeaderboard
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlTabs = new Panel();
            btnGuess = new Button();
            btnMemory = new Button();
            btnMath = new Button();
            btnQuick = new Button();
            pnlTable = new Panel();
            pnlColHead = new Panel();
            lblColRank = new Label();
            lblColName = new Label();
            lblColPts = new Label();
            pnlScroll = new Panel();
            pnlRows = new Panel();
            btnBack = new Button();

            pnlHeader.SuspendLayout();
            pnlTabs.SuspendLayout();
            pnlTable.SuspendLayout();
            pnlColHead.SuspendLayout();
            pnlScroll.SuspendLayout();
            SuspendLayout();

            // pnlHeader
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(1000, 90);
            pnlHeader.BackColor = Color.FromArgb(255, 215, 0);
            pnlHeader.Controls.AddRange(new Control[] { lblTitle, lblSubtitle });

            lblTitle.AutoSize = false;
            lblTitle.Text = "🏆 Leaderboard";
            lblTitle.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Location = new Point(30, 12);
            lblTitle.Size = new Size(500, 48);

            lblSubtitle.AutoSize = false;
            lblSubtitle.Text = "See how you rank against other players";
            lblSubtitle.Font = new Font("Segoe UI", 11);
            lblSubtitle.ForeColor = Color.FromArgb(255, 240, 180);
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Location = new Point(30, 60);
            lblSubtitle.Size = new Size(500, 24);

            // pnlTabs
            pnlTabs.Location = new Point(0, 90);
            pnlTabs.Size = new Size(1000, 60);
            pnlTabs.BackColor = Color.FromArgb(18, 18, 40);
            pnlTabs.Controls.AddRange(new Control[] { btnGuess, btnMemory, btnMath, btnQuick });

            // Button Styles (Standardizing properties for Designer)
            btnGuess.FlatStyle = FlatStyle.Flat;
            btnGuess.FlatAppearance.BorderSize = 0;
            btnGuess.Text = "🎯 Number Guess";
            btnGuess.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnGuess.BackColor = Color.FromArgb(28, 28, 58);
            btnGuess.ForeColor = Color.FromArgb(160, 160, 210);
            btnGuess.Location = new Point(20, 10);
            btnGuess.Size = new Size(220, 40);
            btnGuess.Cursor = Cursors.Hand;
            btnGuess.Click += new EventHandler(btnGuess_Click);

            btnMemory.FlatStyle = FlatStyle.Flat;
            btnMemory.FlatAppearance.BorderSize = 0;
            btnMemory.Text = "🧠 Memory";
            btnMemory.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnMemory.BackColor = Color.FromArgb(28, 28, 58);
            btnMemory.ForeColor = Color.FromArgb(160, 160, 210);
            btnMemory.Location = new Point(260, 10);
            btnMemory.Size = new Size(220, 40);
            btnMemory.Cursor = Cursors.Hand;
            btnMemory.Click += new EventHandler(btnMemory_Click);

            btnMath.FlatStyle = FlatStyle.Flat;
            btnMath.FlatAppearance.BorderSize = 0;
            btnMath.Text = "➗ Math Quiz";
            btnMath.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnMath.BackColor = Color.FromArgb(28, 28, 58);
            btnMath.ForeColor = Color.FromArgb(160, 160, 210);
            btnMath.Location = new Point(500, 10);
            btnMath.Size = new Size(220, 40);
            btnMath.Cursor = Cursors.Hand;
            btnMath.Click += new EventHandler(btnMath_Click);

            btnQuick.FlatStyle = FlatStyle.Flat;
            btnQuick.FlatAppearance.BorderSize = 0;
            btnQuick.Text = "⚡ Quick Pick";
            btnQuick.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnQuick.BackColor = Color.FromArgb(28, 28, 58);
            btnQuick.ForeColor = Color.FromArgb(160, 160, 210);
            btnQuick.Location = new Point(740, 10);
            btnQuick.Size = new Size(220, 40);
            btnQuick.Cursor = Cursors.Hand;
            btnQuick.Click += new EventHandler(btnQuick_Click);

            // pnlTable
            pnlTable.Location = new Point(30, 165);
            pnlTable.Size = new Size(940, 380);
            pnlTable.BackColor = Color.FromArgb(18, 18, 42);
            pnlTable.Controls.AddRange(new Control[] { pnlColHead, pnlScroll });

            pnlColHead.Location = new Point(0, 0);
            pnlColHead.Size = new Size(940, 42);
            pnlColHead.BackColor = Color.FromArgb(28, 28, 60);
            pnlColHead.Controls.AddRange(new Control[] { lblColRank, lblColName, lblColPts });

            lblColRank.AutoSize = false;
            lblColRank.Text = "Rank";
            lblColRank.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblColRank.ForeColor = Color.FromArgb(108, 73, 255);
            lblColRank.Location = new Point(10, 10);
            lblColRank.Size = new Size(70, 24);

            lblColName.AutoSize = false;
            lblColName.Text = "Player";
            lblColName.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblColName.ForeColor = Color.FromArgb(108, 73, 255);
            lblColName.Location = new Point(80, 10);
            lblColName.Size = new Size(560, 24);

            lblColPts.AutoSize = false;
            lblColPts.Text = "Best Score";
            lblColPts.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblColPts.ForeColor = Color.FromArgb(108, 73, 255);
            lblColPts.TextAlign = ContentAlignment.MiddleRight;
            lblColPts.Location = new Point(680, 10);
            lblColPts.Size = new Size(250, 24);

            pnlScroll.Location = new Point(40, 42);
            pnlScroll.Size = new Size(860, 338);
            pnlScroll.BackColor = Color.Transparent;
            pnlScroll.AutoScroll = true;
            pnlScroll.Controls.Add(pnlRows);

            pnlRows.Location = new Point(0, 0);
            pnlRows.Size = new Size(860, 400);
            pnlRows.BackColor = Color.Transparent;

            // btnBack
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 120);
            btnBack.Text = "← Back to Menu";
            btnBack.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(20, 20, 48);
            btnBack.ForeColor = Color.FromArgb(180, 180, 230);
            btnBack.Location = new Point(375, 564);
            btnBack.Size = new Size(250, 48);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += new EventHandler(btnBack_Click);

            // Form
            ClientSize = new Size(1000, 630);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "BrainRush — Leaderboard";
            BackColor = Color.FromArgb(12, 12, 30);
            Controls.AddRange(new Control[]
            {
                pnlHeader, pnlTabs, pnlTable, btnBack
            });

            pnlHeader.ResumeLayout(false);
            pnlTabs.ResumeLayout(false);
            pnlTable.ResumeLayout(false);
            pnlColHead.ResumeLayout(false);
            pnlScroll.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlHeader, pnlTabs, pnlTable, pnlColHead, pnlScroll, pnlRows;
        private Label lblTitle, lblSubtitle;
        private Label lblColRank, lblColName, lblColPts;
        private Button btnGuess, btnMemory, btnMath, btnQuick, btnBack;
    }
}