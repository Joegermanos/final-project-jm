namespace RH
{
    partial class FormCalculator
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
            pnlCalc = new Panel();
            pnlDisplay = new Panel();
            lblOp = new Label();
            txtDisplay = new Label();
            btnClear = new Button();
            btnDel = new Button();
            btnDiv = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMul = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSub = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnEquals = new Button();
            btnBack = new Button();
            pnlHeader.SuspendLayout();
            pnlCalc.SuspendLayout();
            pnlDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(160, 100, 255);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(30, 12);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(500, 46);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "🔢 Calculator";
            // 
            // pnlCalc
            // 
            pnlCalc.BackColor = Color.FromArgb(20, 20, 48);
            pnlCalc.Controls.Add(pnlDisplay);
            pnlCalc.Controls.Add(btnClear);
            pnlCalc.Controls.Add(btnDel);
            pnlCalc.Controls.Add(btnDiv);
            pnlCalc.Controls.Add(btn7);
            pnlCalc.Controls.Add(btn8);
            pnlCalc.Controls.Add(btn9);
            pnlCalc.Controls.Add(btnMul);
            pnlCalc.Controls.Add(btn4);
            pnlCalc.Controls.Add(btn5);
            pnlCalc.Controls.Add(btn6);
            pnlCalc.Controls.Add(btnSub);
            pnlCalc.Controls.Add(btn1);
            pnlCalc.Controls.Add(btn2);
            pnlCalc.Controls.Add(btn3);
            pnlCalc.Controls.Add(btnAdd);
            pnlCalc.Controls.Add(btn0);
            pnlCalc.Controls.Add(btnDot);
            pnlCalc.Controls.Add(btnEquals);
            pnlCalc.Location = new Point(290, 90);
            pnlCalc.Name = "pnlCalc";
            pnlCalc.Size = new Size(420, 480);
            pnlCalc.TabIndex = 1;
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = Color.FromArgb(10, 10, 28);
            pnlDisplay.Controls.Add(lblOp);
            pnlDisplay.Controls.Add(txtDisplay);
            pnlDisplay.Location = new Point(10, 10);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(400, 90);
            pnlDisplay.TabIndex = 0;
            // 
            // lblOp
            // 
            lblOp.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOp.ForeColor = Color.FromArgb(108, 73, 255);
            lblOp.Location = new Point(10, 8);
            lblOp.Name = "lblOp";
            lblOp.Size = new Size(40, 30);
            lblOp.TabIndex = 0;
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            txtDisplay.ForeColor = Color.FromArgb(235, 235, 255);
            txtDisplay.Location = new Point(3, 8);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(387, 74);
            txtDisplay.TabIndex = 1;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(0, 0);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(0, 0);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 2;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(0, 0);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 23);
            btnDiv.TabIndex = 3;
            // 
            // btn7
            // 
            btn7.Location = new Point(0, 0);
            btn7.Name = "btn7";
            btn7.Size = new Size(75, 23);
            btn7.TabIndex = 4;
            // 
            // btn8
            // 
            btn8.Location = new Point(0, 0);
            btn8.Name = "btn8";
            btn8.Size = new Size(75, 23);
            btn8.TabIndex = 5;
            // 
            // btn9
            // 
            btn9.Location = new Point(0, 0);
            btn9.Name = "btn9";
            btn9.Size = new Size(75, 23);
            btn9.TabIndex = 6;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(0, 0);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(75, 23);
            btnMul.TabIndex = 7;
            // 
            // btn4
            // 
            btn4.Location = new Point(0, 0);
            btn4.Name = "btn4";
            btn4.Size = new Size(75, 23);
            btn4.TabIndex = 8;
            // 
            // btn5
            // 
            btn5.Location = new Point(0, 0);
            btn5.Name = "btn5";
            btn5.Size = new Size(75, 23);
            btn5.TabIndex = 9;
            // 
            // btn6
            // 
            btn6.Location = new Point(0, 0);
            btn6.Name = "btn6";
            btn6.Size = new Size(75, 23);
            btn6.TabIndex = 10;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(0, 0);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 11;
            // 
            // btn1
            // 
            btn1.Location = new Point(0, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 12;
            // 
            // btn2
            // 
            btn2.Location = new Point(0, 0);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 13;
            // 
            // btn3
            // 
            btn3.Location = new Point(0, 0);
            btn3.Name = "btn3";
            btn3.Size = new Size(75, 23);
            btn3.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            // 
            // btn0
            // 
            btn0.Location = new Point(0, 0);
            btn0.Name = "btn0";
            btn0.Size = new Size(90, 70);
            btn0.TabIndex = 16;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(0, 0);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(75, 23);
            btnDot.TabIndex = 17;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(0, 0);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(75, 23);
            btnEquals.TabIndex = 18;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(20, 20, 48);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(180, 180, 230);
            btnBack.Location = new Point(375, 590);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(250, 46);
            btnBack.TabIndex = 2;
            btnBack.Text = "← Back to Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormCalculator
            // 
            BackColor = Color.FromArgb(12, 12, 30);
            ClientSize = new Size(1000, 654);
            Controls.Add(pnlHeader);
            Controls.Add(pnlCalc);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BrainRush — Calculator";
            Load += FormCalculator_Load;
            pnlHeader.ResumeLayout(false);
            pnlCalc.ResumeLayout(false);
            pnlDisplay.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void SetupBtn(Button btn, string text, Color bg, Point loc, EventHandler handler, bool isOp = false)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Text = text;
            btn.Font = new Font("Segoe UI", isOp ? 20 : 18, FontStyle.Bold);
            btn.BackColor = bg;
            btn.ForeColor = isOp ? Color.FromArgb(200, 180, 255) : Color.FromArgb(235, 235, 255);
            btn.Location = loc;
            btn.Size = new Size(90, 70);
            btn.Cursor = Cursors.Hand;
            btn.Click += handler;
        }

        private Panel pnlHeader, pnlCalc, pnlDisplay;
        private Label lblHeader, lblOp, txtDisplay;
        private Button btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9;
        private Button btnAdd, btnSub, btnMul, btnDiv;
        private Button btnDot, btnEquals, btnClear, btnDel, btnBack;
    }
}