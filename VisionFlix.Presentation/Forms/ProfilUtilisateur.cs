using VisionFlix.Domain.Entities;
using VisionFlix.Presentation.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace VisionFlix.Presentation.Forms
{
    public partial class ProfilUtilisateur : Form
    {
        private readonly Utilisateur _user;
        private readonly IServiceProvider _serviceProvider;

        public ProfilUtilisateur(Utilisateur user, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Profil Utilisateur";
            _user = user;
            _serviceProvider = serviceProvider;

            LoadUserData();

            // Événements
            btnModifierProfil.Click += BtnModifierProfil_Click;
            btnGererAbonnement.Click += BtnGererAbonnement_Click;
            btnFermer.Click += BtnFermer_Click;

            // ✅ Gérer la visibilité du bouton selon le rôle
            ConfigurerBoutonGestion();

            // ✅ Gérer l'affichage selon le rôle (admin vs user)
            ConfigurerAffichageSelonRole();
        }

        /// <summary>
        /// Configure le bouton "Gérer" selon le rôle de l'utilisateur
        /// </summary>
        private void ConfigurerBoutonGestion()
        {
            if (_user.EstAdministrateur)
            {
                // Pour les admins, le bouton devient "Gérer (Admin)"
                btnGererAbonnement.Text = "Gérer (Admin)";
                btnGererAbonnement.BackColor = Color.FromArgb(220, 53, 69); // Rouge admin
            }
            else
            {
                // Pour les utilisateurs normaux, "Gérer l'abonnement"
                btnGererAbonnement.Text = "Gérer l'abonnement";
                btnGererAbonnement.BackColor = Color.FromArgb(255, 193, 7); // Jaune
            }
        }

        /// <summary>
        /// Configure l'affichage des informations selon le rôle
        /// </summary>
        private void ConfigurerAffichageSelonRole()
        {
            if (_user.EstAdministrateur)
            {
                // ✅ POUR LES ADMINS: Cacher Solde et Abonnement

                // Cacher le solde
                lblSolde.Visible = false;
                lblSoldeValue.Visible = false;

                // Cacher l'abonnement
                lblAbonnement.Visible = false;
                lblAbonnementValue.Visible = false;

                System.Diagnostics.Debug.WriteLine("✅ Profil Admin: Solde et Abonnement masqués");
            }
            else
            {
                // ✅ POUR LES UTILISATEURS: Afficher Solde et Abonnement

                lblSolde.Visible = true;
                lblSoldeValue.Visible = true;
                lblAbonnement.Visible = true;
                lblAbonnementValue.Visible = true;

                System.Diagnostics.Debug.WriteLine("✅ Profil Utilisateur: Solde et Abonnement affichés");
            }
        }

        private void BtnModifierProfil_Click(object? sender, EventArgs e)
        {
            // ✅ Utiliser l'injection de dépendances pour créer FormulaireUtilisateur
            FormulaireUtilisateur formulaireUtilisateur = _serviceProvider.GetRequiredService<FormulaireUtilisateur>();

            if (formulaireUtilisateur.ShowDialog() == DialogResult.OK)
            {
                LoadUserData(); // Rafraîchir les données après mise à jour
            }
        }

        private void BtnGererAbonnement_Click(object? sender, EventArgs e)
        {
            // ✅ SI ADMIN → Ouvrir le Panneau Admin
            if (_user.EstAdministrateur)
            {
                OuvrirPanneauAdmin();
            }
            else
            {
                // ✅ SI UTILISATEUR NORMAL → Ouvrir l'abonnement
                Abonnement abonnementForm = _serviceProvider.GetRequiredService<Abonnement>();
                if (abonnementForm.ShowDialog() == DialogResult.OK)
                {
                    // Rafraîchir les données après modification
                    LoadUserData();
                }
            }
        }

        /// <summary>
        /// Ouvre le panneau administrateur (seulement pour les admins)
        /// </summary>
        private void OuvrirPanneauAdmin()
        {
            try
            {
                // Créer le panneau admin avec injection de dépendances
                PanneauAdmin panneauAdmin = _serviceProvider.GetRequiredService<PanneauAdmin>();

                // Ouvrir en modal
                panneauAdmin.ShowDialog();

                System.Diagnostics.Debug.WriteLine("✅ Panneau Admin ouvert avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'ouverture du panneau administrateur:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                System.Diagnostics.Debug.WriteLine($"❌ Erreur Panneau Admin: {ex.Message}");
            }
        }

        private void LoadUserData()
        {
            lblNomValue.Text = $"{_user.Prenom} {_user.Nom}";
            lblEmailValue.Text = _user.Email;

            if (_user.EstAdministrateur)
            {
                // ✅ ADMIN: Ne pas afficher solde ni abonnement
                // Les labels sont déjà cachés dans ConfigurerAffichageSelonRole()
                System.Diagnostics.Debug.WriteLine("✅ LoadUserData: Admin détecté, infos financières masquées");
            }
            else
            {
                // ✅ UTILISATEUR NORMAL: Afficher solde et abonnement
                lblSoldeValue.Text = $"{_user.Solde:F2} $";
                lblAbonnementValue.Text = _user.EstAbonne ? _user.PlanActuel : "Aucun";
            }
        }

        private void BtnFermer_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}