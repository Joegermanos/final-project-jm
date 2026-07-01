using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RH
{
    public partial class FormRandom : Form
    {
        private readonly string _username; // c'est le nom d'utilisateur du joueur pourqui on peut afficher le meilleur score et sauvegarder le score actuel
        private readonly Random _rnd = new Random(); // c'est un générateur de nombres aléatoires pour créer des questions mathématiques aléatoires

        private int _correctAnswer; // c'est la réponse correcte à la question mathématique générée aléatoirement
        private int _score = 0; // c'est le score actuel du joueur pour cette session de jeu
        private int _timeLeft = 0; // c'est le temps restant pour répondre à la question actuelles

        public FormRandom(string username)
        {
            InitializeComponent();
            _username = username;
            lblBest.Text = $"Best: {Scoreboard.GetBest(username, "MathQuiz")}";

            // Setup Custom Painting (Safe for Designer)
            SetupCustomDesign();
        }

        private void SetupCustomDesign()
        {
            pnlHeader.Paint += (s, e) =>
            {
                using var grad = new LinearGradientBrush(
                    new Point(0, 0), new Point(1000, 0),
                    Color.FromArgb(0, 150, 200), Color.FromArgb(12, 12, 30));
                e.Graphics.FillRectangle(grad, 0, 0, pnlHeader.Width, pnlHeader.Height);
            };

            pnlContent.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(0, 180, 230), 2);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlContent.Width - 1, pnlContent.Height - 1);
            };

            pnlAnswer.Paint += (s, e) =>
            {
                using var pen = new Pen(Color.FromArgb(0, 150, 200), 2);
                e.Graphics.DrawRectangle(pen, 0, 0, pnlAnswer.Width - 1, pnlAnswer.Height - 1);
            };

            txtAnswer.KeyPress += (s, e) =>
            {
                if (e.KeyChar == '\r' && btnSubmit.Enabled) btnSubmit.PerformClick(); // pour le champ de réponse, si l'utilisateur appuie sur "Entrée", cela déclenche le clic du bouton "Soumettre
            };
        } // cette méthode configure la peinture personnalisée pour les panneaux et gère l'événement de pression de touche pour le champ de réponse

        private void FormRandom_Load(object sender, EventArgs e)
        {
            SoundManager.StartBackground();
            GenerateQuestion();
        }

        private void FormRandom_FormClosed(object sender, FormClosedEventArgs e)
        {
            SoundManager.StopBackground();
            timer1.Stop();
        }

        private void GenerateQuestion()
        {
            timer1.Stop();
            int terms = _rnd.Next(3, 6);
            int[] nums = new int[terms];
            char[] ops = new char[terms - 1];

            for (int i = 0; i < terms; i++)
                nums[i] = _rnd.Next(1, 13);

            char[] choices = { '+', '-', '*', '/' };
            for (int i = 0; i < ops.Length; i++)
                ops[i] = choices[_rnd.Next(0, 4)];

            string q = nums[0].ToString();
            for (int i = 0; i < ops.Length; i++)
                q += $" {ops[i]} {nums[i + 1]}";

            lblQuestion.Text = q + " = ?";
            _correctAnswer = Calculate(nums, ops);

            txtAnswer.Text = string.Empty;
            lblFeedback.Text = string.Empty;
            btnSubmit.Enabled = true;
            btnNext.Enabled = false;
            pnlContent.BackColor = Color.FromArgb(20, 20, 48);

            _timeLeft = 100;
            lblTimer.Text = "10.0s";
            timer1.Start();
        }

        private int Calculate(int[] nums, char[] ops)
        {
            var n = new List<int>(nums);
            var o = new List<char>(ops);

            for (int i = 0; i < o.Count; i++)
            {
                if (o[i] == '*' || o[i] == '/')
                {
                    int r = o[i] == '*' ? n[i] * n[i + 1]
                                        : (n[i + 1] == 0 ? n[i] : n[i] / n[i + 1]);
                    n[i] = r;
                    n.RemoveAt(i + 1);
                    o.RemoveAt(i);
                    i--;
                }
            }

            int result = n[0];
            for (int i = 0; i < o.Count; i++)
                result = o[i] == '+' ? result + n[i + 1] : result - n[i + 1];

            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            lblTimer.Text = $"{_timeLeft / 10}.{_timeLeft % 10}s";

            if (_timeLeft <= 30) // si le temps restant est inférieur ou égal à 3 secondes
                lblTimer.ForeColor = Color.FromArgb(255, 71, 87); // change la couleur du texte du label du timer en rouge si le temps est presque écoulé
            else
                lblTimer.ForeColor = Color.FromArgb(0, 212, 255); // change la couleur du texte du label du timer en bleu si le temps est suffisant

            if (_timeLeft <= 0)
            {
                timer1.Stop();
                lblFeedback.Text = $"⏰ Time's up! Answer was {_correctAnswer}";
                lblFeedback.ForeColor = Color.FromArgb(255, 140, 50); // change la couleur du texte du label de feedback en orange si le temps est écoulé
                btnSubmit.Enabled = false;
                btnNext.Enabled = true;
                SoundManager.PlayGameOver(); // SoundManager.PlayGameOver() est appelé  de la classe SoundManager pour jouer un son indiquant que le temps est écoulé
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (!int.TryParse(txtAnswer.Text, out int guess))
            {
                lblFeedback.Text = "❗ Enter a valid number!";
                lblFeedback.ForeColor = Color.FromArgb(255, 215, 0); // change la couleur du texte du label de feedback en jaune 
                timer1.Start();
                return;
            }

            if (guess == _correctAnswer)
            {
                _score++;
                lblScore.Text = $"Score: {_score}";
                lblFeedback.Text = "✅ Correct! +1 point";
                lblFeedback.ForeColor = Color.FromArgb(46, 232, 122); // change la couleur du texte du label de feedback en vert si la réponse est correcte
                pnlContent.BackColor = Color.FromArgb(10, 45, 20); // change la couleur de fond du panneau de contenu en vert foncé si la réponse est correcte
                Scoreboard.Save(_username, "MathQuiz", _score);
                lblBest.Text = $"Best: {Scoreboard.GetBest(_username, "MathQuiz")}";
                SoundManager.PlayCorrect();
            }
            else
            {
                lblFeedback.Text = $"❌ Wrong! Answer was {_correctAnswer}";
                lblFeedback.ForeColor = Color.FromArgb(255, 71, 87); // change la couleur du texte du label de feedback en rouge si la réponse est incorrecte
                pnlContent.BackColor = Color.FromArgb(45, 10, 15); // change la couleur de fond du panneau de contenu en rouge foncé si la réponse est incorrecte

                SoundManager.PlayWrong();
            }

            btnSubmit.Enabled = false;
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e) => GenerateQuestion();

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Form2(_username).Show(); // retourne à l'écran principal du jeu -usesrname est passé pour garder la session de l'utilisateur
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FormWelcome().Show();
            this.Close();
        }
    }
}