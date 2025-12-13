namespace VisionFlix.WindowsApp.Forms
{
    partial class PanneauAdmin
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRetourAccueil = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGestionFilms = new System.Windows.Forms.TabPage();
            this.tabFinances = new System.Windows.Forms.TabPage();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.tabPlansAbonnement = new System.Windows.Forms.TabPage();
            this.tabLangues = new System.Windows.Forms.TabPage();
            this.panelTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnRetourAccueil);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 80);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PANNEAU ADMIN";
            // 
            // btnRetourAccueil
            // 
            this.btnRetourAccueil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRetourAccueil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRetourAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetourAccueil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetourAccueil.ForeColor = System.Drawing.Color.White;
            this.btnRetourAccueil.Location = new System.Drawing.Point(1050, 25);
            this.btnRetourAccueil.Name = "btnRetourAccueil";
            this.btnRetourAccueil.Size = new System.Drawing.Size(130, 35);
            this.btnRetourAccueil.TabIndex = 1;
            this.btnRetourAccueil.Text = "← Retour";
            this.btnRetourAccueil.UseVisualStyleBackColor = false;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabGestionFilms);
            this.tabControl.Controls.Add(this.tabFinances);
            this.tabControl.Controls.Add(this.tabCategories);
            this.tabControl.Controls.Add(this.tabPlansAbonnement);
            this.tabControl.Controls.Add(this.tabLangues);
            this.tabControl.ItemSize = new System.Drawing.Size(150, 29);
            this.tabControl.Location = new System.Drawing.Point(10, 90);
            this.tabControl.Margin = new System.Windows.Forms.Padding(10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1180, 550);
            this.tabControl.TabIndex = 1;
            // 
            // tabGestionFilms
            // 
            this.tabGestionFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabGestionFilms.Location = new System.Drawing.Point(4, 29);
            this.tabGestionFilms.Name = "tabGestionFilms";
            this.tabGestionFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionFilms.Size = new System.Drawing.Size(1192, 537);
            this.tabGestionFilms.TabIndex = 0;
            this.tabGestionFilms.Text = "Gestion des Films";
            this.tabGestionFilms.UseVisualStyleBackColor = false;
            // 
            // tabFinances
            // 
            this.tabFinances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabFinances.Location = new System.Drawing.Point(4, 29);
            this.tabFinances.Name = "tabFinances";
            this.tabFinances.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinances.Size = new System.Drawing.Size(1192, 537);
            this.tabFinances.TabIndex = 1;
            this.tabFinances.Text = "Données Financières";
            this.tabFinances.UseVisualStyleBackColor = false;
            // 
            // tabCategories
            // 
            this.tabCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabCategories.Location = new System.Drawing.Point(4, 29);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategories.Size = new System.Drawing.Size(1192, 537);
            this.tabCategories.TabIndex = 2;
            this.tabCategories.Text = "Gestion des Catégories";
            this.tabCategories.UseVisualStyleBackColor = false;
            // 
            // tabPlansAbonnement
            // 
            this.tabPlansAbonnement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPlansAbonnement.Location = new System.Drawing.Point(4, 29);
            this.tabPlansAbonnement.Name = "tabPlansAbonnement";
            this.tabPlansAbonnement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlansAbonnement.Size = new System.Drawing.Size(1192, 537);
            this.tabPlansAbonnement.TabIndex = 3;
            this.tabPlansAbonnement.Text = "Gestion des Plans d\'Abonnement";
            this.tabPlansAbonnement.UseVisualStyleBackColor = false;
            // 
            // tabLangues
            // 
            this.tabLangues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabLangues.Location = new System.Drawing.Point(4, 29);
            this.tabLangues.Name = "tabLangues";
            this.tabLangues.Padding = new System.Windows.Forms.Padding(3);
            this.tabLangues.Size = new System.Drawing.Size(1192, 537);
            this.tabLangues.TabIndex = 4;
            this.tabLangues.Text = "Gestion des Langues";
            this.tabLangues.UseVisualStyleBackColor = false;
            // 
            // PanneauAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "PanneauAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panneau Administrateur";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRetourAccueil;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGestionFilms;
        private System.Windows.Forms.TabPage tabFinances;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.TabPage tabPlansAbonnement;
        private System.Windows.Forms.TabPage tabLangues;
    }
}