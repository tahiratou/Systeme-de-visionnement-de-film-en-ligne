using VisionFlix.Domain.Entities;
using VisionFlix.Application.Interfaces;

namespace VisionFlix.Presentation.Forms
{
    public partial class FormulaireUtilisateur : Form
    {
        private readonly IUtilisateurService _utilisateurService;
        private readonly IAuthentificationService _authService;

        public FormulaireUtilisateur(
            IUtilisateurService utilisateurService,
            IAuthentificationService authService)
        {
            InitializeComponent();
            _utilisateurService = utilisateurService;
            _authService = authService;
            this.Text = "VisionFlix - Modifier le profil";
            LoadUserData();
        }

        private void LoadUserData()
        {
            var utilisateur = _authService.CurrentUser;
            if (utilisateur == null) return;

            txtNom.Text = utilisateur.Nom;
            txtPrenom.Text = utilisateur.Prenom;
            txtEmail.Text = utilisateur.Email;
            // ❌ PAS de txtPassword - on ne modifie PAS le mot de passe ici
        }

        private async void BtnSauvegarder_Click(object? sender, EventArgs e)
        {
            var utilisateur = _authService.CurrentUser;
            if (utilisateur == null) return;

            // Validation
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Tous les champs (Nom, Prénom, Email) sont obligatoires.",
                    "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Mise à jour des propriétés
                utilisateur.Nom = txtNom.Text.Trim();
                utilisateur.Prenom = txtPrenom.Text.Trim();
                utilisateur.Email = txtEmail.Text.Trim();

                // ✅ Sauvegarde via le service
                await _utilisateurService.UpdateUtilisateurAsync(utilisateur);

                MessageBox.Show("Vos informations ont été mises à jour avec succès.",
                    "Mise à jour réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la mise à jour : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAnnuler_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}