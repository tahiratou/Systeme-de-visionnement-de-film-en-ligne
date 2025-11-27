using VisionFlix.Application.Interfaces;
using VisionFlix.Domain.Entities;

namespace VisionFlix.Presentation.Forms
{
    public partial class Inscription : Form
    {
        private readonly IUtilisateurService _utilisateurService;

        // CONSTRUCTEUR AVEC INJECTION DE DÉPENDANCES
        public Inscription(IUtilisateurService utilisateurService)
        {
            InitializeComponent();
            this.Text = "VisionFlix - Inscription";
            
            _utilisateurService = utilisateurService;
        }

        // GARDEZ VOTRE CODE DESIGNER.CS TEL QUEL
        // Modifiez uniquement la logique du bouton:

        private async void btnLogin_Click(object? sender, EventArgs e)
        {
            // Récupérer les valeurs des TextBox
            // Adaptez les noms selon votre Designer.cs
            string nom = textBox2.Text.Trim();           // ou selon votre nom de contrôle
            string prenom = textBox3.Text.Trim();        // ou selon votre nom de contrôle
            string email = textBox4.Text.Trim();         // ou selon votre nom de contrôle
            string telephone = textBox1.Text.Trim();     // ou selon votre nom de contrôle
            string adresse = textBox5.Text.Trim();       // ou selon votre nom de contrôle
            string motDePasse = textBox6.Text;           // ou selon votre nom de contrôle
            string confirmation = textBox7.Text;         // ou selon votre nom de contrôle

            // Validation
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (motDePasse != confirmation)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Veuillez entrer un email valide.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Vérifier si l'email existe déjà
                if (await _utilisateurService.EmailExistsAsync(email))
                {
                    MessageBox.Show("Un compte avec cet email existe déjà.", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Créer le nouvel utilisateur
                var nouvelUtilisateur = new Utilisateur
                {
                    Nom = nom,
                    Prenom = prenom,
                    Email = email,
                    Telephone = telephone,
                    Adresse = adresse,
                    MotDePasse = motDePasse, // En production: hasher le mot de passe!
                    Solde = 0,
                    EstAdministrateur = false,
                    EstAbonne = false,
                    DateInscription = DateTime.Now
                };

                await _utilisateurService.CreateUtilisateurAsync(nouvelUtilisateur);

                MessageBox.Show("Inscription réussie! Vous pouvez maintenant vous connecter.", 
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'inscription : {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

/* 
 * INSTRUCTIONS:
 * 1. GARDEZ votre fichier Inscription.Designer.cs TEL QUEL
 * 2. Remplacez le contenu de Inscription.cs par ce code
 * 3. Vérifiez les noms de vos TextBox dans Designer.cs et ajustez:
 *    - nom → nom du contrôle pour le nom
 *    - textBox2 → nom du contrôle pour le prénom
 *    - etc.
 */
