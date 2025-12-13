using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class DetailsFilm : Form
    {
        private readonly IFilmService _filmService;
        private readonly IAuthentificationService _authService;
        private Film? _film;

        public DetailsFilm(IFilmService filmService, IAuthentificationService authService)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Détails du Film";
            _filmService = filmService;
            _authService = authService;
        }

        public void SetFilm(Film film)
        {
            _film = film;
            ChargerDetailsFilm();
        }

 
        private void ChargerDetailsFilm()
        {
            if (_film == null) return;

            // ✅ Affichage des informations complètes
            lblTitre.Text = _film.Titre;
            lblAnnee.Text = $"Année: {_film.Annee}";
            lblRealisateur.Text = $"Réalisateur: {_film.Realisateur}";
            lblGenre.Text = $"Genre: {_film.Genre}";
            lblDuree.Text = $"Durée: {_film.Duree} min";
            lblPrix.Text = $"Prix: {_film.Prix:C}";

            // ✅ LANGUE DU FILM
            lblLangue.Text = $"Langue: {_film.Langue}";

            // ✅ STATUT DE DISPONIBILITÉ
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
                // Construire le chemin vers le dossier Images
                string imagePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName,
                    "Images", _film.ImageUrl);

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

        private void ConfigurerBoutonsSelonDisponibilite()
        {
            if (_film == null) return;

            // Si le film n'est pas disponible, désactiver les boutons d'action
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
            bool demiEtoile = utiliserDemiEtoile && (int)(rating - etoilesCompletes) >= 0.5m;

            for (int i = 0; i < etoilesCompletes; i++)
            {
                resultat += "★";
            }

            if (demiEtoile && etoilesCompletes < 5)
            {
                resultat += "⯨";
            }

            int etoilesVides = 5 - etoilesCompletes - (demiEtoile ? 1 : 0);
            for (int i = 0; i < etoilesVides; i++)
            {
                resultat += "☆";
            }
            return resultat;
        }

        private void BtnFermer_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void DetailsFilm_Load(object sender, EventArgs e)
        {

        }

        private void lblMessageConnexion_Click(object sender, EventArgs e)
        {

        }
    }
}