using System.Drawing;

namespace RH
{
    internal static class Theme
    {
        public static readonly Color BgDark   = Color.FromArgb(12, 12, 30); // Dark background for main form
        public static readonly Color BgCard   = Color.FromArgb(20, 20, 48); // Slightly lighter background for cards/panels
        public static readonly Color BgInput  = Color.FromArgb(28, 28, 58); // Background for input boxes
        public static readonly Color Purple   = Color.FromArgb(108, 73, 255); 
        public static readonly Color PurpleDim = Color.FromArgb(75, 50, 180);
        public static readonly Color Cyan     = Color.FromArgb(0, 212, 255);
        public static readonly Color Green    = Color.FromArgb(46, 232, 122);
        public static readonly Color Red      = Color.FromArgb(255, 71, 87);
        public static readonly Color Orange   = Color.FromArgb(255, 140, 50);
        public static readonly Color Gold     = Color.FromArgb(255, 215, 0);
        public static readonly Color Silver   = Color.FromArgb(192, 192, 210);
        public static readonly Color Bronze   = Color.FromArgb(205, 127, 50);
        public static readonly Color White    = Color.FromArgb(235, 235, 255);
        public static readonly Color Gray     = Color.FromArgb(120, 120, 155);
        public static readonly Color GrayDim  = Color.FromArgb(60, 60, 90);

        public static Button StyledBtn(string text, Color bg, Color fg, int fontSize = 13)
        {
            var b = new Button
            {
                Text = text,
                FlatStyle = FlatStyle.Flat,
                BackColor = bg,
                ForeColor = fg,
                Font = new Font("Segoe UI", fontSize, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            return b;
        }

        public static Panel InputBox(TextBox txt)
        {
            var p = new Panel
            {
                BackColor = Color.FromArgb(28, 28, 58),
                Height = 46
            };
            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = Color.FromArgb(28, 28, 58);
            txt.ForeColor = Color.FromArgb(235, 235, 255);
            txt.Font = new Font("Segoe UI", 13);
            txt.Location = new Point(12, 10);
            txt.Width = p.Width - 24;
            txt.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            p.Controls.Add(txt);
            p.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(80, 80, 140), 1);
                e.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
            };
            return p;
        }
    }
}
