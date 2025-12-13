using VisionFlix.Core.Entities;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class DetailsFilmPublic : Form
    {
        private Film? _film;

        public event EventHandler? ConnexionDemandee;

        public DetailsFilmPublic()
        {
            InitializeComponent();
            this.Text = "VisionFlix - Détails du Film";
        }

        public void SetFilm(Film film)
        {
            _film = film;
            ChargerDetailsFilm();
        }

        private void ChargerDetailsFilm()
        {
            if (_film == null) return;

            lblTitre.Text = _film.Titre;
            lblAnnee.Text = $"Année: {_film.Annee}";
            lblRealisateur.Text = $"Réalisateur: {_film.Realisateur}";
            lblGenre.Text = $"Genre: {_film.Genre}";
            lblDuree.Text = $"Durée: {_film.Duree} min";
            lblPrix.Text = $"Prix: {_film.Prix:C}";

            lblLangue.Text = $"Langue: {_film.Langue}";

            if (_film.EstDisponible)
            {
                lblStatut.Text = "✅ Disponible";
                lblStatut.ForeColor = Color.FromArgb(40, 167, 69); // Vert
            }
            else
            {
                lblStatut.Text = "❌ Non disponible";
                lblStatut.ForeColor = Color.FromArgb(220, 53, 69); // Rouge
            }

            txtDescription.Text = _film.Synopsis;
            txtDescription.ReadOnly = true;

            AfficherCoteFilm();
            ChargerImageFilm();
            ConfigurerBoutonsSelonDisponibilite();
        }


        private void ConfigurerBoutonsSelonDisponibilite()
        {
            if (_film == null) return;

            if (!_film.EstDisponible)
            {
                btnVisionner.Enabled = false;
                btnAcheter.Enabled = false;
                btnVisionner.BackColor = Color.FromArgb(60, 60, 60);
                btnAcheter.BackColor = Color.FromArgb(60, 60, 60);

                lblMessageConnexion.Text = "⚠️ Ce film n'est actuellement pas disponible";
                lblMessageConnexion.ForeColor = Color.FromArgb(220, 53, 69);
            }
            else
            {
                btnVisionner.Enabled = true;
                btnAcheter.Enabled = true;
                lblMessageConnexion.Text = "🔒 Connectez-vous pour visualiser, acheter ou noter ce film";
                lblMessageConnexion.ForeColor = Color.FromArgb(255, 193, 7);
            }
        }

        private void ChargerImageFilm()
        {
            if (_film == null || string.IsNullOrEmpty(_film.ImageUrl))
            {
                pictureBoxFilm.Image = null;
                pictureBoxFilm.BackColor = Color.FromArgb(60, 60, 60);
                return;
            }

            try
            {
                string imagePath = Path.Combine(
                    Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName,
                    "Images",
                    _film.ImageUrl
                );

                if (File.Exists(imagePath))
                {
                    using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                    pictureBoxFilm.Image = Image.FromStream(stream);
                }
                else
                {
                    pictureBoxFilm.Image = null;
                    pictureBoxFilm.BackColor = Color.FromArgb(60, 60, 60);
                }
            }
            catch
            {
                pictureBoxFilm.Image = null;
                pictureBoxFilm.BackColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void AfficherCoteFilm()
        {
            if (_film == null) return;

            string etoiles = GenererEtoiles(_film.Note, true);
            lblEtoilesCote.Text = etoiles;
            lblCoteValeur.Text = $"{_film.Note:0.0}/5";
        }

        private string GenererEtoiles(double rating, bool utiliserDemiEtoile = false)
        {
            string resultat = "";
            int etoilesCompletes = (int)Math.Floor(rating);
            bool demiEtoile = utiliserDemiEtoile && (rating - etoilesCompletes) >= 0.5;

            for (int i = 0; i < etoilesCompletes; i++)
                resultat += "★";

            if (demiEtoile && etoilesCompletes < 5)
                resultat += "⯨";

            int etoilesVides = 5 - etoilesCompletes - (demiEtoile ? 1 : 0);
            for (int i = 0; i < etoilesVides; i++)
                resultat += "☆";

            return resultat;
        }

        /// <summary>
        /// Bouton pour visionner (affiche dialogue avec bouton connexion)
        /// </summary>
        private void BtnVisionner_Click(object? sender, EventArgs e)
        {
            if (_film == null || !_film.EstDisponible) return;

            AfficherDialogueConnexion(
                "Visualiser",
                $"Pour visualiser '{_film.Titre}', vous devez d'abord vous connecter à votre compte VisionFlix.",
                "💡 Créez un compte gratuitement si vous n'en avez pas encore !"
            );
        }

        /// <summary>
        /// Bouton pour acheter (affiche dialogue avec bouton connexion)
        /// </summary>
        private void BtnAcheter_Click(object? sender, EventArgs e)
        {
            if (_film == null || !_film.EstDisponible) return;

            AfficherDialogueConnexion(
                "Acheter",
                $"Pour acheter '{_film.Titre}' ({_film.Prix:C}), vous devez d'abord vous connecter à votre compte VisionFlix.",
                "💡 Une fois connecté, vous pourrez acheter ce film et le regarder à volonté !"
            );
        }

        /// <summary>
        /// Gère le clic sur les étoiles de notation
        /// </summary>
        private void LblNote_Click(object? sender, EventArgs e)
        {
            AfficherDialogueConnexion(
                "Noter",
                $"Pour noter '{_film?.Titre}', vous devez d'abord vous connecter à votre compte VisionFlix.",
                "⭐ Partagez votre avis avec la communauté VisionFlix !"
            );
        }

        /// <summary>
        /// Gère le bouton sauvegarder note
        /// </summary>
        private void BtnSauvegarderNote_Click(object? sender, EventArgs e)
        {
            AfficherDialogueConnexion(
                "Noter",
                $"Pour noter '{_film?.Titre}', vous devez d'abord vous connecter à votre compte VisionFlix.",
                "⭐ Partagez votre avis avec la communauté VisionFlix !"
            );
        }

        /// <summary>
        /// Affiche un dialogue de connexion personnalisé
        /// </summary>
        private void AfficherDialogueConnexion(string action, string message, string info)
        {
            var dialogueConnexion = new Form
            {
                Text = "Connexion requise",
                Size = new Size(450, 220),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.FromArgb(30, 30, 30)
            };

            var lblMessage = new Label
            {
                Text = message,
                Location = new Point(20, 20),
                Size = new Size(390, 60),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F)
            };

            var lblInfo = new Label
            {
                Text = info,
                Location = new Point(20, 90),
                Size = new Size(390, 30),
                ForeColor = action == "Acheter" ? Color.FromArgb(40, 167, 69) : Color.FromArgb(255, 193, 7),
                Font = new Font("Segoe UI", 9F, FontStyle.Italic)
            };

            var btnSeConnecter = new Button
            {
                Text = "🔐 Se connecter",
                Location = new Point(50, 130),
                Size = new Size(150, 40),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnSeConnecter.FlatAppearance.BorderSize = 0;
            btnSeConnecter.Click += (s, args) =>
            {
                dialogueConnexion.DialogResult = DialogResult.Yes;
                dialogueConnexion.Close();
            };

            var btnAnnuler = new Button
            {
                Text = "Annuler",
                Location = new Point(230, 130),
                Size = new Size(150, 40),
                BackColor = Color.FromArgb(60, 60, 60),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F),
                Cursor = Cursors.Hand
            };
            btnAnnuler.FlatAppearance.BorderSize = 0;
            btnAnnuler.Click += (s, args) =>
            {
                dialogueConnexion.DialogResult = DialogResult.No;
                dialogueConnexion.Close();
            };

            dialogueConnexion.Controls.Add(lblMessage);
            dialogueConnexion.Controls.Add(lblInfo);
            dialogueConnexion.Controls.Add(btnSeConnecter);
            dialogueConnexion.Controls.Add(btnAnnuler);

            if (dialogueConnexion.ShowDialog() == DialogResult.Yes)
            {
                ConnexionDemandee?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }

        private void BtnFermer_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMessageConnexion_Click(object sender, EventArgs e)
        {

        }
    }
}