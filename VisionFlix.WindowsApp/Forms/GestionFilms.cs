using VisionFlix.Core.Interfaces;
using VisionFlix.Core.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class GestionFilms : UserControl
    {
        private readonly IFilmService _filmService;
        private readonly IServiceProvider _serviceProvider;

        // CONSTRUCTEUR AVEC INJECTION DE DÉPENDANCES
        public GestionFilms(IFilmService filmService, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _filmService = filmService;
            _serviceProvider = serviceProvider;

            LoadFilmsGrid();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            btnAjouterFilm.Click += BtnAjouterFilm_Click;
            btnModifierFilm.Click += BtnModifierFilm_Click;
            btnSupprimerFilm.Click += BtnSupprimerFilm_Click;
            btnRafraichirFilms.Click += BtnRafraichirFilms_Click;
        }

        private async void LoadFilmsGrid()
        {
            try
            {
                dgvFilms.SuspendLayout();
                dgvFilms.DataSource = null;

                var films = await _filmService.GetAllFilmsAsync();
                dgvFilms.DataSource = films.ToList();

                // Masquer certaines colonnes si nécessaire
                //if (dgvFilms.Columns["Achats"] != null)
                //    dgvFilms.Columns["Achats"].Visible = false;
                //if (dgvFilms.Columns["Visionnements"] != null)
                //    dgvFilms.Columns["Visionnements"].Visible = false;
                //if (dgvFilms.Columns["Notations"] != null)
                //    dgvFilms.Columns["Notations"].Visible = false;

                dgvFilms.ResumeLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnAjouterFilm_Click(object? sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FormulaireFilm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var film = form.GetFilm();
                    await _filmService.AddFilmAsync(film);
                    LoadFilmsGrid();
                    MessageBox.Show("Film ajouté avec succès!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnModifierFilm_Click(object? sender, EventArgs e)
        {
            if (dgvFilms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un film à modifier.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filmSelectionne = (Film)dgvFilms.SelectedRows[0].DataBoundItem;
            var form = _serviceProvider.GetRequiredService<FormulaireFilm>();
            form.SetFilm(filmSelectionne); // Méthode pour pré-remplir le formulaire

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filmModifie = form.GetFilm();
                    filmModifie.Id = filmSelectionne.Id;

                    await _filmService.UpdateFilmAsync(filmModifie);
                    LoadFilmsGrid();
                    MessageBox.Show("Film modifié avec succès!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void BtnSupprimerFilm_Click(object? sender, EventArgs e)
        {
            if (dgvFilms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un film à supprimer.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var filmSelectionne = (Film)dgvFilms.SelectedRows[0].DataBoundItem;

            var result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer le film '{filmSelectionne.Titre}'?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    await _filmService.DeleteFilmAsync(filmSelectionne.Id);
                    LoadFilmsGrid();
                    MessageBox.Show("Film supprimé avec succès!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnRafraichirFilms_Click(object? sender, EventArgs e)
        {
            LoadFilmsGrid();
            MessageBox.Show("Liste rafraîchie!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

/*
 * INSTRUCTIONS:
 * 1. GARDEZ votre GestionFilms.Designer.cs TEL QUEL
 * 2. Remplacez le contenu de GestionFilms.cs
 * 3. Créez FormulaireFilm.cs pour l'ajout/modification (code fourni ci-après)
 */
