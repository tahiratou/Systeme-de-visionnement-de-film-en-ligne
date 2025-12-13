using Microsoft.Extensions.DependencyInjection;
using System;
using VisionFlix.Core.Interfaces;
using VisionFlix.Core.Entities;

namespace VisionFlix.WindowsApp.Forms
{
    public partial class ProfilUtilisateur : Form
    {
        private Utilisateur? _user;  
        private readonly IServiceProvider _serviceProvider;
        private readonly IAuthentificationService _authService;
        private readonly IUtilisateurService _utilisateurService;  
        private bool _deconnexionConfirmee = false;

        public ProfilUtilisateur(
            IServiceProvider serviceProvider,
            IAuthentificationService authService,
            IUtilisateurService utilisateurService
            )  
        {
            InitializeComponent();
            this.Text = "VisionFlix - Profil Utilisateur";

            _serviceProvider = serviceProvider;
            _authService = authService;
            _utilisateurService = utilisateurService;


            this.Load += ProfilUtilisateur_Load; 
            btnModifierProfil.Click += BtnModifierProfil_Click;
            btnGererAbonnement.Click += BtnGererAbonnement_Click;
            btnDeconnexion.Click += BtnDeconnexion_Click;
        }

        private async void ProfilUtilisateur_Load(object? sender, EventArgs e)
        {
            try
            {
                // Récupère l'utilisateur connecté
                if (_authService.CurrentUser != null)
                {
                    // Recharge l'utilisateur depuis la BD pour avoir les données à jour
                    _user = await _utilisateurService.GetUtilisateurByIdAsync(
                        _authService.CurrentUser.Id);

                    if (_user != null)
                    {
                        LoadUserData();
                        ConfigurerBoutonGestion();
                        ConfigurerAffichageSelonRole();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Impossible de charger les informations de l'utilisateur.",
                            "Erreur",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Aucun utilisateur connecté.",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors du chargement du profil:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ConfigurerBoutonGestion()
        {
            if (_user == null) return;

            if (_user.EstAdministrateur)
            {
                btnGererAbonnement.Text = "Gérer (Admin)";
                btnGererAbonnement.BackColor = Color.FromArgb(220, 53, 69);
            }
            else
            {
                btnGererAbonnement.Text = "Gérer l'abonnement";
                btnGererAbonnement.BackColor = Color.FromArgb(255, 193, 7);
            }
        }

        private void ConfigurerAffichageSelonRole()
        {
            if (_user == null) return;

            if (_user.EstAdministrateur)
            {
                lblSolde.Visible = false;
                lblSoldeValue.Visible = false;
                lblAbonnement.Visible = false;
                lblAbonnementValue.Visible = false;

                System.Diagnostics.Debug.WriteLine("Profil Admin: Solde et Abonnement masqués");
            }
            else
            {
                lblSolde.Visible = true;
                lblSoldeValue.Visible = true;
                lblAbonnement.Visible = true;
                lblAbonnementValue.Visible = true;

                System.Diagnostics.Debug.WriteLine("Profil Utilisateur: Solde et Abonnement affichés");
            }
        }

        private void LoadUserData()
        {
            if (_user == null) return;

            lblNomValue.Text = $"{_user.Prenom} {_user.Nom}";
            lblEmailValue.Text = _user.Email;

            if (_user.EstAdministrateur)
            {
                System.Diagnostics.Debug.WriteLine("LoadUserData: Admin détecté");
            }
            else
            {
                lblSoldeValue.Text = $"{_user.Solde:F2} $";
                lblAbonnementValue.Text = _user.EstAbonne ? _user.PlanActuel : "Aucun";
            }
        }

        private void BtnModifierProfil_Click(object? sender, EventArgs e)
        {
            try
            {
                var formulaireUtilisateur = _serviceProvider.GetRequiredService<FormulaireUtilisateur>();

                if (formulaireUtilisateur.ShowDialog() == DialogResult.OK)
                {
                    // Recharge l'utilisateur après modification
                    ProfilUtilisateur_Load(null, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'ouverture du formulaire:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void BtnGererAbonnement_Click(object? sender, EventArgs e)
        {
            if (_user == null) return;

            if (_user.EstAdministrateur)
            {
                OuvrirPanneauAdmin();
            }
            else
            {
                try
                {
                    Abonnement abonnementForm = _serviceProvider.GetRequiredService<Abonnement>();

                    if (abonnementForm.ShowDialog() == DialogResult.OK)
                    {
                        // Recharge l'utilisateur après modification
                        ProfilUtilisateur_Load(null, EventArgs.Empty);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Erreur lors de l'ouverture de la gestion d'abonnement:\n{ex.Message}",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        /// <summary>
        /// Gère la déconnexion de l'utilisateur
        /// Retourne DialogResult.Abort pour signaler une déconnexion
        /// </summary>
        private void BtnDeconnexion_Click(object? sender, EventArgs e)
        {
            try
            {
                // Demander confirmation à l'utilisateur
                var confirmation = MessageBox.Show(
                    "Voulez-vous vraiment vous déconnecter?",
                    "Confirmation de déconnexion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmation == DialogResult.Yes)
                {
                    // Marquer que la déconnexion a été confirmée
                    _deconnexionConfirmee = true;

                    // Déconnecter l'utilisateur (nettoyer la session)
                    _authService.Deconnecter();
                    System.Diagnostics.Debug.WriteLine("✅ Utilisateur déconnecté");

                    // Signaler à la fenêtre parente (Accueil) qu'il y a eu déconnexion
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de la déconnexion:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                System.Diagnostics.Debug.WriteLine($"❌ Erreur déconnexion: {ex.Message}\n{ex.StackTrace}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Si la déconnexion a déjà été confirmée, ne pas redemander
            if (_deconnexionConfirmee)
            {
                base.OnFormClosing(e);
                return;
            }

            // Sinon, comportement normal de fermeture
            base.OnFormClosing(e);
        }

        private void OuvrirPanneauAdmin()
        {
            try
            {
                PanneauAdmin panneauAdmin = _serviceProvider.GetRequiredService<PanneauAdmin>();
                panneauAdmin.ShowDialog();

                System.Diagnostics.Debug.WriteLine("Panneau Admin ouvert avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'ouverture du panneau administrateur:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                System.Diagnostics.Debug.WriteLine($"Erreur Panneau Admin: {ex.Message}");
            }
        }
    }
}

