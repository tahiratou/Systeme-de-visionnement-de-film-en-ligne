using System.Drawing.Printing;
using System.Windows.Forms;

namespace VisionFlix.Presentation.Forms
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

            // ✅ RENOMMAGE: textBox1 → txtIdentifiant
            txtIdentifiant = new TextBox();
            // ✅ RENOMMAGE: textBox2 → txtMotDePasse
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
            lblTitre.Location = new Point(343, 83);
            lblTitre.Margin = new Padding(4, 0, 4, 0);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(186, 45);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Connexion";
            lblTitre.TextAlign = ContentAlignment.TopCenter;

            // 
            // txtIdentifiant (ancien "textBox1")
            // 
            txtIdentifiant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIdentifiant.BorderStyle = BorderStyle.FixedSingle;
            txtIdentifiant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdentifiant.Location = new Point(257, 208);
            txtIdentifiant.Margin = new Padding(4, 3, 4, 3);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.PlaceholderText = " Nom d'utilisateur ou email";
            txtIdentifiant.Size = new Size(342, 39);
            txtIdentifiant.TabIndex = 1;

            // 
            // txtMotDePasse (ancien "textBox2")
            // 
            txtMotDePasse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMotDePasse.BorderStyle = BorderStyle.FixedSingle;
            txtMotDePasse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotDePasse.Location = new Point(257, 292);
            txtMotDePasse.Margin = new Padding(4, 3, 4, 3);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.PasswordChar = '*';
            txtMotDePasse.PlaceholderText = " Mot de passe";
            txtMotDePasse.Size = new Size(342, 39);
            txtMotDePasse.TabIndex = 2;

            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(200, 50, 50);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(257, 433);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(343, 53);
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
            linkLabel1.Location = new Point(457, 343);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(147, 21);
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
            linkLabel2.Location = new Point(531, 490);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(72, 21);
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
            label1.Location = new Point(321, 490);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 21);
            label1.TabIndex = 6;
            label1.Text = "Vous n'avez pas de compte ?";

            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(891, 735);

            // ✅ Même ordre que l'original
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(txtMotDePasse);      // textBox2
            Controls.Add(txtIdentifiant);     // textBox1
            Controls.Add(lblTitre);

            Margin = new Padding(4, 3, 4, 3);
            Name = "Connexion";
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