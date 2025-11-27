using VisionFlix.Domain.Entities;

namespace VisionFlix.Presentation.Forms
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

            ChargerImageFilm();
        }

        private void ChargerImageFilm()
        {
            if (string.IsNullOrEmpty(_film.Vignette))
            {
                picThumbnail.Image = null;
                picThumbnail.BackColor = Color.FromArgb(60, 60, 60);
                return;
            }

            try
            {
                // Construire le chemin vers le dossier Images
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", _film.Vignette);

                if (File.Exists(imagePath))
                {
                    using var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                    picThumbnail.Image = Image.FromStream(stream);
                }
                else
                {
                    picThumbnail.Image = null;
                    picThumbnail.BackColor = Color.FromArgb(60, 60, 60);
                }
            }
            catch
            {
                picThumbnail.Image = null;
                picThumbnail.BackColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void OnCardClick(object? sender, EventArgs e)
        {
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
            bool halfStar = (int)(rating % 1) >= 0.5m;
            int emptyStars = 5 - fullStars - (halfStar ? 1 : 0);

            return new string('★', fullStars) +
                   (halfStar ? "⯨" : "") +
                   new string('☆', emptyStars);
        }
    }
}