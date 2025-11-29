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
            lblTitre = new Label();
            lblNom = new Label();
            lblNomValue = new Label();
            lblEmail = new Label();
            lblEmailValue = new Label();
            lblSolde = new Label();
            lblSoldeValue = new Label();
            lblAbonnement = new Label();
            lblAbonnementValue = new Label();
            btnGererAbonnement = new Button();
            btnModifierProfil = new Button();
            btnFermer = new Button();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.Location = new Point(30, 30);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(182, 45);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Mon Profil";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNom.Location = new Point(30, 100);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(146, 28);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom complet:";
            // 
            // lblNomValue
            // 
            lblNomValue.AutoSize = true;
            lblNomValue.Location = new Point(200, 100);
            lblNomValue.Name = "lblNomValue";
            lblNomValue.Size = new Size(115, 25);
            lblNomValue.TabIndex = 2;
            lblNomValue.Text = "John Dupont";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(30, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(69, 28);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblEmailValue
            // 
            lblEmailValue.AutoSize = true;
            lblEmailValue.Location = new Point(200, 140);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(145, 25);
            lblEmailValue.TabIndex = 4;
            lblEmailValue.Text = "john@email.com";
            // 
            // lblSolde
            // 
            lblSolde.AutoSize = true;
            lblSolde.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSolde.Location = new Point(30, 180);
            lblSolde.Name = "lblSolde";
            lblSolde.Size = new Size(176, 28);
            lblSolde.TabIndex = 5;
            lblSolde.Text = "Solde du compte:";
            // 
            // lblSoldeValue
            // 
            lblSoldeValue.AutoSize = true;
            lblSoldeValue.Location = new Point(200, 180);
            lblSoldeValue.Name = "lblSoldeValue";
            lblSoldeValue.Size = new Size(81, 25);
            lblSoldeValue.TabIndex = 6;
            lblSoldeValue.Text = "125.50 $";
            // 
            // lblAbonnement
            // 
            lblAbonnement.AutoSize = true;
            lblAbonnement.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAbonnement.Location = new Point(30, 220);
            lblAbonnement.Name = "lblAbonnement";
            lblAbonnement.Size = new Size(203, 28);
            lblAbonnement.TabIndex = 7;
            lblAbonnement.Text = "Abonnement actuel:";
            // 
            // lblAbonnementValue
            // 
            lblAbonnementValue.AutoSize = true;
            lblAbonnementValue.Location = new Point(239, 223);
            lblAbonnementValue.Name = "lblAbonnementValue";
            lblAbonnementValue.Size = new Size(91, 25);
            lblAbonnementValue.TabIndex = 8;
            lblAbonnementValue.Text = "PREMIUM";
            // 
            // btnGererAbonnement
            // 
            btnGererAbonnement.BackColor = Color.FromArgb(255, 193, 7);
            btnGererAbonnement.FlatStyle = FlatStyle.Flat;
            btnGererAbonnement.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGererAbonnement.ForeColor = Color.Black;
            btnGererAbonnement.Location = new Point(30, 300);
            btnGererAbonnement.Name = "btnGererAbonnement";
            btnGererAbonnement.Size = new Size(236, 35);
            btnGererAbonnement.TabIndex = 9;
            btnGererAbonnement.Text = "Gérer l'abonnement";
            btnGererAbonnement.UseVisualStyleBackColor = false;
            btnGererAbonnement.Click += BtnGererAbonnement_Click;
            // 
            // btnModifierProfil
            // 
            btnModifierProfil.BackColor = Color.FromArgb(0, 120, 215);
            btnModifierProfil.FlatStyle = FlatStyle.Flat;
            btnModifierProfil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModifierProfil.ForeColor = Color.White;
            btnModifierProfil.Location = new Point(30, 345);
            btnModifierProfil.Name = "btnModifierProfil";
            btnModifierProfil.Size = new Size(236, 35);
            btnModifierProfil.TabIndex = 10;
            btnModifierProfil.Text = "Modifier le profil";
            btnModifierProfil.UseVisualStyleBackColor = false;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.FromArgb(60, 60, 60);
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Segoe UI", 10F);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(400, 390);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(120, 35);
            btnFermer.TabIndex = 11;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += BtnFermer_Click;
            // 
            // ProfilUtilisateur
            // 
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(550, 450);
            Controls.Add(lblTitre);
            Controls.Add(lblNom);
            Controls.Add(lblNomValue);
            Controls.Add(lblEmail);
            Controls.Add(lblEmailValue);
            Controls.Add(lblSolde);
            Controls.Add(lblSoldeValue);
            Controls.Add(lblAbonnement);
            Controls.Add(lblAbonnementValue);
            Controls.Add(btnGererAbonnement);
            Controls.Add(btnModifierProfil);
            Controls.Add(btnFermer);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProfilUtilisateur";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Profil Utilisateur";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}