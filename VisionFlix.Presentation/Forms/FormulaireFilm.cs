using VisionFlix.Domain.Entities;

namespace VisionFlix.Presentation.Forms
{
    public partial class FormulaireFilm : Form
    {
        private Film? _filmToEdit;

        public FormulaireFilm()
        {
            InitializeComponent();
            this.Text = "VisionFlix - Ajouter un film";
            
        }

        public void SetFilm(Film film)
        {
            _filmToEdit = film;
            this.Text = "VisionFlix - Modifier un film";

            txtTitle.Text = film.Titre;
            txtDirector.Text = film.Realisateur;
            numYear.Value = film.Annee;
            numRating.Value = (decimal)film.Note;
            numDuration.Value = film.Duree;
            cmbGenre.Text = film.Genre;
            txtThumbnail.Text = film.ImageUrl;
            txtSynopsis.Text = film.Synopsis;
            numPrice.Value = film.Prix;
        }

        public Film GetFilm()
        {
            return new Film
            {
                Id = _filmToEdit?.Id ?? 0,
                Titre = txtTitle.Text.Trim(),
                Realisateur = txtDirector.Text.Trim(),
                Annee = (int)numYear.Value,
                Note = (double)numRating.Value,
                Duree = (int)numDuration.Value,
                Genre = cmbGenre.Text,
                ImageUrl = txtThumbnail.Text.Trim(),
                Synopsis = txtSynopsis.Text.Trim(),
                Prix = numPrice.Value,
                EstDisponible = true,
                DateAjout = _filmToEdit?.DateAjout ?? DateTime.Now
            };
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Le titre est obligatoire.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDirector.Text))
            {
                MessageBox.Show("Le réalisateur est obligatoire.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

