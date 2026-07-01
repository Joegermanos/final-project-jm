namespace RH
{
    partial class FormLevel
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
            lblSub = new Label();
            btnEasy = new Button();
            btnMedium = new Button();
            btnHard = new Button();
            btnImpossible = new Button();
            btnBack = new Button();

            pnlHeader.SuspendLayout();
            SuspendLayout();

            // pnlHeader
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Size = new Size(1000, 100);
            pnlHeader.BackColor = Color.FromArgb(20, 20, 50);
            pnlHeader.Controls.AddRange(new Control[] { lblTitle, lblSub });

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Text = "🎯 Number Guess — Select Difficulty";
            lblTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Location = new Point(40, 18);
            lblTitle.Size = new Size(700, 44);

            // lblSub
            lblSub.AutoSize = false;
            lblSub.Text = "How brave are you?";
            lblSub.Font = new Font("Segoe UI", 11);
            lblSub.ForeColor = Color.FromArgb(190, 190, 255);
            lblSub.BackColor = Color.Transparent;
            lblSub.Location = new Point(40, 64);
            lblSub.Size = new Size(400, 26);

            // btnEasy
            btnEasy.FlatStyle = FlatStyle.Flat;
            btnEasy.FlatAppearance.BorderSize = 0;
            btnEasy.Text = "🟢 EASY\n0 – 25  |  6 attempts";
            btnEasy.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            btnEasy.BackColor = Color.FromArgb(46, 200, 100);
            btnEasy.ForeColor = Color.White;
            btnEasy.Location = new Point(100, 160);
            btnEasy.Size = new Size(350, 110);
            btnEasy.Cursor = Cursors.Hand;
            btnEasy.Click += new EventHandler(btnEasy_Click);

            // btnMedium
            btnMedium.FlatStyle = FlatStyle.Flat;
            btnMedium.FlatAppearance.BorderSize = 0;
            btnMedium.Text = "🟡 MEDIUM\n0 – 75  |  5 attempts";
            btnMedium.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            btnMedium.BackColor = Color.FromArgb(0, 180, 230);
            btnMedium.ForeColor = Color.White;
            btnMedium.Location = new Point(100, 300);
            btnMedium.Size = new Size(350, 110);
            btnMedium.Cursor = Cursors.Hand;
            btnMedium.Click += new EventHandler(btnMedium_Click);

            // btnHard
            btnHard.FlatStyle = FlatStyle.Flat;
            btnHard.FlatAppearance.BorderSize = 0;
            btnHard.Text = "🔴 HARD\n0 – 200  |  4 attempts";
            btnHard.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            btnHard.BackColor = Color.FromArgb(255, 140, 50);
            btnHard.ForeColor = Color.White;
            btnHard.Location = new Point(550, 160);
            btnHard.Size = new Size(350, 110);
            btnHard.Cursor = Cursors.Hand;
            btnHard.Click += new EventHandler(btnHard_Click);

            // btnImpossible
            btnImpossible.FlatStyle = FlatStyle.Flat;
            btnImpossible.FlatAppearance.BorderSize = 0;
            btnImpossible.Text = "💀 IMPOSSIBLE\n0 – 500  |  2 attempts";
            btnImpossible.Font = new Font("Segoe UI", 15, FontStyle.Bold);
            btnImpossible.BackColor = Color.FromArgb(255, 71, 87);
            btnImpossible.ForeColor = Color.White;
            btnImpossible.Location = new Point(550, 300);
            btnImpossible.Size = new Size(350, 110);
            btnImpossible.Cursor = Cursors.Hand;
            btnImpossible.Click += new EventHandler(btnImpossible_Click);

            // btnBack
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(70, 70, 120);
            btnBack.Text = "← Back";
            btnBack.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnBack.BackColor = Color.FromArgb(20, 20, 45);
            btnBack.ForeColor = Color.FromArgb(160, 160, 200);
            btnBack.Location = new Point(400, 488);
            btnBack.Size = new Size(200, 46);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Click += new EventHandler(btnBack_Click);

            // Form Properties
            ClientSize = new Size(1000, 570);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "BrainRush — Select Level";
            BackColor = Color.FromArgb(12, 12, 30);
            Controls.AddRange(new Control[]
            {
                pnlHeader,
                btnEasy, btnMedium, btnHard, btnImpossible,
                btnBack
            });

            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle, lblSub;
        private Button btnEasy, btnMedium, btnHard, btnImpossible, btnBack;
    }
}