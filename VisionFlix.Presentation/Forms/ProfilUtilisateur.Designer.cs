namespace VisionFlix.Presentation.Forms
{
    partial class ProfilUtilisateur
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNomValue;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label lblSoldeValue;
        private System.Windows.Forms.Label lblAbonnement;
        private System.Windows.Forms.Label lblAbonnementValue;
        private System.Windows.Forms.Button btnGererAbonnement;
        private System.Windows.Forms.Button btnModifierProfil;
        private System.Windows.Forms.Button btnFermer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNomValue = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            this.lblSoldeValue = new System.Windows.Forms.Label();
            this.lblAbonnement = new System.Windows.Forms.Label();
            this.lblAbonnementValue = new System.Windows.Forms.Label();
            this.btnGererAbonnement = new System.Windows.Forms.Button();
            this.btnModifierProfil = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProfilUtilisateur
            // 
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.ForeColor = System.Drawing.Color.White;
            this.Text = "Profil Utilisateur";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Contrôles
            //
            // lblTitre
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.Location = new System.Drawing.Point(30, 30);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(180, 30);
            this.lblTitre.Text = "Mon Profil";

            // lblNom
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNom.Location = new System.Drawing.Point(30, 100);
            this.lblNom.Text = "Nom complet:";

            // lblNomValue
            this.lblNomValue.AutoSize = true;
            this.lblNomValue.Location = new System.Drawing.Point(200, 100);
            this.lblNomValue.Text = "John Dupont";

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(30, 140);
            this.lblEmail.Text = "Email:";

            // lblEmailValue
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Location = new System.Drawing.Point(200, 140);
            this.lblEmailValue.Text = "john@email.com";

            // lblSolde
            this.lblSolde.AutoSize = true;
            this.lblSolde.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSolde.Location = new System.Drawing.Point(30, 180);
            this.lblSolde.Text = "Solde du compte:";

            // lblSoldeValue
            this.lblSoldeValue.AutoSize = true;
            this.lblSoldeValue.Location = new System.Drawing.Point(200, 180);
            this.lblSoldeValue.Text = "125.50 $";

            // lblAbonnement
            this.lblAbonnement.AutoSize = true;
            this.lblAbonnement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAbonnement.Location = new System.Drawing.Point(30, 220);
            this.lblAbonnement.Text = "Abonnement actuel:";

            // lblAbonnementValue
            this.lblAbonnementValue.AutoSize = true;
            this.lblAbonnementValue.Location = new System.Drawing.Point(200, 220);
            this.lblAbonnementValue.Text = "PREMIUM";

            // btnGererAbonnement
            this.btnGererAbonnement.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnGererAbonnement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGererAbonnement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGererAbonnement.ForeColor = System.Drawing.Color.Black;
            this.btnGererAbonnement.Location = new System.Drawing.Point(30, 300);
            this.btnGererAbonnement.Size = new System.Drawing.Size(180, 35);
            this.btnGererAbonnement.Text = "Gérer l'abonnement";
            this.btnGererAbonnement.UseVisualStyleBackColor = false;
            this.btnGererAbonnement.Click += new System.EventHandler(this.BtnGererAbonnement_Click);

            // btnModifierProfil
            this.btnModifierProfil.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnModifierProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierProfil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModifierProfil.ForeColor = System.Drawing.Color.White;
            this.btnModifierProfil.Location = new System.Drawing.Point(30, 345); // 300 + 35 + 10 (spacing)
            this.btnModifierProfil.Size = new System.Drawing.Size(180, 35);
            this.btnModifierProfil.Text = "Modifier le profil";
            this.btnModifierProfil.UseVisualStyleBackColor = false;
            // this.btnModifierProfil.Click += new System.EventHandler(this.BtnModifierProfil_Click); // Event handler will be added in .cs file

            // btnFermer
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(400, 390);
            this.btnFermer.Size = new System.Drawing.Size(120, 35);
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);

            // Ajouter les contrôles au formulaire
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblNomValue);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblEmailValue);
            this.Controls.Add(this.lblSolde);
            this.Controls.Add(this.lblSoldeValue);
            this.Controls.Add(this.lblAbonnement);
            this.Controls.Add(this.lblAbonnementValue);
            this.Controls.Add(this.btnGererAbonnement);
            this.Controls.Add(this.btnModifierProfil);
            this.Controls.Add(this.btnFermer);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}