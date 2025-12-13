using VisionFlix.WindowsApp.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class PanneauAdmin : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private GestionFilms? gestionFilms;
        private GestionFinances? gestionFinances;
        private GestionCategories? gestionCategories;
        private GestionPlansAbonnement? gestionPlans;
        private GestionLangues? gestionLangues;

        public PanneauAdmin(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Panneau Administrateur";
            _serviceProvider = serviceProvider;

            InitializeCustomTabs();

            btnRetourAccueil.Click += BtnRetourAccueil_Click;
        }

        private void InitializeCustomTabs()
        {
            // ✅ Gestion Films avec injection
            gestionFilms = _serviceProvider.GetRequiredService<GestionFilms>();
            gestionFilms.Dock = DockStyle.Fill;
            tabGestionFilms.Controls.Add(gestionFilms);

            // ✅ Gestion Finances avec injection
            gestionFinances = _serviceProvider.GetRequiredService<GestionFinances>();
            gestionFinances.Dock = DockStyle.Fill;
            tabFinances.Controls.Add(gestionFinances);

            // ✅ Gestion Catégories avec injection
            gestionCategories = _serviceProvider.GetRequiredService<GestionCategories>();
            gestionCategories.Dock = DockStyle.Fill;
            tabCategories.Controls.Add(gestionCategories);

            // ✅ Gestion Plans d'Abonnement avec injection
            gestionPlans = _serviceProvider.GetRequiredService<GestionPlansAbonnement>();
            gestionPlans.Dock = DockStyle.Fill;
            tabPlansAbonnement.Controls.Add(gestionPlans);

            // ✅ Gestion Langues avec injection
            gestionLangues = _serviceProvider.GetRequiredService<GestionLangues>();
            gestionLangues.Dock = DockStyle.Fill;
            tabLangues.Controls.Add(gestionLangues);
        }

        private void BtnRetourAccueil_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}