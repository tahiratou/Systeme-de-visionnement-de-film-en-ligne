using VisionFlix.Domain.Entities;
using VisionFlix.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace VisionFlix.Presentation.Forms
{
    public partial class Inscription : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IUtilisateurService _utilisateurService;

        public Inscription(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Inscription";

            _serviceProvider = serviceProvider;
            _utilisateurService = _serviceProvider.GetRequiredService<IUtilisateurService>();

            // Les événements sont déjà attachés dans InitializeComponent()
            // btnLogin.Click += btnLogin_Click;
            // linkLabel2.LinkClicked += linkLabel2_LinkClicked;
        }

        /// <summary>
        /// Gère l'inscription d'un nouvel utilisateur
        /// </summary>
        private async void btnLogin_Click(object? sender, EventArgs e)
        {
            try
            {
                // ✅ VALIDATION DES CHAMPS
                if (!ValiderChamps())
                    return;

                // ✅ CRÉER L'UTILISATEUR
                var nouvelUtilisateur = new Utilisateur
                {
                    NomUtilisateur = txtNomUtilisateur.Text.Trim(),
                    Nom = txtNom.Text.Trim(),
                    Prenom = txtPrenom.Text.Trim(),
                    Email = txtEmail.Text.Trim().ToLower(),
                    Telephone = txtTelephone.Text.Trim(),
                    Adresse = txtAdresse.Text.Trim(),
                    MotDePasse = txtMotDePasse.Text, // Sera hashé par le service
                    Solde = 0,
                    EstAdministrateur = false,
                    EstAbonne = false,
                    DateInscription = DateTime.Now
                };

                // ✅ ENREGISTRER DANS LA BASE DE DONNÉES
                var utilisateurCree = await _utilisateurService.CreateUtilisateurAsync(nouvelUtilisateur);

                if (utilisateurCree != null)
                {
                    MessageBox.Show(
                        "Inscription réussie ! Vous pouvez maintenant vous connecter.",
                        "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // ✅ OUVRIR LA PAGE DE CONNEXION
                    OuvrirPageConnexion();
                }
                else
                {
                    MessageBox.Show(
                        "Une erreur est survenue lors de l'inscription. Veuillez réessayer.",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (InvalidOperationException ex)
            {
                // Erreurs de validation du service
                MessageBox.Show(
                    ex.Message,
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'inscription:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                System.Diagnostics.Debug.WriteLine($"❌ Erreur inscription: {ex.Message}");
            }
        }

        /// <summary>
        /// Gère le clic sur le lien "Se connecter"
        /// </summary>
        private void linkLabel2_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            OuvrirPageConnexion();
        }

        /// <summary>
        /// Ouvre la page de connexion et ferme la page d'inscription
        /// </summary>
        private void OuvrirPageConnexion()
        {
            try
            {
                // ✅ Créer le formulaire de connexion
                Connexion connexionForm = _serviceProvider.GetRequiredService<Connexion>();

                // ✅ FERMER la page d'inscription
                this.Hide();

                // ✅ Afficher la page de connexion
                if (connexionForm.ShowDialog() == DialogResult.OK)
                {
                    // Si connexion réussie, fermer définitivement l'inscription
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Si connexion annulée, réafficher l'inscription
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'ouverture de la connexion:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                this.Show(); // Réafficher l'inscription en cas d'erreur
            }
        }

        /// <summary>
        /// Valide tous les champs du formulaire
        /// </summary>
        private bool ValiderChamps()
        {
            // ✅ VALIDATION NOM
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Veuillez entrer votre nom.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }

            // ✅ VALIDATION PRÉNOM
            if (string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                MessageBox.Show("Veuillez entrer votre prénom.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrenom.Focus();
                return false;
            }

            // ✅ VALIDATION EMAIL
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Veuillez entrer votre email.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!EstEmailValide(txtEmail.Text))
            {
                MessageBox.Show("Format d'email invalide.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // ✅ VALIDATION NOM D'UTILISATEUR
            if (string.IsNullOrWhiteSpace(txtNomUtilisateur.Text))
            {
                MessageBox.Show("Veuillez entrer un nom d'utilisateur.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomUtilisateur.Focus();
                return false;
            }

            if (txtNomUtilisateur.Text.Length < 3)
            {
                MessageBox.Show("Le nom d'utilisateur doit contenir au moins 3 caractères.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomUtilisateur.Focus();
                return false;
            }

            // ✅ VALIDATION MOT DE PASSE
            if (string.IsNullOrWhiteSpace(txtMotDePasse.Text))
            {
                MessageBox.Show("Veuillez entrer un mot de passe.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotDePasse.Focus();
                return false;
            }

            if (txtMotDePasse.Text.Length < 6)
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMotDePasse.Focus();
                return false;
            }

            // ✅ VALIDATION CONFIRMATION MOT DE PASSE
            if (txtMotDePasse.Text != txtConfirmation.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmation.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Vérifie si l'email est valide
        /// </summary>
        private bool EstEmailValide(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Pattern regex pour email
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }
    }
}