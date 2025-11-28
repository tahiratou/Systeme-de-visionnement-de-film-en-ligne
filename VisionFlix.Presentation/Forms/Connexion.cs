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

        // Bouton de connexion
        private async void btnLogin_Click(object? sender, EventArgs e)
        {
            // ✅ AVANT: string email = textBox1.Text.Trim();
            // ✅ APRÈS: string nomUtilisateur = txtNomUtilisateur.Text.Trim();
            string nomUtilisateur = txtIdentifiant.Text.Trim();

            // ✅ AVANT: string motDePasse = textBox2.Text;
            // ✅ APRÈS: string motDePasse = txtMotDePasse.Text;
            string motDePasse = txtMotDePasse.Text;

            // Validation des champs
            if (string.IsNullOrWhiteSpace(nomUtilisateur))
            {
                MessageBox.Show("Veuillez entrer votre nom d'utilisateur.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentifiant.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("Veuillez entrer votre mot de passe.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotDePasse.Focus();
                return;
            }

            // Désactiver le bouton pendant le traitement
            btnLogin.Enabled = false;
            btnLogin.Text = "Connexion en cours...";

            try
            {
                // Utiliser le service d'authentification avec le nom d'utilisateur
                var utilisateur = await _authService.ConnecterAsync(nomUtilisateur, motDePasse);

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
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur de connexion",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Mettre le focus sur le nom d'utilisateur pour permettre une nouvelle tentative
                    txtIdentifiant.Focus();
                    txtIdentifiant.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la connexion : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Réactiver le bouton
                btnLogin.Enabled = true;
                btnLogin.Text = "Connexion";
            }
        }

        // Lien "S'inscrire"
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var inscriptionForm = _serviceProvider.GetRequiredService<Inscription>();
            this.Hide();  // Cache la connexion
            var result = inscriptionForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // L'inscription a réussi, on peut fermer la connexion
                this.Close();
            }
            else
            {
                // L'utilisateur a annulé, on réaffiche la connexion
                this.Show();
            }
        }
    }
}