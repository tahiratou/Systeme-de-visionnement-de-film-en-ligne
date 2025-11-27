using VisionFlix.Application.Interfaces;
using VisionFlix.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.Presentation.Forms
{
    public partial class Accueil : Form
    {
        private readonly IFilmService _filmService;
        private readonly IAuthentificationService _authService;
        private readonly IServiceProvider _serviceProvider;

        // CONSTRUCTEUR AVEC INJECTION DE DÉPENDANCES
        public Accueil(
            IFilmService filmService,
            IAuthentificationService authService,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Accueil";

            _filmService = filmService;
            _authService = authService;
            _serviceProvider = serviceProvider;

            InitializeData();
            LoadFilms();
            SetupEventHandlers();
        }

        private void InitializeData()
        {
            // Configuration initiale des combos (gardez votre code)
            cmbGenre.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            cmbRating.SelectedIndex = 0;
        }

        private void SetupEventHandlers()
        {
            // Gardez vos event handlers existants
            btnSearch.Click += BtnSearch_Click;
            txtSearch.KeyPress += TxtSearch_KeyPress;
            btnApplyFilters.Click += BtnApplyFilters_Click;
            btnResetFilters.Click += BtnResetFilters_Click;
            btnProfil.Click += BtnProfil_Click;
        }

        private async void LoadFilms()
        {
            try
            {
                var films = await _filmService.GetAllFilmsAsync();
                AfficherFilms(films);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des films : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ApplyFilters()
        {
            try
            {
                string searchText = txtSearch.Text;
                string selectedGenre = cmbGenre.SelectedItem?.ToString() ?? "Tous";
                string yearFilter = cmbYear.SelectedItem?.ToString() ?? "Toutes";
                double minRating = GetMinRatingFromSelection(cmbRating.SelectedIndex);

                // Convertir le filtre année
                int? annee = null;
                if (int.TryParse(yearFilter, out int year))
                {
                    annee = year;
                }

                // Appeler le service
                var films = await _filmService.SearchFilmsAsync(
                    titre: string.IsNullOrWhiteSpace(searchText) ? null : searchText,
                    genre: selectedGenre == "Tous" ? null : selectedGenre,
                    annee: annee,
                    noteMinimum: minRating > 0 ? minRating : null
                );

                AfficherFilms(films);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la recherche : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfficherFilms(IEnumerable<Film> films)
        {
            flowLayoutPanelMovies.SuspendLayout();
            flowLayoutPanelMovies.Controls.Clear();

            foreach (var film in films)
            {
                FicheFilm card = new();
                card.SetFilmData(film);
                card.Margin = new Padding(10);
                card.FilmClicked += OnFilmCardClicked;
                flowLayoutPanelMovies.Controls.Add(card);
            }

            flowLayoutPanelMovies.ResumeLayout();
            lblStatus.Text = $"{films.Count()} films dans la collection";
        }

        private void OnFilmCardClicked(object? sender, Film film)
        {
            var detailsForm = _serviceProvider.GetRequiredService<DetailsFilm>();
            
            // Passer le film au formulaire DetailsFilm
            detailsForm.SetFilm(film);
            detailsForm.ShowDialog();

            // Rafraîchir si nécessaire
            LoadFilms();
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void TxtSearch_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ApplyFilters();
                e.Handled = true;
            }
        }

        private void BtnApplyFilters_Click(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void BtnResetFilters_Click(object? sender, EventArgs e)
        {
            cmbGenre.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            cmbRating.SelectedIndex = 0;
            txtSearch.Text = "";
            ApplyFilters();
        }

        private void BtnProfil_Click(object? sender, EventArgs e)
        {
            if (_authService.CurrentUser == null)
            {
                MessageBox.Show("Veuillez vous connecter.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var profilForm = _serviceProvider.GetRequiredService<ProfilUtilisateur>();
            profilForm.ShowDialog();
        }

        private static double GetMinRatingFromSelection(int index)
        {
            return index switch
            {
                1 => 5.0,
                2 => 4.0,
                3 => 3.0,
                4 => 2.0,
                _ => 0.0,
            };
        }
    }
}

/*
 * INSTRUCTIONS:
 * 1. GARDEZ votre Accueil.Designer.cs TEL QUEL
 * 2. Remplacez le contenu de Accueil.cs
 * 3. Gardez votre UserControl FicheFilm.cs tel quel
 * 4. Assurez-vous que FicheFilm a une méthode SetFilmData(Film film)
 */
