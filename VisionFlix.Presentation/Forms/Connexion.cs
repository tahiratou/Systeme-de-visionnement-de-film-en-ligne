using VisionFlix.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.Presentation.Forms
{
    public partial class Connexion : Form
    {
        private readonly IAuthentificationService _authService;
        private readonly IServiceProvider _serviceProvider;

        // CONSTRUCTEUR AVEC INJECTION DE DÉPENDANCES
        public Connexion(IAuthentificationService authService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Connexion";
            
            _authService = authService;
            _serviceProvider = serviceProvider;
        }

        // GARDEZ VOTRE CODE DESIGNER.CS TEL QUEL
        // Modifiez uniquement la logique du bouton Login:

        private async void btnLogin_Click(object? sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string motDePasse = textBox2.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Utiliser le service d'authentification
                var utilisateur = await _authService.ConnecterAsync(email, motDePasse);

                if (utilisateur != null)
                {
                    MessageBox.Show($"Bienvenue {utilisateur.Prenom} {utilisateur.Nom}!",
                        "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ouvrir le formulaire Accueil
                    var accueilForm = _serviceProvider.GetRequiredService<Accueil>();
                    this.Hide();
                    accueilForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email ou mot de passe incorrect.", "Erreur de connexion",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la connexion : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Si vous avez un lien "S'inscrire"
        private void linkLabel2_Click(object? sender, EventArgs e)
        {
            var inscriptionForm = _serviceProvider.GetRequiredService<Inscription>();
            inscriptionForm.ShowDialog();
        }
    }
}

