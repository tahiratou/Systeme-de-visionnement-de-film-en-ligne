namespace VisionFlix.WindowsApp.Forms
{
    partial class FormulaireLangue
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
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.chkEstActive = new System.Windows.Forms.CheckBox();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
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
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(12, 44);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(38, 15);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(85, 41);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 23);
            this.txtCode.TabIndex = 3;
            // 
            // chkEstActive
            // 
            this.chkEstActive.AutoSize = true;
            this.chkEstActive.Location = new System.Drawing.Point(85, 70);
            this.chkEstActive.Name = "chkEstActive";
            this.chkEstActive.Size = new System.Drawing.Size(69, 19);
            this.chkEstActive.TabIndex = 4;
            this.chkEstActive.Text = "Est Active";
            this.chkEstActive.UseVisualStyleBackColor = true;
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(129, 100);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(75, 23);
            this.btnSauvegarder.TabIndex = 5;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.BtnSauvegarder_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(210, 100);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // FormulaireLangue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 135);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.chkEstActive);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Name = "FormulaireLangue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormulaireLangue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.CheckBox chkEstActive;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnAnnuler;
    }
}