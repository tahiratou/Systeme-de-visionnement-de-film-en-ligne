using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class GestionLangues : UserControl
    {
        private readonly ILangueRepository _langueRepository;
        private readonly IServiceProvider _serviceProvider;

        public GestionLangues(ILangueRepository langueRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _langueRepository = langueRepository;
            _serviceProvider = serviceProvider;
            LoadLangues();
        }

        private async void LoadLangues()
        {
            dgvLangues.SuspendLayout();
            dgvLangues.DataSource = null;

            var langues = await _langueRepository.ListAllAsync();
            dgvLangues.DataSource = langues.ToList();

            if (dgvLangues.Columns["Id"] != null)
            {
                dgvLangues.Columns["Id"].Visible = false;
            }
            dgvLangues.ResumeLayout();
        }

        private async void BtnAjouter_Click(object? sender, EventArgs e)
        {
            using (var form = _serviceProvider.GetRequiredService<FormulaireLangue>())
            {
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Langue nouvelleLangue = form.GetLangue();
                    await _langueRepository.AddAsync(nouvelleLangue);
                    LoadLangues();
                    MessageBox.Show("Langue ajoutée avec succès!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void BtnModifier_Click(object? sender, EventArgs e)
        {
            if (dgvLangues.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une langue à modifier.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Langue langueOriginale = (Langue)dgvLangues.SelectedRows[0].DataBoundItem;

            using (var form = _serviceProvider.GetRequiredService<FormulaireLangue>())
            {
                form.SetLangue(langueOriginale);
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Langue langueModifiee = form.GetLangue();
                    langueModifiee.Id = langueOriginale.Id;
                    await _langueRepository.UpdateAsync(langueModifiee);
                    LoadLangues();
                    MessageBox.Show("Langue modifiée avec succès!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async void BtnSupprimer_Click(object? sender, EventArgs e)
        {
            if (dgvLangues.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une langue à supprimer.", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Langue langue = (Langue)dgvLangues.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show(
                $"Êtes-vous sûr de vouloir supprimer la langue '{langue.Nom}' ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await _langueRepository.DeleteAsync(langue);
                LoadLangues();
                MessageBox.Show("Langue supprimée avec succès!", "Succès",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRafraichir_Click(object? sender, EventArgs e)
        {
            LoadLangues();
            MessageBox.Show("Liste des langues rafraîchie!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}