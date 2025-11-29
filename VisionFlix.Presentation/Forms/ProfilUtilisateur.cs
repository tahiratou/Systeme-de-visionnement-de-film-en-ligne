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

            btnModifierProfil.Click += BtnModifierProfil_Click;
            btnGererAbonnement.Click += BtnGererAbonnement_Click;
            btnFermer.Click += BtnFermer_Click;

            ConfigurerBoutonGestion();

            ConfigurerAffichageSelonRole();
        }

        
        private void ConfigurerBoutonGestion()
        {
            if (_user.EstAdministrateur)
            {
                btnGererAbonnement.Text = "Gérer (Admin)";
                btnGererAbonnement.BackColor = Color.FromArgb(255, 193, 7); // Jaune
            }
            else
            {
                btnGererAbonnement.Text = "Gérer l'abonnement";
                btnGererAbonnement.BackColor = Color.FromArgb(255, 193, 7); // Jaune
            }
        }

       
        private void ConfigurerAffichageSelonRole()
        {
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

                System.Diagnostics.Debug.WriteLine(" Profil Utilisateur: Solde et Abonnement affichés");
            }
        }

        private void BtnModifierProfil_Click(object? sender, EventArgs e)
        {
            FormulaireUtilisateur formulaireUtilisateur = _serviceProvider.GetRequiredService<FormulaireUtilisateur>();

            if (formulaireUtilisateur.ShowDialog() == DialogResult.OK)
            {
                LoadUserData(); 
            }
        }

        private void BtnGererAbonnement_Click(object? sender, EventArgs e)
        {
            if (_user.EstAdministrateur)
            {
                OuvrirPanneauAdmin();
            }
            else
            {
                Abonnement abonnementForm = _serviceProvider.GetRequiredService<Abonnement>();
                if (abonnementForm.ShowDialog() == DialogResult.OK)
                {
                    LoadUserData();
                }
            }
        }

        
        private void OuvrirPanneauAdmin()
        {
            try
            {
                PanneauAdmin panneauAdmin = _serviceProvider.GetRequiredService<PanneauAdmin>();

                panneauAdmin.ShowDialog();

                System.Diagnostics.Debug.WriteLine(" Panneau Admin ouvert avec succès");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erreur lors de l'ouverture du panneau administrateur:\n{ex.Message}",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                System.Diagnostics.Debug.WriteLine($" Erreur Panneau Admin: {ex.Message}");
            }
        }

        private void LoadUserData()
        {
            lblNomValue.Text = $"{_user.Prenom} {_user.Nom}";
            lblEmailValue.Text = _user.Email;

            if (_user.EstAdministrateur)
            {
                System.Diagnostics.Debug.WriteLine(" LoadUserData: Admin détecté, infos financières masquées");
            }
            else
            {
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