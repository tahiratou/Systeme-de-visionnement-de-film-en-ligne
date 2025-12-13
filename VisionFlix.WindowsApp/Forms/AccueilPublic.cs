using VisionFlix.Core.Interfaces;
using VisionFlix.Core.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class AccueilPublic : Form
    {
        private readonly IFilmService _filmService;
        private readonly IServiceProvider _serviceProvider;

        public AccueilPublic(
            IFilmService filmService,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Découvrez nos films";

            _filmService = filmService;
            _serviceProvider = serviceProvider;

            InitializeData();
            LoadFilms();
            SetupEventHandlers();
        }

        private void InitializeData()
        {
            cmbGenre.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            cmbRating.SelectedIndex = 0;
        }

        private void SetupEventHandlers()
        {
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
                MessageBox.Show(
                    $"Erreur lors du chargement des films : {ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

                var films = await _filmService.SearchFilmsAsync(
                    titre: string.IsNullOrWhiteSpace(searchText) ? null : searchText,
                    genre: selectedGenre == "Tous" ? null : selectedGenre,
                    annee: null,
                    noteMinimum: minRating > 0 ? minRating : null
                );

                films = FilterByYear(films, yearFilter);
                AfficherFilms(films);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de la recherche : {ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private IEnumerable<Film> FilterByYear(IEnumerable<Film> films, string yearFilter)
        {
            return yearFilter switch
            {
                "Toutes" => films,
                "2024" => films.Where(f => f.Annee == 2024),
                "2023" => films.Where(f => f.Annee == 2023),
                "2022" => films.Where(f => f.Annee == 2022),
                "2021" => films.Where(f => f.Annee == 2021),
                "2020" => films.Where(f => f.Annee == 2020),
                "2010-2019" => films.Where(f => f.Annee >= 2010 && f.Annee <= 2019),
                "2000-2009" => films.Where(f => f.Annee >= 2000 && f.Annee <= 2009),
                "1990-1999" => films.Where(f => f.Annee >= 1990 && f.Annee <= 1999),
                "Classiques" => films.Where(f => f.Annee < 1990),
                _ => films
            };
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
            lblStatus.Text = $"{films.Count()} films disponibles";
        }

        
        private void OnFilmCardClicked(object? sender, Film film)
        {
            OuvrirDetailsFilmPublic(film);
        }

       
        private void OuvrirDetailsFilmPublic(Film film)
        {
            try
            {
                var detailsForm = _serviceProvider.GetRequiredService<DetailsFilmPublic>();
                detailsForm.SetFilm(film);
                detailsForm.ConnexionDemandee += (s, e) => OuvrirConnexion(); 
                detailsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'ouverture des détails:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnProfil_Click(object? sender, EventArgs e)
        {
            var menuProfil = new ContextMenuStrip();
            menuProfil.BackColor = Color.FromArgb(30, 30, 30);
            menuProfil.ForeColor = Color.White;

            var itemConnexion = new ToolStripMenuItem("Se connecter");
            itemConnexion.BackColor = Color.FromArgb(30, 30, 30);
            itemConnexion.ForeColor = Color.White;
            itemConnexion.Click += (s, args) => OuvrirConnexion();

            var itemInscription = new ToolStripMenuItem("S'inscrire");
            itemInscription.BackColor = Color.FromArgb(30, 30, 30);
            itemInscription.ForeColor = Color.White;
            itemInscription.Click += (s, args) => OuvrirInscription();

            menuProfil.Items.Add(itemConnexion);
            menuProfil.Items.Add(itemInscription);

            menuProfil.Show(btnProfil, new Point(0, btnProfil.Height));
        }

        private void OuvrirConnexion()
        {
            try
            {
                var connexionForm = _serviceProvider.GetRequiredService<Connexion>();

                if (connexionForm.ShowDialog() == DialogResult.OK)
                {
                    this.Hide();
                    OuvrirAccueilPrive();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'ouverture de la connexion:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Show();
            }
        }

        private void OuvrirInscription()
        {
            try
            {
                var inscriptionForm = _serviceProvider.GetRequiredService<Inscription>();

                if (inscriptionForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(
                        "Inscription réussie ! Vous pouvez maintenant vous connecter.",
                        "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    OuvrirConnexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'ouverture de l'inscription:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void OuvrirAccueilPrive()
        {
            try
            {
                var accueilPrive = _serviceProvider.GetRequiredService<Accueil>();
                accueilPrive.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'ouverture de l'accueil:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Show();
            }
        }

        private void BtnSearch_Click(object? sender, EventArgs e) => ApplyFilters();

        private void TxtSearch_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ApplyFilters();
                e.Handled = true;
            }
        }

        private void BtnApplyFilters_Click(object? sender, EventArgs e) => ApplyFilters();

        private void BtnResetFilters_Click(object? sender, EventArgs e)
        {
            cmbGenre.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
            cmbRating.SelectedIndex = 0;
            txtSearch.Text = "";
            ApplyFilters();
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