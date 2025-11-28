using Microsoft.Extensions.DependencyInjection;
using VisionFlix.Application.Interfaces;
using VisionFlix.Domain.Entities;

namespace VisionFlix.Presentation.Forms
{
    public partial class Inscription : Form
    {
        private readonly IUtilisateurService _utilisateurService;
        private readonly IServiceProvider _serviceProvider;

        // CONSTRUCTEUR AVEC INJECTION DE DÉPENDANCES
        public Inscription(IUtilisateurService utilisateurService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Inscription";
            _utilisateurService = utilisateurService;
            _serviceProvider = serviceProvider;
        }

        // BOUTON INSCRIPTION (S'ENREGISTRER)
        private async void btnLogin_Click(object? sender, EventArgs e)
        {
            // Désactiver le bouton pendant le traitement
            btnLogin.Enabled = false;
            btnLogin.Text = "Inscription en cours...";

            try
            {
                // ===== RÉCUPÉRER LES VALEURS - NOMS LOGIQUES =====

                // COLONNE DE GAUCHE
                string nom = txtNom.Text.Trim();
                string prenom = txtPrenom.Text.Trim();
                string email = txtEmail.Text.Trim();
                string telephone = txtTelephone.Text.Trim();

                // COLONNE DE DROITE
                string adresse = txtAdresse.Text.Trim();
                string nomUtilisateur = txtNomUtilisateur.Text.Trim();
                string motDePasse = txtMotDePasse.Text;
                string confirmation = txtConfirmation.Text;

                // ===== VALIDATION DES CHAMPS =====

                // Validation Nom
                if (string.IsNullOrWhiteSpace(nom))
                {
                    MessageBox.Show("Le nom est obligatoire.", "Erreur de validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNom.Focus();
                    return;
                }

                // Validation Prénom
                if (string.IsNullOrWhiteSpace(prenom))
                {
                    MessageBox.Show("Le prénom est obligatoire.", "Erreur de validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrenom.Focus();
                    return;
                }

                // Validation Email
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("L'email est obligatoire.", "Erreur de validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Veuillez entrer un email valide (exemple: utilisateur@domaine.com).",
                        "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                // Validation Nom d'utilisateur
                if (string.IsNullOrWhiteSpace(nomUtilisateur))
                {
                    MessageBox.Show("Le nom d'utilisateur est obligatoire.", "Erreur de validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomUtilisateur.Focus();
                    return;
                }

                if (nomUtilisateur.Length < 3)
                {
                    MessageBox.Show("Le nom d'utilisateur doit contenir au moins 3 caractères.",
                        "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomUtilisateur.Focus();
                    return;
                }

                // Validation Mot de passe
                if (string.IsNullOrWhiteSpace(motDePasse))
                {
                    MessageBox.Show("Le mot de passe est obligatoire.", "Erreur de validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMotDePasse.Focus();
                    return;
                }

                if (motDePasse.Length < 6)
                {
                    MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.",
                        "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMotDePasse.Focus();
                    return;
                }

                // Validation Confirmation
                if (motDePasse != confirmation)
                {
                    MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur de validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmation.Focus();
                    return;
                }

                // ===== VÉRIFIER SI L'EMAIL EXISTE DÉJÀ =====
                bool emailExiste = await _utilisateurService.EmailExistsAsync(email);

                if (emailExiste)
                {
                    MessageBox.Show("Un compte avec cet email existe déjà.\nVeuillez utiliser un autre email ou vous connecter.",
                        "Email déjà utilisé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    return;
                }

                // ===== CRÉER LE NOUVEL UTILISATEUR =====
                var nouvelUtilisateur = new Utilisateur
                {
                    NomUtilisateur = nomUtilisateur,
                    Nom = nom,
                    Prenom = prenom,
                    Email = email,
                    Telephone = telephone ?? "",
                    Adresse = adresse ?? "",
                    MotDePasse = motDePasse,          // TODO: Hasher le mot de passe en production!
                    Solde = 50.00m,                   // Bonus de bienvenue: 50$
                    EstAdministrateur = false,
                    EstAbonne = false,
                    PlanAbonnementId = null,
                    DateInscription = DateTime.Now,
                    DateExpirationAbonnement = null
                };

                // ===== ENREGISTRER DANS LA BASE DE DONNÉES SQL SERVER =====
                await _utilisateurService.CreateUtilisateurAsync(nouvelUtilisateur);

                // ===== SUCCÈS =====
                MessageBox.Show(
                    $"Inscription réussie!\n\n" +
                    $"Bienvenue {prenom} {nom}!\n\n" +
                    $"Nom d'utilisateur: {nomUtilisateur}\n" +
                    $"Vous avez reçu un bonus de bienvenue de 50.00$.\n\n" +
                    $"Vous pouvez maintenant vous connecter avec votre email et mot de passe.",
                    "Inscription réussie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Fermer le formulaire et retourner à la connexion
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'inscription:\n\n{ex.Message}\n\n" +
                    $"Détails: {ex.InnerException?.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                // Réactiver le bouton
                btnLogin.Enabled = true;
                btnLogin.Text = "S'inscrire";
            }
        }

        // LIEN "SE CONNECTER" (Retour à la connexion)
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Annuler l'inscription et retourner à la connexion
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}