using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class Abonnement : Form
    {
        private readonly IAuthentificationService _authService;
        private readonly IPlanAbonnementRepository _planRepository;
        private readonly IUtilisateurService _utilisateurService;

        public Abonnement(
            IAuthentificationService authService,
            IPlanAbonnementRepository planRepository,
            IUtilisateurService utilisateurService)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Abonnement";

            _authService = authService;
            _planRepository = planRepository;
            _utilisateurService = utilisateurService;

            LoadPlans();

            btnBasic.Click += BtnBasic_Click;
            btnPremium.Click += BtnPremium_Click;
            btnPlatinum.Click += BtnPlatinum_Click;
            btnResilier.Click += BtnResilier_Click;
            btnFermer.Click += BtnFermer_Click;
        }

        private async void LoadPlans()
        {
            var utilisateur = _authService.CurrentUser;
            if (utilisateur == null) return;

            if (utilisateur.EstAbonne)
            {
                lblTitre.Text = $"Votre plan actuel : {utilisateur.PlanAbonnement.Nom ?? "Standard"}";
                btnResilier.Visible = true;
                btnBasic.Enabled = btnPremium.Enabled = btnPlatinum.Enabled = false;
            }
            else
            {
                lblTitre.Text = "Choisissez votre plan d'abonnement";
                btnResilier.Visible = false;
                btnBasic.Enabled = btnPremium.Enabled = btnPlatinum.Enabled = true;
            }

            var plans = await _planRepository.GetActiveAsync();
            var plansList = plans.ToList();

            var basicPlan = plansList.FirstOrDefault(p => p.Nom == "Basique");
            if (basicPlan != null)
            {
                lblBasicNom.Text = basicPlan.Nom;
                lblBasicPrix.Text = $"{basicPlan.Prix:F2} $ / mois";
                lblBasicDescription.Text = basicPlan.Description;
            }

            var standardPlan = plansList.FirstOrDefault(p => p.Nom == "Standard");
            if (standardPlan != null)
            {
                lblPremiumNom.Text = standardPlan.Nom;
                lblPremiumPrix.Text = $"{standardPlan.Prix:F2} $ / mois";
                lblPremiumDescription.Text = standardPlan.Description;
            }

            var premiumPlan = plansList.FirstOrDefault(p => p.Nom == "Premium");
            if (premiumPlan != null)
            {
                lblPlatinumNom.Text = premiumPlan.Nom;
                lblPlatinumPrix.Text = $"{premiumPlan.Prix:F2} $ / mois";
                lblPlatinumDescription.Text = premiumPlan.Description;
            }
        }

        private async void BtnBasic_Click(object? sender, EventArgs e)
        {
            await ChoisirPlan(1, "Basique", 9.99m);
        }

        private async void BtnPremium_Click(object? sender, EventArgs e)
        {
            await ChoisirPlan(2, "Standard", 14.99m);
        }

        private async void BtnPlatinum_Click(object? sender, EventArgs e)
        {
            await ChoisirPlan(3, "Premium", 19.99m);
        }

        private async Task ChoisirPlan(int planId, string nomPlan, decimal prix)
        {
            var result = MessageBox.Show(
                $"Confirmer l'abonnement au plan {nomPlan} à {prix:F2}$ par mois?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var utilisateur = _authService.CurrentUser;
                if (utilisateur == null) return;

                if (utilisateur.Solde < prix)
                {
                    MessageBox.Show("Solde insuffisant pour cet abonnement.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {

                    MessageBox.Show(
                        $"Vous êtes maintenant abonné au plan {nomPlan}!\n" +
                        $"Votre abonnement expire le {DateTime.Now.AddMonths(1):dd/MM/yyyy}",
                        "Abonnement confirmé",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la souscription : {ex.Message}", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnResilier_Click(object? sender, EventArgs e)
        {
            var utilisateur = _authService.CurrentUser;
            if (utilisateur == null) return;

            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir résilier votre abonnement actuel ({utilisateur.PlanAbonnement.Nom})?",
                "Confirmation de résiliation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                utilisateur.EstAbonne = false;
                utilisateur.PlanAbonnementId = null;
                utilisateur.PlanAbonnement.Nom = null;

                MessageBox.Show(
                    "Votre abonnement a été résilié.\n" +
                    $"Vous pouvez continuer à l'utiliser jusqu'au {utilisateur.DateExpirationAbonnement:dd/MM/yyyy}",
                    "Résiliation confirmée",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnFermer_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}