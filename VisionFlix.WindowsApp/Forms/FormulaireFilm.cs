using VisionFlix.Core.Entities;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class FormulaireFilm : Form
    {
        private Film? _filmToEdit;

        public FormulaireFilm()
        {
            InitializeComponent();
            this.Text = "VisionFlix - Ajouter un film";

            // ✅ Initialiser la langue par défaut
            if (cmbLangue.Items.Count > 0)
            {
                cmbLangue.SelectedIndex = 0; // Français par défaut
            }
        }

        /// <summary>
        /// Configure le formulaire en mode ÉDITION
        /// </summary>
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

            // ✅ CHARGER LA LANGUE
            if (!string.IsNullOrEmpty(film.Langue))
            {
                int index = cmbLangue.Items.IndexOf(film.Langue);
                if (index >= 0)
                {
                    cmbLangue.SelectedIndex = index;
                }
                else
                {
                    cmbLangue.SelectedIndex = 0; // Français par défaut si non trouvé
                }
            }

            txtThumbnail.Text = film.ImageUrl;
            txtSynopsis.Text = film.Synopsis;
            numPrice.Value = film.Prix;

            // ✅ CHARGER LA DISPONIBILITÉ
            chkDisponible.Checked = film.EstDisponible;
        }

        /// <summary>
        /// Récupère les données du formulaire
        /// </summary>
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

                // ✅ RÉCUPÉRER LA LANGUE
                Langue = cmbLangue.SelectedItem?.ToString() ?? "Français",

                ImageUrl = txtThumbnail.Text.Trim(),
                Synopsis = txtSynopsis.Text.Trim(),
                Prix = numPrice.Value,

                // ✅ RÉCUPÉRER LA DISPONIBILITÉ
                EstDisponible = chkDisponible.Checked,

                DateAjout = _filmToEdit?.DateAjout ?? DateTime.Now
            };
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // ✅ VALIDATION TITRE
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show(
                    "Le titre est obligatoire.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            // ✅ VALIDATION RÉALISATEUR
            if (string.IsNullOrWhiteSpace(txtDirector.Text))
            {
                MessageBox.Show(
                    "Le réalisateur est obligatoire.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDirector.Focus();
                return;
            }

            // ✅ VALIDATION GENRE
            if (cmbGenre.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cmbGenre.Text))
            {
                MessageBox.Show(
                    "Veuillez sélectionner un genre.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbGenre.Focus();
                return;
            }

            // ✅ VALIDATION LANGUE
            if (cmbLangue.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Veuillez sélectionner une langue.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbLangue.Focus();
                return;
            }

            // ✅ VALIDATION PRIX
            if (numPrice.Value <= 0)
            {
                MessageBox.Show(
                    "Le prix doit être supérieur à 0.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                numPrice.Focus();
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