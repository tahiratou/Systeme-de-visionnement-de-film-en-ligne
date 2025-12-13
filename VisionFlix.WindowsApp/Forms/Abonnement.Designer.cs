namespace VisionFlix.WindowsApp.Forms
{
    partial class Abonnement
    {
        
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel panelBasic;
        private System.Windows.Forms.Label lblBasicNom;
        private System.Windows.Forms.Label lblBasicPrix;
        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Panel panelPremium;
        private System.Windows.Forms.Label lblPremiumNom;
        private System.Windows.Forms.Label lblPremiumPrix;
        private System.Windows.Forms.Button btnPremium;
        private System.Windows.Forms.Panel panelPlatinum;
        private System.Windows.Forms.Label lblPlatinumNom;
        private System.Windows.Forms.Label lblPlatinumPrix;
        private System.Windows.Forms.Button btnPlatinum;
        private System.Windows.Forms.Button btnResilier;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblBasicDescription;
        private System.Windows.Forms.Label lblPremiumDescription;
        private System.Windows.Forms.Label lblPlatinumDescription;

        
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.panelBasic = new System.Windows.Forms.Panel();
            this.btnBasic = new System.Windows.Forms.Button();
            this.lblBasicPrix = new System.Windows.Forms.Label();
            this.lblBasicNom = new System.Windows.Forms.Label();
            this.panelPremium = new System.Windows.Forms.Panel();
            this.btnPremium = new System.Windows.Forms.Button();
            this.lblPremiumPrix = new System.Windows.Forms.Label();
            this.lblPremiumNom = new System.Windows.Forms.Label();
            this.panelPlatinum = new System.Windows.Forms.Panel();
            this.btnPlatinum = new System.Windows.Forms.Button();
            this.lblPlatinumPrix = new System.Windows.Forms.Label();
            this.lblPlatinumNom = new System.Windows.Forms.Label();
            this.btnResilier = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblBasicDescription = new System.Windows.Forms.Label();
            this.lblPremiumDescription = new System.Windows.Forms.Label();
            this.lblPlatinumDescription = new System.Windows.Forms.Label();

            this.panelBasic.SuspendLayout();
            this.panelPremium.SuspendLayout();
            this.panelPlatinum.SuspendLayout();
            this.SuspendLayout();

            
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(12, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(776, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Choisissez votre plan d\'abonnement";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelBasic
            // 
            this.panelBasic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelBasic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBasic.Controls.Add(this.lblBasicDescription);
            this.panelBasic.Controls.Add(this.btnBasic);
            this.panelBasic.Controls.Add(this.lblBasicPrix);
            this.panelBasic.Controls.Add(this.lblBasicNom);
            this.panelBasic.Location = new System.Drawing.Point(20, 80);
            this.panelBasic.Name = "panelBasic";
            this.panelBasic.Size = new System.Drawing.Size(240, 280);
            this.panelBasic.TabIndex = 1;
            // 
            // btnBasic
            // 
            this.btnBasic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnBasic.FlatAppearance.BorderSize = 0;
            this.btnBasic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasic.ForeColor = System.Drawing.Color.White;
            this.btnBasic.Location = new System.Drawing.Point(50, 230);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(140, 35);
            this.btnBasic.TabIndex = 2;
            this.btnBasic.Text = "Choisir Basic";
            this.btnBasic.UseVisualStyleBackColor = false;
            this.btnBasic.Click += new System.EventHandler(this.BtnBasic_Click);
            // 
            // lblBasicPrix
            // 
            this.lblBasicPrix.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBasicPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.lblBasicPrix.Location = new System.Drawing.Point(10, 50);
            this.lblBasicPrix.Name = "lblBasicPrix";
            this.lblBasicPrix.Size = new System.Drawing.Size(220, 30);
            this.lblBasicPrix.TabIndex = 1;
            this.lblBasicPrix.Text = "9.99 $ / mois";
            this.lblBasicPrix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBasicNom
            // 
            this.lblBasicNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBasicNom.ForeColor = System.Drawing.Color.White;
            this.lblBasicNom.Location = new System.Drawing.Point(10, 15);
            this.lblBasicNom.Name = "lblBasicNom";
            this.lblBasicNom.Size = new System.Drawing.Size(220, 25);
            this.lblBasicNom.TabIndex = 0;
            this.lblBasicNom.Text = "Plan Basic";
            this.lblBasicNom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBasicDescription
            // 
            this.lblBasicDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBasicDescription.ForeColor = System.Drawing.Color.Silver;
            this.lblBasicDescription.Location = new System.Drawing.Point(10, 90);
            this.lblBasicDescription.Name = "lblBasicDescription";
            this.lblBasicDescription.Size = new System.Drawing.Size(220, 120);
            this.lblBasicDescription.TabIndex = 3;
            this.lblBasicDescription.Text = "Description du plan Basic";
            this.lblBasicDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPremium
            // 
            this.panelPremium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelPremium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPremium.Controls.Add(this.lblPremiumDescription);
            this.panelPremium.Controls.Add(this.btnPremium);
            this.panelPremium.Controls.Add(this.lblPremiumPrix);
            this.panelPremium.Controls.Add(this.lblPremiumNom);
            this.panelPremium.Location = new System.Drawing.Point(280, 80);
            this.panelPremium.Name = "panelPremium";
            this.panelPremium.Size = new System.Drawing.Size(240, 280);
            this.panelPremium.TabIndex = 2;
            // 
            // btnPremium
            // 
            this.btnPremium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnPremium.FlatAppearance.BorderSize = 0;
            this.btnPremium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPremium.ForeColor = System.Drawing.Color.White;
            this.btnPremium.Location = new System.Drawing.Point(50, 230);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(140, 35);
            this.btnPremium.TabIndex = 2;
            this.btnPremium.Text = "Choisir Premium";
            this.btnPremium.UseVisualStyleBackColor = false;
            this.btnPremium.Click += new System.EventHandler(this.BtnPremium_Click);
            // 
            // lblPremiumPrix
            // 
            this.lblPremiumPrix.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPremiumPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.lblPremiumPrix.Location = new System.Drawing.Point(10, 50);
            this.lblPremiumPrix.Name = "lblPremiumPrix";
            this.lblPremiumPrix.Size = new System.Drawing.Size(220, 30);
            this.lblPremiumPrix.TabIndex = 1;
            this.lblPremiumPrix.Text = "14.99 $ / mois";
            this.lblPremiumPrix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPremiumNom
            // 
            this.lblPremiumNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPremiumNom.ForeColor = System.Drawing.Color.White;
            this.lblPremiumNom.Location = new System.Drawing.Point(10, 15);
            this.lblPremiumNom.Name = "lblPremiumNom";
            this.lblPremiumNom.Size = new System.Drawing.Size(220, 25);
            this.lblPremiumNom.TabIndex = 0;
            this.lblPremiumNom.Text = "Plan Premium";
            this.lblPremiumNom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPremiumDescription
            // 
            this.lblPremiumDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPremiumDescription.ForeColor = System.Drawing.Color.Silver;
            this.lblPremiumDescription.Location = new System.Drawing.Point(10, 90);
            this.lblPremiumDescription.Name = "lblPremiumDescription";
            this.lblPremiumDescription.Size = new System.Drawing.Size(220, 120);
            this.lblPremiumDescription.TabIndex = 3;
            this.lblPremiumDescription.Text = "Description du plan Premium";
            this.lblPremiumDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelPlatinum
            // 
            this.panelPlatinum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelPlatinum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlatinum.Controls.Add(this.lblPlatinumDescription);
            this.panelPlatinum.Controls.Add(this.lblPlatinumDescription);
            this.panelPlatinum.Controls.Add(this.btnPlatinum);
            this.panelPlatinum.Controls.Add(this.lblPlatinumPrix);
            this.panelPlatinum.Controls.Add(this.lblPlatinumNom);
            this.panelPlatinum.Location = new System.Drawing.Point(540, 80);
            this.panelPlatinum.Name = "panelPlatinum";
            this.panelPlatinum.Size = new System.Drawing.Size(240, 280);
            this.panelPlatinum.TabIndex = 3;
            // 
            // btnPlatinum
            // 
            this.btnPlatinum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnPlatinum.FlatAppearance.BorderSize = 0;
            this.btnPlatinum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlatinum.ForeColor = System.Drawing.Color.White;
            this.btnPlatinum.Location = new System.Drawing.Point(50, 230);
            this.btnPlatinum.Name = "btnPlatinum";
            this.btnPlatinum.Size = new System.Drawing.Size(140, 35);
            this.btnPlatinum.TabIndex = 2;
            this.btnPlatinum.Text = "Choisir Platinum";
            this.btnPlatinum.UseVisualStyleBackColor = false;
            this.btnPlatinum.Click += new System.EventHandler(this.BtnPlatinum_Click);
            // 
            // lblPlatinumPrix
            // 
            this.lblPlatinumPrix.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPlatinumPrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.lblPlatinumPrix.Location = new System.Drawing.Point(10, 50);
            this.lblPlatinumPrix.Name = "lblPlatinumPrix";
            this.lblPlatinumPrix.Size = new System.Drawing.Size(220, 30);
            this.lblPlatinumPrix.TabIndex = 1;
            this.lblPlatinumPrix.Text = "19.99 $ / mois";
            this.lblPlatinumPrix.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlatinumNom
            // 
            this.lblPlatinumNom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlatinumNom.ForeColor = System.Drawing.Color.White;
            this.lblPlatinumNom.Location = new System.Drawing.Point(10, 15);
            this.lblPlatinumNom.Name = "lblPlatinumNom";
            this.lblPlatinumNom.Size = new System.Drawing.Size(220, 25);
            this.lblPlatinumNom.TabIndex = 0;
            this.lblPlatinumNom.Text = "Plan Platinum";
            this.lblPlatinumNom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlatinumDescription
            // 
            this.lblPlatinumDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlatinumDescription.ForeColor = System.Drawing.Color.Silver;
            this.lblPlatinumDescription.Location = new System.Drawing.Point(10, 90);
            this.lblPlatinumDescription.Name = "lblPlatinumDescription";
            this.lblPlatinumDescription.Size = new System.Drawing.Size(220, 120);
            this.lblPlatinumDescription.TabIndex = 3;
            this.lblPlatinumDescription.Text = "Description du plan Platinum";
            this.lblPlatinumDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPlatinumDescription
            // 
            this.lblPlatinumDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPlatinumDescription.ForeColor = System.Drawing.Color.Silver;
            this.lblPlatinumDescription.Location = new System.Drawing.Point(10, 90);
            this.lblPlatinumDescription.Name = "lblPlatinumDescription";
            this.lblPlatinumDescription.Size = new System.Drawing.Size(220, 120);
            this.lblPlatinumDescription.TabIndex = 3;
            this.lblPlatinumDescription.Text = "Description du plan Platinum";
            this.lblPlatinumDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnResilier
            // 
            this.btnResilier.Location = new System.Drawing.Point(20, 390);
            this.btnResilier.Name = "btnResilier";
            this.btnResilier.Size = new System.Drawing.Size(180, 40);
            this.btnResilier.TabIndex = 4;
            this.btnResilier.Text = "Résilier l\'abonnement";
            this.btnResilier.UseVisualStyleBackColor = true;
            this.btnResilier.Visible = false; // Sera géré par LoadPlans()
            this.btnResilier.Click += new System.EventHandler(this.BtnResilier_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.ForeColor = System.Drawing.Color.White;
            this.btnFermer.Location = new System.Drawing.Point(600, 390);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(180, 40);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // Abonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnResilier);
            this.Controls.Add(this.panelPlatinum);
            this.Controls.Add(this.panelPremium);
            this.Controls.Add(this.panelBasic);
            this.Controls.Add(this.lblTitre);
            this.Name = "Abonnement";
            this.Text = "VisionFlix - Abonnement";
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.panelBasic.ResumeLayout(false);
            this.panelPremium.ResumeLayout(false);
            this.panelPlatinum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}