namespace VisionFlix.WindowsApp.Forms
{
    partial class FormulairePlanAbonnement
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
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.numPrix = new System.Windows.Forms.NumericUpDown();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkEstActif = new System.Windows.Forms.CheckBox();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 15);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 15);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(85, 12);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 23);
            this.txtNom.TabIndex = 1;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(12, 44);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(30, 15);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "Prix:";
            // 
            // numPrix
            // 
            this.numPrix.DecimalPlaces = 2;
            this.numPrix.Location = new System.Drawing.Point(85, 41);
            this.numPrix.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrix.Name = "numPrix";
            this.numPrix.Size = new System.Drawing.Size(200, 23);
            this.numPrix.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 73);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 15);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(85, 70);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 80);
            this.txtDescription.TabIndex = 5;
            // 
            // chkEstActif
            // 
            this.chkEstActif.AutoSize = true;
            this.chkEstActif.Location = new System.Drawing.Point(85, 156);
            this.chkEstActif.Name = "chkEstActif";
            this.chkEstActif.Size = new System.Drawing.Size(69, 19);
            this.chkEstActif.TabIndex = 6;
            this.chkEstActif.Text = "Est Actif";
            this.chkEstActif.UseVisualStyleBackColor = true;
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(129, 190);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(75, 23);
            this.btnSauvegarder.TabIndex = 7;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.BtnSauvegarder_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(210, 190);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // FormulairePlanAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 225);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.chkEstActif);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.numPrix);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Name = "FormulairePlanAbonnement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormulairePlanAbonnement";
            ((System.ComponentModel.ISupportInitialize)(this.numPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.NumericUpDown numPrix;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkEstActif;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnAnnuler;
    }
}