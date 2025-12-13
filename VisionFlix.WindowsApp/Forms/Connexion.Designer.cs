using System.Drawing.Printing;
using System.Windows.Forms;

namespace VisionFlix.WindowsApp.Forms
{
    partial class Connexion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            lblTitre = new Label();
            txtIdentifiant = new TextBox();
            txtMotDePasse = new TextBox();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitre.AutoSize = true;
            lblTitre.BackColor = Color.Transparent;
            lblTitre.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.ForeColor = SystemColors.Control;
            lblTitre.Location = new Point(274, 66);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(157, 38);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Connexion";
            lblTitre.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdentifiant.BorderStyle = BorderStyle.FixedSingle;
            txtIdentifiant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdentifiant.Location = new Point(206, 166);
            txtIdentifiant.Margin = new Padding(3, 2, 3, 2);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.PlaceholderText = " Nom d'utilisateur ou email";
            txtIdentifiant.Size = new Size(274, 34);
            txtIdentifiant.TabIndex = 1;
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMotDePasse.BorderStyle = BorderStyle.FixedSingle;
            txtMotDePasse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotDePasse.Location = new Point(206, 234);
            txtMotDePasse.Margin = new Padding(3, 2, 3, 2);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.PasswordChar = '*';
            txtMotDePasse.PlaceholderText = " Mot de passe";
            txtMotDePasse.Size = new Size(274, 34);
            txtMotDePasse.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(200, 50, 50);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(206, 346);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(274, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Connexion";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel1.Location = new Point(366, 274);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 17);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Mot de passe oublié";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel2.Location = new Point(425, 392);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(57, 17);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "S'inscrire";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(257, 392);
            label1.Name = "label1";
            label1.Size = new Size(169, 17);
            label1.TabIndex = 6;
            label1.Text = "Vous n'avez pas de compte ?";
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 588);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(txtMotDePasse);
            Controls.Add(txtIdentifiant);
            Controls.Add(lblTitre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Connexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisionFlix - Connexion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;

        // ✅ NOUVEAUX NOMS LOGIQUES
        private TextBox txtIdentifiant;    // Ancien: textBox1 (Nom d'utilisateur ou email)
        private TextBox txtMotDePasse;     // Ancien: textBox2 (Mot de passe)

        private Button btnLogin;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Label label1;
    }
}