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
            
            // GARDEZ votre code Designer.cs existant
            // Assurez-vous que cmbGenre.SelectedIndex = 0; est appelé
        }

        // Méthode pour pré-remplir le formulaire en mode modification
        public void SetFilm(Film film)
        {
            _filmToEdit = film;
            this.Text = "VisionFlix - Modifier un film";

            // Pré-remplir les contrôles (ajustez selon vos noms de contrôles)
            txtTitle.Text = film.Titre;
            txtDirector.Text = film.Realisateur;
            numYear.Value = film.Annee;
            numRating.Value = (decimal)film.Note;
            numDuration.Value = film.Duree;
            cmbGenre.Text = film.Genre;
            txtThumbnail.Text = film.Vignette;
            txtSynopsis.Text = film.Synopsis;
            numPrice.Value = film.Prix;
        }

        // Méthode pour récupérer le film depuis le formulaire
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
                Vignette = txtThumbnail.Text.Trim(),
                Synopsis = txtSynopsis.Text.Trim(),
                Prix = numPrice.Value,
                EstDisponible = true,
                DateAjout = _filmToEdit?.DateAjout ?? DateTime.Now
            };
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Validation
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

/*
 * INSTRUCTIONS:
 * 1. GARDEZ votre FormulaireFilm.Designer.cs existant TEL QUEL
 * 2. Remplacez le contenu de FormulaireFilm.cs par ce code
 * 3. Vérifiez que vos contrôles ont bien ces noms:
 *    - txtTitle, txtDirector, numYear, numRating, etc.
 * 4. Ajustez les noms si différents dans votre Designer
 */
