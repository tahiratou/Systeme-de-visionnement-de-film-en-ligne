using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class GestionCategories : UserControl
    {
        private readonly ICategorieRepository _categorieRepository;
        private readonly IServiceProvider _serviceProvider;

        public GestionCategories(ICategorieRepository categorieRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _categorieRepository = categorieRepository;
            _serviceProvider = serviceProvider;
            LoadCategories();
        }

        private async void LoadCategories()
        {
            dgvCategories.SuspendLayout();
            dgvCategories.DataSource = null;

            var categories = await _categorieRepository.ListAllAsync();
            dgvCategories.DataSource = categories.ToList();

            if (dgvCategories.Columns["Id"] != null)
            {
                dgvCategories.Columns["Id"].Visible = false;
            }
            dgvCategories.ResumeLayout();
        }

        private async void BtnAjouter_Click(object? sender, EventArgs e)
        {
            using (var form = _serviceProvider.GetRequiredService<FormulaireCategorie>())
            {
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Categorie nouvelleCategorie = form.GetCategorie();
                    await _categorieRepository.AddAsync(nouvelleCategorie);
                    LoadCategories();
                    MessageBox.Show("Catégorie ajoutée avec succès!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void BtnModifier_Click(object? sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à modifier.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categorie catOriginale = (Categorie)dgvCategories.SelectedRows[0].DataBoundItem;

            using (var form = _serviceProvider.GetRequiredService<FormulaireCategorie>())
            {
                form.SetCategorie(catOriginale);
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Categorie catModifiee = form.GetCategorie();
                    catModifiee.Id = catOriginale.Id;
                    await _categorieRepository.UpdateAsync(catModifiee);
                    LoadCategories();
                    MessageBox.Show("Catégorie modifiée avec succès!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void BtnSupprimer_Click(object? sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à supprimer.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categorie cat = (Categorie)dgvCategories.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer la catégorie '{cat.Nom}' ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await _categorieRepository.DeleteAsync(cat);
                LoadCategories();
                MessageBox.Show("Catégorie supprimée avec succès!", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRafraichir_Click(object? sender, EventArgs e)
        {
            LoadCategories();
            MessageBox.Show("Liste rafraîchie!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
