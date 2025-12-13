namespace VisionFlix.WindowsApp.Forms
{
    partial class FormulaireUtilisateur
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitre = new Label();
            lblNom = new Label();
            txtNom = new TextBox();
            lblPrenom = new Label();
            txtPrenom = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            chkModifierMotDePasse = new CheckBox();
            lblMotDePasseActuel = new Label();
            txtMotDePasseActuel = new TextBox();
            lblNouveauMotDePasse = new Label();
            txtNouveauMotDePasse = new TextBox();
            lblConfirmerMotDePasse = new Label();
            txtConfirmerMotDePasse = new TextBox();
            btnSauvegarder = new Button();
            btnAnnuler = new Button();
            panelFormulaire = new Panel();
            panelFormulaire.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitre.Location = new Point(29, 33);
            lblTitre.Margin = new Padding(4, 0, 4, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(278, 45);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Modifier le profil";
            lblTitre.Click += lblTitre_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI", 10F);
            lblNom.Location = new Point(29, 33);
            lblNom.Margin = new Padding(4, 0, 4, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(60, 28);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom:";
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Segoe UI", 10F);
            txtNom.Location = new Point(143, 33);
            txtNom.Margin = new Padding(4, 5, 4, 5);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(484, 34);
            txtNom.TabIndex = 1;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new Font("Segoe UI", 10F);
            lblPrenom.Location = new Point(29, 106);
            lblPrenom.Margin = new Padding(4, 0, 4, 0);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(84, 28);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Prénom:";
            // 
            // txtPrenom
            // 
            txtPrenom.Font = new Font("Segoe UI", 10F);
            txtPrenom.Location = new Point(143, 100);
            txtPrenom.Margin = new Padding(4, 5, 4, 5);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(484, 34);
            txtPrenom.TabIndex = 3;
            txtPrenom.TextChanged += txtPrenom_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(29, 186);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 28);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(143, 180);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(484, 34);
            txtEmail.TabIndex = 5;
            // 
            // chkModifierMotDePasse
            // 
            chkModifierMotDePasse.AutoSize = true;
            chkModifierMotDePasse.Font = new Font("Segoe UI", 10F);
            chkModifierMotDePasse.Location = new Point(29, 252);
            chkModifierMotDePasse.Margin = new Padding(4, 5, 4, 5);
            chkModifierMotDePasse.Name = "chkModifierMotDePasse";
            chkModifierMotDePasse.Size = new Size(254, 32);
            chkModifierMotDePasse.TabIndex = 6;
            chkModifierMotDePasse.Text = "Modifier le mot de passe";
            chkModifierMotDePasse.UseVisualStyleBackColor = true;
            chkModifierMotDePasse.CheckedChanged += ChkModifierMotDePasse_CheckedChanged;
            // 
            // lblMotDePasseActuel
            // 
            lblMotDePasseActuel.AutoSize = true;
            lblMotDePasseActuel.Font = new Font("Segoe UI", 10F);
            lblMotDePasseActuel.Location = new Point(29, 305);
            lblMotDePasseActuel.Margin = new Padding(4, 0, 4, 0);
            lblMotDePasseActuel.Name = "lblMotDePasseActuel";
            lblMotDePasseActuel.Size = new Size(190, 28);
            lblMotDePasseActuel.TabIndex = 7;
            lblMotDePasseActuel.Text = "Mot de passe actuel:";
            lblMotDePasseActuel.Visible = false;
            // 
            // txtMotDePasseActuel
            // 
            txtMotDePasseActuel.Font = new Font("Segoe UI", 10F);
            txtMotDePasseActuel.Location = new Point(295, 302);
            txtMotDePasseActuel.Margin = new Padding(4, 5, 4, 5);
            txtMotDePasseActuel.Name = "txtMotDePasseActuel";
            txtMotDePasseActuel.PasswordChar = '•';
            txtMotDePasseActuel.Size = new Size(332, 34);
            txtMotDePasseActuel.TabIndex = 8;
            txtMotDePasseActuel.Visible = false;
            // 
            // lblNouveauMotDePasse
            // 
            lblNouveauMotDePasse.AutoSize = true;
            lblNouveauMotDePasse.Font = new Font("Segoe UI", 10F);
            lblNouveauMotDePasse.Location = new Point(29, 384);
            lblNouveauMotDePasse.Margin = new Padding(4, 0, 4, 0);
            lblNouveauMotDePasse.Name = "lblNouveauMotDePasse";
            lblNouveauMotDePasse.Size = new Size(258, 28);
            lblNouveauMotDePasse.TabIndex = 9;
            lblNouveauMotDePasse.Text = "Nouveau mot de passe (6+):";
            lblNouveauMotDePasse.Visible = false;
            lblNouveauMotDePasse.Click += lblNouveauMotDePasse_Click;
            // 
            // txtNouveauMotDePasse
            // 
            txtNouveauMotDePasse.Font = new Font("Segoe UI", 10F);
            txtNouveauMotDePasse.Location = new Point(295, 381);
            txtNouveauMotDePasse.Margin = new Padding(4, 5, 4, 5);
            txtNouveauMotDePasse.Name = "txtNouveauMotDePasse";
            txtNouveauMotDePasse.PasswordChar = '•';
            txtNouveauMotDePasse.Size = new Size(332, 34);
            txtNouveauMotDePasse.TabIndex = 10;
            txtNouveauMotDePasse.Visible = false;
            txtNouveauMotDePasse.TextChanged += txtNouveauMotDePasse_TextChanged;
            // 
            // lblConfirmerMotDePasse
            // 
            lblConfirmerMotDePasse.AutoSize = true;
            lblConfirmerMotDePasse.Font = new Font("Segoe UI", 10F);
            lblConfirmerMotDePasse.Location = new Point(29, 469);
            lblConfirmerMotDePasse.Margin = new Padding(4, 0, 4, 0);
            lblConfirmerMotDePasse.Name = "lblConfirmerMotDePasse";
            lblConfirmerMotDePasse.Size = new Size(224, 28);
            lblConfirmerMotDePasse.TabIndex = 11;
            lblConfirmerMotDePasse.Text = "Confirmer mot de passe:";
            lblConfirmerMotDePasse.Visible = false;
            // 
            // txtConfirmerMotDePasse
            // 
            txtConfirmerMotDePasse.Font = new Font("Segoe UI", 10F);
            txtConfirmerMotDePasse.Location = new Point(295, 463);
            txtConfirmerMotDePasse.Margin = new Padding(4, 5, 4, 5);
            txtConfirmerMotDePasse.Name = "txtConfirmerMotDePasse";
            txtConfirmerMotDePasse.PasswordChar = '•';
            txtConfirmerMotDePasse.Size = new Size(332, 34);
            txtConfirmerMotDePasse.TabIndex = 12;
            txtConfirmerMotDePasse.Visible = false;
            // 
            // btnSauvegarder
            // 
            btnSauvegarder.BackColor = Color.FromArgb(229, 9, 20);
            btnSauvegarder.Cursor = Cursors.Hand;
            btnSauvegarder.FlatAppearance.BorderSize = 0;
            btnSauvegarder.FlatStyle = FlatStyle.Flat;
            btnSauvegarder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSauvegarder.ForeColor = Color.White;
            btnSauvegarder.Location = new Point(29, 707);
            btnSauvegarder.Margin = new Padding(4, 5, 4, 5);
            btnSauvegarder.Name = "btnSauvegarder";
            btnSauvegarder.Size = new Size(314, 75);
            btnSauvegarder.TabIndex = 2;
            btnSauvegarder.Text = "Sauvegarder";
            btnSauvegarder.UseVisualStyleBackColor = false;
            btnSauvegarder.Click += BtnSauvegarder_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.FromArgb(108, 117, 125);
            btnAnnuler.Cursor = Cursors.Hand;
            btnAnnuler.FlatAppearance.BorderSize = 0;
            btnAnnuler.FlatStyle = FlatStyle.Flat;
            btnAnnuler.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.Location = new Point(381, 707);
            btnAnnuler.Margin = new Padding(4, 5, 4, 5);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(314, 75);
            btnAnnuler.TabIndex = 3;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += BtnAnnuler_Click;
            // 
            // panelFormulaire
            // 
            panelFormulaire.BackColor = Color.FromArgb(20, 20, 20);
            panelFormulaire.Controls.Add(lblNom);
            panelFormulaire.Controls.Add(txtNom);
            panelFormulaire.Controls.Add(lblPrenom);
            panelFormulaire.Controls.Add(txtPrenom);
            panelFormulaire.Controls.Add(lblEmail);
            panelFormulaire.Controls.Add(txtEmail);
            panelFormulaire.Controls.Add(chkModifierMotDePasse);
            panelFormulaire.Controls.Add(lblMotDePasseActuel);
            panelFormulaire.Controls.Add(txtMotDePasseActuel);
            panelFormulaire.Controls.Add(lblNouveauMotDePasse);
            panelFormulaire.Controls.Add(txtNouveauMotDePasse);
            panelFormulaire.Controls.Add(lblConfirmerMotDePasse);
            panelFormulaire.Controls.Add(txtConfirmerMotDePasse);
            panelFormulaire.Location = new Point(13, 100);
            panelFormulaire.Margin = new Padding(4, 5, 4, 5);
            panelFormulaire.Name = "panelFormulaire";
            panelFormulaire.Size = new Size(682, 552);
            panelFormulaire.TabIndex = 1;
            // 
            // FormulaireUtilisateur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(730, 813);
            Controls.Add(btnAnnuler);
            Controls.Add(btnSauvegarder);
            Controls.Add(panelFormulaire);
            Controls.Add(lblTitre);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormulaireUtilisateur";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VisionFlix - Modifier le profil";
            panelFormulaire.ResumeLayout(false);
            panelFormulaire.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panelFormulaire;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkModifierMotDePasse;
        private System.Windows.Forms.Label lblMotDePasseActuel;
        private System.Windows.Forms.TextBox txtMotDePasseActuel;
        private System.Windows.Forms.Label lblNouveauMotDePasse;
        private System.Windows.Forms.TextBox txtNouveauMotDePasse;
        private System.Windows.Forms.Label lblConfirmerMotDePasse;
        private System.Windows.Forms.TextBox txtConfirmerMotDePasse;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnAnnuler;
    }
}