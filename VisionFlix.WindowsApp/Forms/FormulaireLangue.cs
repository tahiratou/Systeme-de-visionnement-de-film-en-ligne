using VisionFlix.Core.Entities;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class FormulaireLangue : Form
    {
        private Langue? _langue;

        public FormulaireLangue()
        {
            InitializeComponent();
            this.Text = "VisionFlix - Ajouter une Langue";
        }

        public void SetLangue(Langue langue)
        {
            _langue = langue;
            this.Text = "VisionFlix - Modifier la Langue";

            txtNom.Text = langue.Nom;
            txtCode.Text = langue.Code;
            chkEstActive.Checked = langue.EstActive;
        }

        private void BtnSauvegarder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Le nom de la langue ne peut pas être vide.", "Erreur de validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("Le code de la langue ne peut pas être vide.", "Erreur de validation",
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

        public Langue GetLangue()
        {
            return new Langue
            {
                Id = _langue?.Id ?? 0,
                Nom = txtNom.Text.Trim(),
                Code = txtCode.Text.Trim(),
                EstActive = chkEstActive.Checked
            };
        }
    }
}