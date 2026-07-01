using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace djoe
{
    public partial class FormCalculator : Form
    {
        private readonly string _username;
        private double _firstNumber = 0;
        private string _operator = string.Empty;
        private bool _newEntry = true;

        public FormCalculator(string username)
        {
            InitializeComponent();
            _username = username;
            SetupCustomDrawing();
        }

        private void SetupCustomDrawing()
        {
            pnlHeader.Paint += (s, e) =>
            {
                using var grad = new LinearGradientBrush(
                    new Point(0, 0), new Point(1000, 0),
                    Color.FromArgb(130, 70, 230), Color.FromArgb(12, 12, 30));
                e.Graphics.FillRectangle(grad, 0, 0, 1000, 70);
            };

            pnlCalc.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(80, 60, 180), 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlCalc.Width - 1, pnlCalc.Height - 1);
            };

            pnlDisplay.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(60, 60, 120), 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlDisplay.Width - 1, pnlDisplay.Height - 1);
            };
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            string d = ((Button)sender).Text;
            if (_newEntry)
            {
                txtDisplay.Text = d;
                _newEntry = false;
            }
            else
            {
                if (txtDisplay.Text == "0") txtDisplay.Text = d;
                else txtDisplay.Text += d;
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (_newEntry)
            {
                txtDisplay.Text = "0.";
                _newEntry = false;
            }
            else if (!txtDisplay.Text.Contains('.'))
            {
                txtDisplay.Text += ".";
            }
        }

        private void Op_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double val))
            {
                _firstNumber = val;
                _operator = ((Button)sender).Text;
                lblOp.Text = _operator;
                _newEntry = true;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_operator)) return;

            if (double.TryParse(txtDisplay.Text, out double second))
            {
                double result = _operator switch
                {
                    "+" => _firstNumber + second,
                    "-" => _firstNumber - second,
                    "×" => _firstNumber * second,
                    "÷" => second == 0 ? double.NaN : _firstNumber / second,
                    _ => second
                };

                txtDisplay.Text = double.IsNaN(result) ? "Error" : result.ToString("G10");
                lblOp.Text = string.Empty;
                _operator = string.Empty;
                _newEntry = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            _firstNumber = 0;
            _operator = string.Empty;
            lblOp.Text = string.Empty;
            _newEntry = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text[..^1];
            else
                txtDisplay.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Assuming Form2 is your Main Menu
            new Form2(_username).Show();
            this.Close();
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
