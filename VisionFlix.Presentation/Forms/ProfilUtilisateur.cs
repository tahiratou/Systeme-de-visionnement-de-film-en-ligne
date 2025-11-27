using VisionFlix.Domain.Entities;
using VisionFlix.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.Presentation.Forms
{
    public partial class ProfilUtilisateur : Form
    {
        private readonly IAuthentificationService _authService;
        private readonly IServiceProvider _serviceProvider;

        public ProfilUtilisateur(IAuthentificationService authService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Profil Utilisateur";
            _authService = authService;
            _serviceProvider = serviceProvider;
            LoadUserData();

            btnModifierProfil.Click += BtnModifierProfil_Click;
        }

        private void BtnModifierProfil_Click(object? sender, EventArgs e)
        {
            var formulaireUtilisateur = _serviceProvider.GetRequiredService<FormulaireUtilisateur>();
            if (formulaireUtilisateur.ShowDialog() == DialogResult.OK)
            {
                LoadUserData(); // Refresh data after update
            }
        }

        private void LoadUserData()
        {
            var user = _authService.CurrentUser;
            if (user == null) return;

            lblNomValue.Text = $"{user.Prenom} {user.Nom}";
            lblEmailValue.Text = user.Email;
            lblSoldeValue.Text = $"{user.Solde:F2} $";

            // Utiliser PlanAbonnementNom au lieu de PlanActuel
            lblAbonnementValue.Text = user.EstAbonne ? user.PlanAbonnement.Nom ?? "Standard" : "Aucun";
        }

        private void BtnGererAbonnement_Click(object? sender, EventArgs e)
        {
            var abonnementForm = _serviceProvider.GetRequiredService<Abonnement>();
            if (abonnementForm.ShowDialog() == DialogResult.OK)
            {
                LoadUserData();
            }
        }

        private void BtnFermer_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}