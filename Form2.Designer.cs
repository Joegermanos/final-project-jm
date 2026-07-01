namespace RH
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader      = new Panel();
            lblWelcome     = new Label();
            lblSubtitle    = new Label();
            btnGuess       = new Button();
            btnMath        = new Button();
            btnMemory      = new Button();
            btnQuickPick   = new Button();
            btnLeaderboard = new Button();
            btnCalc        = new Button();
            btnLogout      = new Button();

            pnlHeader.SuspendLayout();
            SuspendLayout();

            // ── Header ────────────────────────────────────────────────
            pnlHeader.Location  = new Point(0, 0);
            pnlHeader.Size      = new Size(1000, 110);
            pnlHeader.BackColor = Color.FromArgb(80, 50, 200);
            pnlHeader.Controls.AddRange(new Control[] { lblWelcome, lblSubtitle });
            pnlHeader.Paint += new PaintEventHandler(pnlHeader_Paint);

            lblWelcome.AutoSize  = false;
            lblWelcome.Text      = "Welcome!";
            lblWelcome.Font      = new Font("Segoe UI", 22, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Location  = new Point(40, 20);
            lblWelcome.Size      = new Size(700, 44);

            lblSubtitle.AutoSize  = false;
            lblSubtitle.Text      = "Choose a game and start training your brain";
            lblSubtitle.Font      = new Font("Segoe UI", 11);
            lblSubtitle.ForeColor = Color.FromArgb(200, 200, 255);
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Location  = new Point(40, 66);
            lblSubtitle.Size      = new Size(600, 28);

            // ── Game buttons (2 columns, 3 rows) ──────────────────────
            SetupGameBtn(btnGuess,       "🎯  Number Guess",   "Guess the secret number",
                Color.FromArgb(108, 73, 255), Color.FromArgb(80, 50, 200),
                new Point(40, 135), new EventHandler(btnGuess_Click));

            SetupGameBtn(btnMath,        "➗  Math Quiz",      "Solve expressions fast",
                Color.FromArgb(0, 180, 230), Color.FromArgb(0, 130, 180),
                new Point(530, 135), new EventHandler(btnMath_Click));

            SetupGameBtn(btnMemory,      "🧠  Memory Game",    "Remember the number",
                Color.FromArgb(46, 200, 100), Color.FromArgb(30, 150, 70),
                new Point(40, 275), new EventHandler(btnMemory_Click));

            SetupGameBtn(btnQuickPick,   "⚡  Quick Pick",     "4-choice speed quiz",
                Color.FromArgb(255, 140, 50), Color.FromArgb(200, 100, 20),
                new Point(530, 275), new EventHandler(btnQuickPick_Click));

            SetupGameBtn(btnLeaderboard, "🏆  Leaderboard",   "See the top players",
                Color.FromArgb(255, 215, 0), Color.FromArgb(200, 165, 0),
                new Point(40, 415), new EventHandler(btnLeaderboard_Click));

            SetupGameBtn(btnCalc,        "🔢  Calculator",     "Quick calculations",
                Color.FromArgb(160, 100, 255), Color.FromArgb(120, 70, 200),
                new Point(530, 415), new EventHandler(btnCalc_Click));

            // ── Logout ────────────────────────────────────────────────
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize  = 1;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 120);
            btnLogout.Text      = "Logout";
            btnLogout.Font      = new Font("Segoe UI", 11, FontStyle.Bold);
            btnLogout.BackColor = Color.FromArgb(20, 20, 45);
            btnLogout.ForeColor = Color.FromArgb(150, 150, 190);
            btnLogout.Location  = new Point(400, 556);
            btnLogout.Size      = new Size(200, 46);
            btnLogout.Cursor    = Cursors.Hand;
            btnLogout.Click    += new EventHandler(btnLogout_Click);

            // ── Form ──────────────────────────────────────────────────
            ClientSize      = new Size(1000, 620);
            StartPosition   = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox     = false;
            Text            = "BrainRush — Menu";
            BackColor       = Color.FromArgb(12, 12, 30);
            Controls.AddRange(new Control[]
            {
                pnlHeader,
                btnGuess, btnMath, btnMemory, btnQuickPick,
                btnLeaderboard, btnCalc, btnLogout
            });

            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void SetupGameBtn(Button btn, string text, string subtext,
            Color bg, Color bgDark, Point loc, EventHandler handler)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Text      = text + "\n" + subtext;
            btn.Font      = new Font("Segoe UI", 13, FontStyle.Bold);
            btn.BackColor = bg;
            btn.ForeColor = Color.White;
            btn.Location  = loc;
            btn.Size      = new Size(430, 120);
            btn.Cursor    = Cursors.Hand;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Click    += handler;
            btn.MouseEnter += (s, e) => btn.BackColor = bgDark;
            btn.MouseLeave += (s, e) => btn.BackColor = bg;
        }

        private Panel  pnlHeader;
        private Label  lblWelcome, lblSubtitle;
        private Button btnGuess, btnMath, btnMemory, btnQuickPick;
        private Button btnLeaderboard, btnCalc, btnLogout;
    }
}
