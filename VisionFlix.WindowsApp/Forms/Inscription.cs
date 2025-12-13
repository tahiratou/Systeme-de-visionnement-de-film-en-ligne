using VisionFlix.Core.Entities;
using VisionFlix.Core.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace VisionFlix.WindowsApp.Forms
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

        }

        /// <summary>
        /// Gère l'inscription d'un nouvel utilisateur
        /// </summary>
        private async void btnLogin_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!ValiderChamps())
                    return;

                var nouvelUtilisateur = new Utilisateur
                {
                    NomUtilisateur = txtNomUtilisateur.Text.Trim(),
                    Nom = txtNom.Text.Trim(),
                    Prenom = txtPrenom.Text.Trim(),
                    Email = txtEmail.Text.Trim().ToLower(),
                    Telephone = txtTelephone.Text.Trim(),
                    Adresse = txtAdresse.Text.Trim(),
                    MotDePasse = txtMotDePasse.Text, 
                    Solde = 0,
                    EstAdministrateur = false,
                    EstAbonne = false,
                    DateInscription = DateTime.Now
                };

                var utilisateurCree = await _utilisateurService.CreateUtilisateurAsync(nouvelUtilisateur);

                if (utilisateurCree != null)
                {
                    MessageBox.Show(
                        "Inscription réussie ! Vous pouvez maintenant vous connecter.",
                        "Succès",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

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
        /// Convertit le choix de langue en code ISO
        /// </summary>
        private string ObtenirCodeLangue()
        {
            return cmbLangue.SelectedIndex switch
            {
                0 => "fr", // Français
                1 => "en", // English
                2 => "es", // Español
                3 => "de", // Deutsch
                _ => "fr"  // Par défaut
            };
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
                Connexion connexionForm = _serviceProvider.GetRequiredService<Connexion>();
                this.Hide();

                if (connexionForm.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
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

                this.Show(); 
            }
        }

        /// <summary>
        /// Valide tous les champs du formulaire
        /// </summary>
        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MessageBox.Show("Veuillez entrer votre nom.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNom.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                MessageBox.Show("Veuillez entrer votre prénom.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrenom.Focus();
                return false;
            }

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

            if (txtMotDePasse.Text != txtConfirmation.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmation.Focus();
                return false;
            }

            if (cmbLangue.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une langue.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLangue.Focus();
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