using VisionFlix.Core.Entities;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class FormulaireCategorie : Form
    {
        private Categorie? _categorie;

        public FormulaireCategorie()
        {
            InitializeComponent();
            this.Text = "VisionFlix - Ajouter une catégorie";
        }

        public void SetCategorie(Categorie categorie)
        {
            _categorie = categorie;
            this.Text = "VisionFlix - Modifier la catégorie";

            txtNom.Text = categorie.Nom;
            txtDescription.Text = categorie.Description;
            chkEstActive.Checked = categorie.EstActive;
        }

        private void BtnSauvegarder_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Le nom de la catégorie est obligatoire.", "Erreur de validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnAnnuler_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Categorie GetCategorie()
        {
            return new Categorie
            {
                Id = _categorie?.Id ?? 0,
                Nom = txtNom.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                EstActive = chkEstActive.Checked
            };
        }
    }
}