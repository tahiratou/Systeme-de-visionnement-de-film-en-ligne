namespace VisionFlix.Presentation.Forms
{
    partial class Inscription
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            label1 = new Label();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            txtEmail = new TextBox();
            txtTelephone = new TextBox();
            txtAdresse = new TextBox();
            txtNomUtilisateur = new TextBox();
            txtMotDePasse = new TextBox();
            txtConfirmation = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            SuspendLayout();

            
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(240, 50);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 0;
            label1.Text = "Inscription";
            label1.TextAlign = ContentAlignment.TopCenter;

            
            txtNom.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNom.Location = new Point(80, 125);
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = " Nom";
            txtNom.Size = new Size(200, 29);
            txtNom.TabIndex = 1;

            txtPrenom.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtPrenom.BorderStyle = BorderStyle.FixedSingle;
            txtPrenom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrenom.Location = new Point(80, 165);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.PlaceholderText = " Prénom";
            txtPrenom.Size = new Size(200, 29);
            txtPrenom.TabIndex = 2;

            
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(80, 205);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email";
            txtEmail.Size = new Size(200, 29);
            txtEmail.TabIndex = 3;

            
            txtTelephone.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtTelephone.BorderStyle = BorderStyle.FixedSingle;
            txtTelephone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelephone.Location = new Point(80, 245);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.PlaceholderText = " Téléphone (optionnel)";
            txtTelephone.Size = new Size(200, 29);
            txtTelephone.TabIndex = 4;

            
            txtAdresse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAdresse.BorderStyle = BorderStyle.FixedSingle;
            txtAdresse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAdresse.Location = new Point(344, 125);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.PlaceholderText = " Adresse (optionnel)";
            txtAdresse.Size = new Size(200, 29);
            txtAdresse.TabIndex = 5;

            
            txtNomUtilisateur.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtNomUtilisateur.BorderStyle = BorderStyle.FixedSingle;
            txtNomUtilisateur.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomUtilisateur.Location = new Point(344, 165);
            txtNomUtilisateur.Name = "txtNomUtilisateur";
            txtNomUtilisateur.PlaceholderText = " Nom d'utilisateur";
            txtNomUtilisateur.Size = new Size(200, 29);
            txtNomUtilisateur.TabIndex = 6;

            
            txtMotDePasse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMotDePasse.BorderStyle = BorderStyle.FixedSingle;
            txtMotDePasse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotDePasse.Location = new Point(344, 205);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.PasswordChar = '*';
            txtMotDePasse.PlaceholderText = " Mot de passe";
            txtMotDePasse.Size = new Size(200, 29);
            txtMotDePasse.TabIndex = 7;

            
            txtConfirmation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtConfirmation.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmation.Location = new Point(344, 245);
            txtConfirmation.Name = "txtConfirmation";
            txtConfirmation.PasswordChar = '*';
            txtConfirmation.PlaceholderText = " Confirmer le mot de passe";
            txtConfirmation.Size = new Size(200, 29);
            txtConfirmation.TabIndex = 8;

            
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(200, 50, 50);
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(212, 300);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 32);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "S'inscrire";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(225, 345);
            label2.Name = "label2";
            label2.Size = new Size(141, 13);
            label2.TabIndex = 10;
            label2.Text = "Vous avez déjà un compte ?";

            

            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel2.Location = new Point(372, 345);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(68, 13);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Se connecter";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;

            

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(624, 441);

            // Ajouter les contrôles dans l'ordre de tabulation
            Controls.Add(linkLabel2);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtConfirmation);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtNomUtilisateur);
            Controls.Add(txtAdresse);
            Controls.Add(txtTelephone);
            Controls.Add(txtEmail);
            Controls.Add(txtPrenom);
            Controls.Add(txtNom);
            Controls.Add(label1);

            Name = "Inscription";
            Text = "VisionFlix - Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNom;              
        private TextBox txtPrenom;           
        private TextBox txtEmail;            
        private TextBox txtTelephone;       
        private TextBox txtAdresse;          
        private TextBox txtNomUtilisateur;
        private TextBox txtMotDePasse;       
        private TextBox txtConfirmation;    
        private Button btnLogin;
        private Label label2;
        private LinkLabel linkLabel2;
    }
}