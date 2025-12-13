namespace VisionFlix.WindowsApp.Forms
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
            lblLangue = new Label();
            cmbLangue = new ComboBox();
            chkNotifications = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Name = "label1";
            // 
            // txtNom
            // 
            resources.ApplyResources(txtNom, "txtNom");
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.Name = "txtNom";
            // 
            // txtPrenom
            // 
            resources.ApplyResources(txtPrenom, "txtPrenom");
            txtPrenom.BorderStyle = BorderStyle.FixedSingle;
            txtPrenom.Name = "txtPrenom";
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Name = "txtEmail";
            // 
            // txtTelephone
            // 
            resources.ApplyResources(txtTelephone, "txtTelephone");
            txtTelephone.BorderStyle = BorderStyle.FixedSingle;
            txtTelephone.Name = "txtTelephone";
            // 
            // txtAdresse
            // 
            resources.ApplyResources(txtAdresse, "txtAdresse");
            txtAdresse.BorderStyle = BorderStyle.FixedSingle;
            txtAdresse.Name = "txtAdresse";
            // 
            // txtNomUtilisateur
            // 
            resources.ApplyResources(txtNomUtilisateur, "txtNomUtilisateur");
            txtNomUtilisateur.BorderStyle = BorderStyle.FixedSingle;
            txtNomUtilisateur.Name = "txtNomUtilisateur";
            // 
            // txtMotDePasse
            // 
            resources.ApplyResources(txtMotDePasse, "txtMotDePasse");
            txtMotDePasse.BorderStyle = BorderStyle.FixedSingle;
            txtMotDePasse.Name = "txtMotDePasse";
            // 
            // txtConfirmation
            // 
            resources.ApplyResources(txtConfirmation, "txtConfirmation");
            txtConfirmation.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmation.Name = "txtConfirmation";
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.BackColor = Color.FromArgb(200, 50, 50);
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Name = "label2";
            // 
            // linkLabel2
            // 
            resources.ApplyResources(linkLabel2, "linkLabel2");
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.TabStop = true;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // lblLangue
            // 
            resources.ApplyResources(lblLangue, "lblLangue");
            lblLangue.BackColor = Color.Transparent;
            lblLangue.ForeColor = SystemColors.Control;
            lblLangue.Name = "lblLangue";
            // 
            // cmbLangue
            // 
            resources.ApplyResources(cmbLangue, "cmbLangue");
            cmbLangue.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLangue.FormattingEnabled = true;
            cmbLangue.Items.AddRange(new object[] { resources.GetString("cmbLangue.Items"), resources.GetString("cmbLangue.Items1"), resources.GetString("cmbLangue.Items2"), resources.GetString("cmbLangue.Items3") });
            cmbLangue.Name = "cmbLangue";
            // 
            // chkNotifications
            // 
            resources.ApplyResources(chkNotifications, "chkNotifications");
            chkNotifications.BackColor = Color.Transparent;
            chkNotifications.Checked = true;
            chkNotifications.CheckState = CheckState.Checked;
            chkNotifications.ForeColor = SystemColors.Control;
            chkNotifications.Name = "chkNotifications";
            chkNotifications.UseVisualStyleBackColor = false;
            // 
            // Inscription
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkLabel2);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(chkNotifications);
            Controls.Add(cmbLangue);
            Controls.Add(lblLangue);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label lblLangue;
        private ComboBox cmbLangue;
        private CheckBox chkNotifications;
    }
}