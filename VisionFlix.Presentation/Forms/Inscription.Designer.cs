namespace VisionFlix.Presentation.Forms
{
    partial class Inscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

            // ✅ RENOMMAGE: nom → txtNomUtilisateur
            txtNomUtilisateur = new TextBox();
            // ✅ RENOMMAGE: textBox2 → txtNom
            txtNom = new TextBox();
            // ✅ RENOMMAGE: textBox3 → txtPrenom
            txtPrenom = new TextBox();
            // ✅ RENOMMAGE: textBox4 → txtEmail
            txtEmail = new TextBox();
            // ✅ RENOMMAGE: textBox1 → txtTelephone
            txtTelephone = new TextBox();
            // ✅ RENOMMAGE: textBox5 → txtAdresse
            txtAdresse = new TextBox();
            // ✅ RENOMMAGE: textBox6 → txtMotDePasse
            txtMotDePasse = new TextBox();
            // ✅ RENOMMAGE: textBox7 → txtConfirmation
            txtConfirmation = new TextBox();

            btnLogin = new Button();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            SuspendLayout();

            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Name = "label1";

            // 
            // txtNomUtilisateur (ancien "nom")
            // 
            resources.ApplyResources(txtNomUtilisateur, "nom");  // ✅ Utilise les ressources de "nom" pour garder la position
            txtNomUtilisateur.Name = "txtNomUtilisateur";
            txtNomUtilisateur.PlaceholderText = " Nom d'utilisateur";

            // 
            // txtNom (ancien "textBox2")
            // 
            resources.ApplyResources(txtNom, "textBox2");  // ✅ Utilise les ressources de "textBox2"
            txtNom.Name = "txtNom";
            txtNom.PlaceholderText = " Nom";

            // 
            // txtPrenom (ancien "textBox3")
            // 
            resources.ApplyResources(txtPrenom, "textBox3");  // ✅ Utilise les ressources de "textBox3"
            txtPrenom.Name = "txtPrenom";
            txtPrenom.PlaceholderText = " Prénom";

            // 
            // txtEmail (ancien "textBox4")
            // 
            resources.ApplyResources(txtEmail, "textBox4");  // ✅ Utilise les ressources de "textBox4"
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = " Email";

            // 
            // txtTelephone (ancien "textBox1")
            // 
            resources.ApplyResources(txtTelephone, "textBox1");  // ✅ Utilise les ressources de "textBox1"
            txtTelephone.Name = "txtTelephone";
            txtTelephone.PlaceholderText = " Téléphone (optionnel)";

            // 
            // txtAdresse (ancien "textBox5")
            // 
            resources.ApplyResources(txtAdresse, "textBox5");  // ✅ Utilise les ressources de "textBox5"
            txtAdresse.Name = "txtAdresse";
            txtAdresse.PlaceholderText = " Adresse (optionnel)";

            // 
            // txtMotDePasse (ancien "textBox6")
            // 
            resources.ApplyResources(txtMotDePasse, "textBox6");  // ✅ Utilise les ressources de "textBox6"
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.PasswordChar = '*';
            txtMotDePasse.PlaceholderText = " Mot de passe";

            // 
            // txtConfirmation (ancien "textBox7")
            // 
            resources.ApplyResources(txtConfirmation, "textBox7");  // ✅ Utilise les ressources de "textBox7"
            txtConfirmation.Name = "txtConfirmation";
            txtConfirmation.PasswordChar = '*';
            txtConfirmation.PlaceholderText = " Confirmer le mot de passe";

            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.BackColor = Color.FromArgb(200, 50, 50);
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Name = "btnLogin";
            btnLogin.Text = "S'inscrire";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Name = "label2";
            label2.Text = "Vous avez déjà un compte ?";

            // 
            // linkLabel2
            // 
            resources.ApplyResources(linkLabel2, "linkLabel2");
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Se connecter";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;

            // 
            // Inscription
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;

            // ✅ Même ordre que l'original pour garder l'affichage
            Controls.Add(label2);
            Controls.Add(linkLabel2);
            Controls.Add(btnLogin);
            Controls.Add(txtConfirmation);      // textBox7
            Controls.Add(txtMotDePasse);        // textBox6
            Controls.Add(txtAdresse);           // textBox5
            Controls.Add(txtTelephone);         // textBox1
            Controls.Add(txtEmail);             // textBox4
            Controls.Add(txtPrenom);            // textBox3
            Controls.Add(txtNom);               // textBox2
            Controls.Add(txtNomUtilisateur);    // nom
            Controls.Add(label1);

            Name = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;

        // ✅ NOUVEAUX NOMS LOGIQUES (mais même affichage)
        private TextBox txtNomUtilisateur;    // Ancien: nom
        private TextBox txtNom;               // Ancien: textBox2
        private TextBox txtPrenom;            // Ancien: textBox3
        private TextBox txtEmail;             // Ancien: textBox4
        private TextBox txtTelephone;         // Ancien: textBox1
        private TextBox txtAdresse;           // Ancien: textBox5
        private TextBox txtMotDePasse;        // Ancien: textBox6
        private TextBox txtConfirmation;      // Ancien: textBox7

        private Button btnLogin;
        private Label label2;
        private LinkLabel linkLabel2;
    }
}