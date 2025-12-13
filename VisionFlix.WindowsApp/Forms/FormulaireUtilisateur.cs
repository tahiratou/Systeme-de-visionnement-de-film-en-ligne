using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class FormulaireUtilisateur : Form
    {
        private readonly IUtilisateurService _utilisateurService;
        private readonly IAuthentificationService _authService;
        private readonly Utilisateur _utilisateur;
        private bool _modifierMotDePasse = false;

        public FormulaireUtilisateur(
            IUtilisateurService utilisateurService,
            IAuthentificationService authService)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Modifier le profil";

            _utilisateurService = utilisateurService;
            _authService = authService;

            // Récupérer l'utilisateur connecté
            _utilisateur = _authService.CurrentUser
                ?? throw new InvalidOperationException("Aucun utilisateur connecté");

            ChargerDonneesUtilisateur();
            ConfigurerChampsMotDePasse();
        }

        private void ChargerDonneesUtilisateur()
        {
            // Charger les informations de base
            txtNom.Text = _utilisateur.Nom;
            txtPrenom.Text = _utilisateur.Prenom;
            txtEmail.Text = _utilisateur.Email;

            // Les champs mot de passe sont vides par défaut
            txtMotDePasseActuel.Clear();
            txtNouveauMotDePasse.Clear();
            txtConfirmerMotDePasse.Clear();
        }

        private void ConfigurerChampsMotDePasse()
        {
            // Masquer les champs de mot de passe au départ
            lblMotDePasseActuel.Visible = false;
            txtMotDePasseActuel.Visible = false;
            lblNouveauMotDePasse.Visible = false;
            txtNouveauMotDePasse.Visible = false;
            lblConfirmerMotDePasse.Visible = false;
            txtConfirmerMotDePasse.Visible = false;

            // Configurer le mode Password pour les TextBox
            txtMotDePasseActuel.PasswordChar = '•';
            txtNouveauMotDePasse.PasswordChar = '•';
            txtConfirmerMotDePasse.PasswordChar = '•';
        }

        private void ChkModifierMotDePasse_CheckedChanged(object? sender, EventArgs e)
        {
            _modifierMotDePasse = chkModifierMotDePasse.Checked;

            // Afficher/masquer les champs
            lblMotDePasseActuel.Visible = _modifierMotDePasse;
            txtMotDePasseActuel.Visible = _modifierMotDePasse;
            lblNouveauMotDePasse.Visible = _modifierMotDePasse;
            txtNouveauMotDePasse.Visible = _modifierMotDePasse;
            lblConfirmerMotDePasse.Visible = _modifierMotDePasse;
            txtConfirmerMotDePasse.Visible = _modifierMotDePasse;

            // Vider les champs si on décoche
            if (!_modifierMotDePasse)
            {
                txtMotDePasseActuel.Clear();
                txtNouveauMotDePasse.Clear();
                txtConfirmerMotDePasse.Clear();
            }
        }

        private async void BtnSauvegarder_Click(object? sender, EventArgs e)
        {
            try
            {
                // ═══════════════════════════════════════════════════
                //  VALIDATION DES CHAMPS DE BASE
                // ═══════════════════════════════════════════════════

                if (string.IsNullOrWhiteSpace(txtNom.Text))
                {
                    MessageBox.Show(
                        "Le nom est obligatoire.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    txtNom.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPrenom.Text))
                {
                    MessageBox.Show(
                        "Le prénom est obligatoire.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    txtPrenom.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show(
                        "L'email est obligatoire.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    txtEmail.Focus();
                    return;
                }

                // Validation format email
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show(
                        "L'email n'est pas valide.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    txtEmail.Focus();
                    return;
                }

                // ═══════════════════════════════════════════════════
                //  VALIDATION MOT DE PASSE (si modification)
                // ═══════════════════════════════════════════════════

                if (_modifierMotDePasse)
                {
                    // Vérifier que le mot de passe actuel est fourni
                    if (string.IsNullOrWhiteSpace(txtMotDePasseActuel.Text))
                    {
                        MessageBox.Show(
                            "Veuillez entrer votre mot de passe actuel.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        txtMotDePasseActuel.Focus();
                        return;
                    }

                    // Vérifier que le mot de passe actuel est correct
                    var motDePasseValide = await _authService.ValiderMotDePasseAsync(
                        _utilisateur.Email,
                        txtMotDePasseActuel.Text
                    );

                    if (!motDePasseValide)
                    {
                        MessageBox.Show(
                            "Le mot de passe actuel est incorrect.",
                            "Erreur",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        txtMotDePasseActuel.Focus();
                        txtMotDePasseActuel.SelectAll();
                        return;
                    }

                    // Vérifier que le nouveau mot de passe est fourni
                    if (string.IsNullOrWhiteSpace(txtNouveauMotDePasse.Text))
                    {
                        MessageBox.Show(
                            "Veuillez entrer un nouveau mot de passe.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        txtNouveauMotDePasse.Focus();
                        return;
                    }

                    // ✅ VALIDATION: Minimum 6 caractères
                    if (txtNouveauMotDePasse.Text.Length < 6)
                    {
                        MessageBox.Show(
                            "Le nouveau mot de passe doit contenir au moins 6 caractères.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        txtNouveauMotDePasse.Focus();
                        txtNouveauMotDePasse.SelectAll();
                        return;
                    }

                    // ✅ VALIDATION: Confirmation mot de passe
                    if (txtNouveauMotDePasse.Text != txtConfirmerMotDePasse.Text)
                    {
                        MessageBox.Show(
                            "Le nouveau mot de passe et la confirmation ne correspondent pas.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        txtConfirmerMotDePasse.Focus();
                        txtConfirmerMotDePasse.SelectAll();
                        return;
                    }
                }

                // ═══════════════════════════════════════════════════
                //  MISE À JOUR DES INFORMATIONS
                // ═══════════════════════════════════════════════════

                // Mettre à jour les informations de base
                _utilisateur.Nom = txtNom.Text.Trim();
                _utilisateur.Prenom = txtPrenom.Text.Trim();
                _utilisateur.Email = txtEmail.Text.Trim();

                // Mettre à jour le mot de passe si demandé
                if (_modifierMotDePasse)
                {
                    _utilisateur.MotDePasse = txtNouveauMotDePasse.Text;
                }

                // Sauvegarder via le service
                await _utilisateurService.UpdateUtilisateurAsync(_utilisateur);

                MessageBox.Show(
                    "Profil modifié avec succès!",
                    "Succès",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de la modification du profil:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnAnnuler_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNouveauMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNouveauMotDePasse_Click(object sender, EventArgs e)
        {

        }
    }
}