using Microsoft.Extensions.DependencyInjection;
using System;
using VisionFlix.Application.Interfaces;
using VisionFlix.Domain.Entities;

namespace VisionFlix.Presentation.Forms
{
    public partial class ProfilUtilisateur : Form
    {
        private readonly Utilisateur _user;
        private readonly IServiceProvider _serviceProvider;
        private readonly IAuthentificationService _authService;
        public ProfilUtilisateur(
            Utilisateur user,
            IServiceProvider serviceProvider,
            IAuthentificationService authService)  
        {
            InitializeComponent();
            this.Text = "VisionFlix - Profil Utilisateur";

            _user = user;
            _serviceProvider = serviceProvider;
            _authService = authService;  

            LoadUserData();
            ConfigurerBoutonGestion();
            ConfigurerAffichageSelonRole();

            btnModifierProfil.Click += BtnModifierProfil_Click;
            btnGererAbonnement.Click += BtnGererAbonnement_Click;
            btnDeconnexion.Click += BtnDeconnexion_Click;  
        }

        private void ConfigurerBoutonGestion()
        {
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
                    LoadUserData();
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
                        LoadUserData();
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

       
        private void BtnDeconnexion_Click(object? sender, EventArgs e)
        {
            try
            {
                var confirmation = MessageBox.Show(
                    "Voulez-vous vraiment vous déconnecter?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmation == DialogResult.Yes)
                {
                    _authService.Deconnecter();
                    this.Close();
                    foreach (Form form in System.Windows.Forms.Application.OpenForms.Cast<Form>().ToList())
                    {
                        if (form.Name != "Connexion" )
                        {
                            form.Close();
                        }
                    }

                    var connexionForm = _serviceProvider.GetRequiredService<Connexion>();
                    connexionForm.ShowDialog();

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

                System.Diagnostics.Debug.WriteLine($"Erreur déconnexion: {ex.Message}");
            }
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

        private void BtnFermer_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}