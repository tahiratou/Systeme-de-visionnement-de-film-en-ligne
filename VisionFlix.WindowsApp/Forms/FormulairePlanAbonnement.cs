using VisionFlix.Core.Entities;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class FormulairePlanAbonnement : Form
    {
        private PlanAbonnement? _planAbonnement;

        public FormulairePlanAbonnement()
        {
            InitializeComponent();
            this.Text = "VisionFlix - Ajouter un Plan d'Abonnement";
        }

        public void SetPlanAbonnement(PlanAbonnement planAbonnement)
        {
            _planAbonnement = planAbonnement;
            this.Text = "VisionFlix - Modifier le Plan d'Abonnement";

            txtNom.Text = planAbonnement.Nom;
            numPrix.Value = planAbonnement.Prix;
            txtDescription.Text = planAbonnement.Description;
            chkEstActif.Checked = planAbonnement.EstActif;
        }

        private void BtnSauvegarder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Le nom du plan d'abonnement ne peut pas être vide.", "Erreur de validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public PlanAbonnement GetPlanAbonnement()
        {
            return new PlanAbonnement
            {
                Id = _planAbonnement?.Id ?? 0,
                Nom = txtNom.Text.Trim(),
                Prix = numPrix.Value,
                Description = txtDescription.Text.Trim(),
                EstActif = chkEstActif.Checked
            };
        }
    }
}