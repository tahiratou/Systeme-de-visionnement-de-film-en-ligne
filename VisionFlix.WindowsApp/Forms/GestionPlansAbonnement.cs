using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class GestionPlansAbonnement : UserControl
    {
        private readonly IPlanAbonnementRepository _planAbonnementRepository;
        private readonly IServiceProvider _serviceProvider;

        public GestionPlansAbonnement(IPlanAbonnementRepository planAbonnementRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _planAbonnementRepository = planAbonnementRepository;
            _serviceProvider = serviceProvider;
            LoadPlansAbonnement();
        }

        private async void LoadPlansAbonnement()
        {
            dgvPlansAbonnement.SuspendLayout();
            dgvPlansAbonnement.DataSource = null;

            var plans = await _planAbonnementRepository.ListAllAsync();
            dgvPlansAbonnement.DataSource = plans.ToList();

            if (dgvPlansAbonnement.Columns["Id"] != null)
            {
                dgvPlansAbonnement.Columns["Id"].Visible = false;
            }
            dgvPlansAbonnement.ResumeLayout();
        }

        private async void BtnAjouter_Click(object? sender, EventArgs e)
        {
            using (var form = _serviceProvider.GetRequiredService<FormulairePlanAbonnement>())
            {
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PlanAbonnement nouveauPlan = form.GetPlanAbonnement();
                    await _planAbonnementRepository.AddAsync(nouveauPlan);
                    LoadPlansAbonnement();
                    MessageBox.Show("Plan d'abonnement ajouté avec succès!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void BtnModifier_Click(object? sender, EventArgs e)
        {
            if (dgvPlansAbonnement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un plan d'abonnement à modifier.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PlanAbonnement planOriginal = (PlanAbonnement)dgvPlansAbonnement.SelectedRows[0].DataBoundItem;

            using (var form = _serviceProvider.GetRequiredService<FormulairePlanAbonnement>())
            {
                form.SetPlanAbonnement(planOriginal);
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PlanAbonnement planModifie = form.GetPlanAbonnement();
                    planModifie.Id = planOriginal.Id;
                    await _planAbonnementRepository.UpdateAsync(planModifie);
                    LoadPlansAbonnement();
                    MessageBox.Show("Plan d'abonnement modifié avec succès!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void BtnSupprimer_Click(object? sender, EventArgs e)
        {
            if (dgvPlansAbonnement.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un plan d'abonnement à supprimer.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PlanAbonnement plan = (PlanAbonnement)dgvPlansAbonnement.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer le plan d'abonnement '{plan.Nom}' ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await _planAbonnementRepository.DeleteAsync(plan);
                LoadPlansAbonnement();
                MessageBox.Show("Plan d'abonnement supprimé avec succès!", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRafraichir_Click(object? sender, EventArgs e)
        {
            LoadPlansAbonnement();
            MessageBox.Show("Liste des plans d'abonnement rafraîchie!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}