using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class GestionFinances : UserControl
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IServiceProvider _serviceProvider;

        public GestionFinances(ITransactionRepository transactionRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _transactionRepository = transactionRepository;
            _serviceProvider = serviceProvider;
            InitializeData();
            SetupEventHandlers();
        }

        private void InitializeData()
        {
            dtpDebut.Value = DateTime.Now.AddDays(-30);
            dtpFin.Value = DateTime.Now;
        }

        private void SetupEventHandlers()
        {
            btnCalculer.Click += BtnCalculer_Click;
        }

        private async void BtnCalculer_Click(object? sender, EventArgs e)
        {
            DateTime debut = dtpDebut.Value.Date;
            DateTime fin = dtpFin.Value.Date.AddDays(1).AddSeconds(-1);

            var transactions = await _transactionRepository.GetByDateRangeAsync(debut, fin);
            var achats = transactions.Where(t => t.Type == "Achat").ToList();

            if (!achats.Any())
            {
                MessageBox.Show("Aucune vente pour cette période.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetStats();
                return;
            }

            // Calcul des statistiques
            decimal revenuTotal = achats.Sum(t => t.Montant);
            int nombreVentes = achats.Count;
            decimal revenuMoyen = nombreVentes > 0 ? revenuTotal / nombreVentes : 0;

            // Film le plus vendu (basé sur la description qui contient le titre)
            var filmPlusVendu = achats
                .GroupBy(t => t.Description)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()?.Key ?? "--";

            lblRevenuTotalValue.Text = $"{revenuTotal:F2} $";
            lblNombreVentesValue.Text = nombreVentes.ToString();
            lblRevenuMoyenValue.Text = $"{revenuMoyen:F2} $";
            lblFilmPlusVenduValue.Text = filmPlusVendu;

            LoadTransactionsGrid(achats);
        }

        private void LoadTransactionsGrid(List<Transaction> transactions)
        {
            dgvVentes.SuspendLayout();
            dgvVentes.DataSource = null;

            // Créer une liste anonyme pour affichage
            var displayData = transactions.Select(t => new
            {
                t.Id,
                Date = t.DateTransaction,
                Film = t.Description,
                Prix = t.Montant
            }).ToList();

            dgvVentes.DataSource = displayData;

            if (dgvVentes.Columns["Id"] != null)
            {
                dgvVentes.Columns["Id"].Visible = false;
            }

            dgvVentes.ResumeLayout();
        }

        private void ResetStats()
        {
            lblRevenuTotalValue.Text = "0,00 $";
            lblNombreVentesValue.Text = "0";
            lblRevenuMoyenValue.Text = "0,00 $";
            lblFilmPlusVenduValue.Text = "--";
            dgvVentes.DataSource = null;
        }
    }
}