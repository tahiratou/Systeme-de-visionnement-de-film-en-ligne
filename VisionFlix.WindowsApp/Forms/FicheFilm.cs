using VisionFlix.Core.Entities;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class FicheFilm : UserControl
    {
        private Film _film = null!;

        // Événement déclenché quand on clique sur la fiche
        public event EventHandler<Film>? FilmClicked;

        public FicheFilm()
        {
            InitializeComponent();

            // Rendre toute la carte cliquable
            this.panelCard.Click += OnCardClick;
            this.picThumbnail.Click += OnCardClick;
            this.panelInfo.Click += OnCardClick;

            // Effet hover
            this.panelCard.MouseEnter += OnMouseEnterCard;
            this.panelCard.MouseLeave += OnMouseLeaveCard;
        }

        public void SetFilmData(Film film)
        {
            _film = film;

            lblTitle.Text = film.Titre;
            lblDirector.Text = film.Realisateur;
            lblYear.Text = film.Annee.ToString();
            lblRating.Text = GetStarRating(film.Note);
            lblDuration.Text = $"{film.Duree} min";
            panelCard.BackColor = Color.FromArgb(25, 25, 25);

            ChargerImageFilm();
        }

        private void ChargerImageFilm()
        {
            // ✅ CORRECTION: Utiliser ImageUrl au lieu de Vignette
            if (string.IsNullOrEmpty(_film.ImageUrl))
            {
                picThumbnail.Image = null;
                picThumbnail.BackColor = Color.FromArgb(60, 60, 60);
                return;
            }

            try
            {
                
                string imagePath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName,
                    "Images",
                    _film.ImageUrl
            );

                
                if (File.Exists(imagePath))
                {
                    // ✅ Utiliser FileStream pour éviter le verrouillage du fichier
                    using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                    picThumbnail.Image = Image.FromStream(stream);
                    picThumbnail.SizeMode = PictureBoxSizeMode.Zoom; // ✅ Ajout pour meilleur affichage
                }
                else
                {
                    // Image introuvable
                    picThumbnail.Image = null;
                    picThumbnail.BackColor = Color.FromArgb(60, 60, 60);

                    // Debug: afficher le chemin dans la console
                    System.Diagnostics.Debug.WriteLine($"⚠️ Image introuvable: {imagePath}");
                }
            }
            catch (Exception ex)
            {
                // Erreur lors du chargement
                picThumbnail.Image = null;
                picThumbnail.BackColor = Color.FromArgb(60, 60, 60);

                // Debug: afficher l'erreur dans la console
                System.Diagnostics.Debug.WriteLine($"❌ Erreur chargement image: {ex.Message}");
            }
        }

        private void OnCardClick(object? sender, EventArgs e)
        {
            // Déclencher l'événement avec les données du film
            FilmClicked?.Invoke(this, _film);
        }

        private void OnMouseEnterCard(object? sender, EventArgs e)
        {
            panelCard.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void OnMouseLeaveCard(object? sender, EventArgs e)
        {
            panelCard.BackColor = Color.FromArgb(25, 25, 25);
        }

        private string GetStarRating(double rating)
        {
            int fullStars = (int)rating;
            bool halfStar = (rating % 1) >= 0.5; 
            int emptyStars = 5 - fullStars - (halfStar ? 1 : 0);

            return new string('★', fullStars) +
                   (halfStar ? "⯨" : "") +
                   new string('☆', emptyStars);
        }
    }
}