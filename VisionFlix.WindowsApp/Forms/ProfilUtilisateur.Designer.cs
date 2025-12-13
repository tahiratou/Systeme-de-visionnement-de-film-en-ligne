namespace VisionFlix.WindowsApp.Forms
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
        private System.Windows.Forms.Button btnDeconnexion;  // ✅ AJOUT

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
            btnDeconnexion = new Button();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.Location = new Point(30, 25);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(154, 37);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Mon Profil";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNom.Location = new Point(30, 100);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(125, 23);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom complet:";
            // 
            // lblNomValue
            // 
            lblNomValue.AutoSize = true;
            lblNomValue.Location = new Point(248, 103);
            lblNomValue.Name = "lblNomValue";
            lblNomValue.Size = new Size(93, 20);
            lblNomValue.TabIndex = 2;
            lblNomValue.Text = "John Dupont";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(30, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblEmailValue
            // 
            lblEmailValue.AutoSize = true;
            lblEmailValue.Location = new Point(248, 143);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(121, 20);
            lblEmailValue.TabIndex = 4;
            lblEmailValue.Text = "john@email.com";
            // 
            // lblSolde
            // 
            lblSolde.AutoSize = true;
            lblSolde.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSolde.Location = new Point(30, 180);
            lblSolde.Name = "lblSolde";
            lblSolde.Size = new Size(152, 23);
            lblSolde.TabIndex = 5;
            lblSolde.Text = "Solde du compte:";
            // 
            // lblSoldeValue
            // 
            lblSoldeValue.AutoSize = true;
            lblSoldeValue.Location = new Point(249, 183);
            lblSoldeValue.Name = "lblSoldeValue";
            lblSoldeValue.Size = new Size(64, 20);
            lblSoldeValue.TabIndex = 6;
            lblSoldeValue.Text = "125.50 $";
            // 
            // lblAbonnement
            // 
            lblAbonnement.AutoSize = true;
            lblAbonnement.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAbonnement.Location = new Point(30, 220);
            lblAbonnement.Name = "lblAbonnement";
            lblAbonnement.Size = new Size(172, 23);
            lblAbonnement.TabIndex = 7;
            lblAbonnement.Text = "Abonnement actuel:";
            // 
            // lblAbonnementValue
            // 
            lblAbonnementValue.AutoSize = true;
            lblAbonnementValue.Location = new Point(249, 223);
            lblAbonnementValue.Name = "lblAbonnementValue";
            lblAbonnementValue.Size = new Size(74, 20);
            lblAbonnementValue.TabIndex = 8;
            lblAbonnementValue.Text = "PREMIUM";
            // 
            // btnGererAbonnement
            // 
            btnGererAbonnement.BackColor = Color.FromArgb(255, 193, 7);
            btnGererAbonnement.Cursor = Cursors.Hand;
            btnGererAbonnement.FlatStyle = FlatStyle.Flat;
            btnGererAbonnement.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGererAbonnement.ForeColor = Color.Black;
            btnGererAbonnement.Location = new Point(30, 303);
            btnGererAbonnement.Name = "btnGererAbonnement";
            btnGererAbonnement.Size = new Size(240, 40);
            btnGererAbonnement.TabIndex = 9;
            btnGererAbonnement.Text = "Gérer l'abonnement";
            btnGererAbonnement.UseVisualStyleBackColor = false;
            // 
            // btnModifierProfil
            // 
            btnModifierProfil.BackColor = Color.FromArgb(0, 120, 215);
            btnModifierProfil.Cursor = Cursors.Hand;
            btnModifierProfil.FlatAppearance.BorderSize = 0;
            btnModifierProfil.FlatStyle = FlatStyle.Flat;
            btnModifierProfil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModifierProfil.ForeColor = Color.White;
            btnModifierProfil.Location = new Point(288, 303);
            btnModifierProfil.Name = "btnModifierProfil";
            btnModifierProfil.Size = new Size(240, 40);
            btnModifierProfil.TabIndex = 10;
            btnModifierProfil.Text = "Modifier le profil";
            btnModifierProfil.UseVisualStyleBackColor = false;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.BackColor = Color.FromArgb(229, 9, 20);
            btnDeconnexion.Cursor = Cursors.Hand;
            btnDeconnexion.FlatAppearance.BorderSize = 0;
            btnDeconnexion.FlatStyle = FlatStyle.Flat;
            btnDeconnexion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeconnexion.ForeColor = Color.White;
            btnDeconnexion.Location = new Point(379, 30);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(149, 40);
            btnDeconnexion.TabIndex = 11;
            btnDeconnexion.Text = "Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += BtnDeconnexion_Click;
            // 
            // ProfilUtilisateur
            // 
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(550, 421);
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
            Controls.Add(btnDeconnexion);
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