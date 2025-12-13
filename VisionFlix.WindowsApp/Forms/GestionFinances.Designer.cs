namespace VisionFlix.WindowsApp.Forms
{
    partial class GestionFinances
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelFinancesContent = new System.Windows.Forms.Panel();
            this.dgvVentes = new System.Windows.Forms.DataGridView();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.lblRevenuTotal = new System.Windows.Forms.Label();
            this.lblRevenuTotalValue = new System.Windows.Forms.Label();
            this.lblNombreVentes = new System.Windows.Forms.Label();
            this.lblNombreVentesValue = new System.Windows.Forms.Label();
            this.lblRevenuMoyen = new System.Windows.Forms.Label();
            this.lblRevenuMoyenValue = new System.Windows.Forms.Label();
            this.lblFilmPlusVendu = new System.Windows.Forms.Label();
            this.lblFilmPlusVenduValue = new System.Windows.Forms.Label();
            this.groupBoxPeriode = new System.Windows.Forms.GroupBox();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblDebut = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.panelFinancesContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentes)).BeginInit();
            this.groupBoxStats.SuspendLayout();
            this.groupBoxPeriode.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFinancesContent
            // 
            this.panelFinancesContent.Controls.Add(this.dgvVentes);
            this.panelFinancesContent.Controls.Add(this.groupBoxStats);
            this.panelFinancesContent.Controls.Add(this.groupBoxPeriode);
            this.panelFinancesContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFinancesContent.Location = new System.Drawing.Point(0, 0);
            this.panelFinancesContent.Name = "panelFinancesContent";
            this.panelFinancesContent.Padding = new System.Windows.Forms.Padding(10);
            this.panelFinancesContent.Size = new System.Drawing.Size(1200, 650);
            this.panelFinancesContent.TabIndex = 0;
            // 
            // dgvVentes
            // 
            this.dgvVentes.AllowUserToAddRows = false;
            this.dgvVentes.AllowUserToDeleteRows = false;
            this.dgvVentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvVentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentes.Location = new System.Drawing.Point(10, 300);
            this.dgvVentes.Name = "dgvVentes";
            this.dgvVentes.ReadOnly = true;
            this.dgvVentes.RowTemplate.Height = 25;
            this.dgvVentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentes.Size = new System.Drawing.Size(1180, 340);
            this.dgvVentes.TabIndex = 2;
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.lblRevenuTotal);
            this.groupBoxStats.Controls.Add(this.lblRevenuTotalValue);
            this.groupBoxStats.Controls.Add(this.lblNombreVentes);
            this.groupBoxStats.Controls.Add(this.lblNombreVentesValue);
            this.groupBoxStats.Controls.Add(this.lblRevenuMoyen);
            this.groupBoxStats.Controls.Add(this.lblRevenuMoyenValue);
            this.groupBoxStats.Controls.Add(this.lblFilmPlusVendu);
            this.groupBoxStats.Controls.Add(this.lblFilmPlusVenduValue);
            this.groupBoxStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxStats.ForeColor = System.Drawing.Color.White;
            this.groupBoxStats.Location = new System.Drawing.Point(10, 120);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(1180, 180);
            this.groupBoxStats.TabIndex = 1;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Statistiques";
            // 
            // lblRevenuTotal
            // 
            this.lblRevenuTotal.AutoSize = true;
            this.lblRevenuTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRevenuTotal.ForeColor = System.Drawing.Color.LightGray;
            this.lblRevenuTotal.Location = new System.Drawing.Point(30, 40);
            this.lblRevenuTotal.Name = "lblRevenuTotal";
            this.lblRevenuTotal.Size = new System.Drawing.Size(109, 21);
            this.lblRevenuTotal.TabIndex = 0;
            this.lblRevenuTotal.Text = "Revenu Total :";
            // 
            // lblRevenuTotalValue
            // 
            this.lblRevenuTotalValue.AutoSize = true;
            this.lblRevenuTotalValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRevenuTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.lblRevenuTotalValue.Location = new System.Drawing.Point(180, 35);
            this.lblRevenuTotalValue.Name = "lblRevenuTotalValue";
            this.lblRevenuTotalValue.Size = new System.Drawing.Size(76, 30);
            this.lblRevenuTotalValue.TabIndex = 1;
            this.lblRevenuTotalValue.Text = "0,00 $";
            // 
            // lblNombreVentes
            // 
            this.lblNombreVentes.AutoSize = true;
            this.lblNombreVentes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreVentes.ForeColor = System.Drawing.Color.LightGray;
            this.lblNombreVentes.Location = new System.Drawing.Point(30, 85);
            this.lblNombreVentes.Name = "lblNombreVentes";
            this.lblNombreVentes.Size = new System.Drawing.Size(148, 21);
            this.lblNombreVentes.TabIndex = 2;
            this.lblNombreVentes.Text = "Nombre de ventes :";
            // 
            // lblNombreVentesValue
            // 
            this.lblNombreVentesValue.AutoSize = true;
            this.lblNombreVentesValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreVentesValue.ForeColor = System.Drawing.Color.White;
            this.lblNombreVentesValue.Location = new System.Drawing.Point(180, 82);
            this.lblNombreVentesValue.Name = "lblNombreVentesValue";
            this.lblNombreVentesValue.Size = new System.Drawing.Size(23, 25);
            this.lblNombreVentesValue.TabIndex = 3;
            this.lblNombreVentesValue.Text = "0";
            // 
            // lblRevenuMoyen
            // 
            this.lblRevenuMoyen.AutoSize = true;
            this.lblRevenuMoyen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRevenuMoyen.ForeColor = System.Drawing.Color.LightGray;
            this.lblRevenuMoyen.Location = new System.Drawing.Point(600, 40);
            this.lblRevenuMoyen.Name = "lblRevenuMoyen";
            this.lblRevenuMoyen.Size = new System.Drawing.Size(124, 21);
            this.lblRevenuMoyen.TabIndex = 4;
            this.lblRevenuMoyen.Text = "Revenu moyen :";
            // 
            // lblRevenuMoyenValue
            // 
            this.lblRevenuMoyenValue.AutoSize = true;
            this.lblRevenuMoyenValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRevenuMoyenValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.lblRevenuMoyenValue.Location = new System.Drawing.Point(750, 37);
            this.lblRevenuMoyenValue.Name = "lblRevenuMoyenValue";
            this.lblRevenuMoyenValue.Size = new System.Drawing.Size(66, 25);
            this.lblRevenuMoyenValue.TabIndex = 5;
            this.lblRevenuMoyenValue.Text = "0,00 $";
            // 
            // lblFilmPlusVendu
            // 
            this.lblFilmPlusVendu.AutoSize = true;
            this.lblFilmPlusVendu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilmPlusVendu.ForeColor = System.Drawing.Color.LightGray;
            this.lblFilmPlusVendu.Location = new System.Drawing.Point(600, 85);
            this.lblFilmPlusVendu.Name = "lblFilmPlusVendu";
            this.lblFilmPlusVendu.Size = new System.Drawing.Size(136, 21);
            this.lblFilmPlusVendu.TabIndex = 6;
            this.lblFilmPlusVendu.Text = "Film plus vendu :";
            // 
            // lblFilmPlusVenduValue
            // 
            this.lblFilmPlusVenduValue.AutoSize = true;
            this.lblFilmPlusVenduValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilmPlusVenduValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.lblFilmPlusVenduValue.Location = new System.Drawing.Point(750, 85);
            this.lblFilmPlusVenduValue.Name = "lblFilmPlusVenduValue";
            this.lblFilmPlusVenduValue.Size = new System.Drawing.Size(21, 21);
            this.lblFilmPlusVenduValue.TabIndex = 7;
            this.lblFilmPlusVenduValue.Text = "--";
            // 
            // groupBoxPeriode
            // 
            this.groupBoxPeriode.Controls.Add(this.dtpDebut);
            this.groupBoxPeriode.Controls.Add(this.dtpFin);
            this.groupBoxPeriode.Controls.Add(this.lblDebut);
            this.groupBoxPeriode.Controls.Add(this.lblFin);
            this.groupBoxPeriode.Controls.Add(this.btnCalculer);
            this.groupBoxPeriode.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxPeriode.ForeColor = System.Drawing.Color.White;
            this.groupBoxPeriode.Location = new System.Drawing.Point(10, 10);
            this.groupBoxPeriode.Name = "groupBoxPeriode";
            this.groupBoxPeriode.Size = new System.Drawing.Size(1180, 110);
            this.groupBoxPeriode.TabIndex = 0;
            this.groupBoxPeriode.TabStop = false;
            this.groupBoxPeriode.Text = "Sélection de période";
            // 
            // dtpDebut
            // 
            this.dtpDebut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDebut.Location = new System.Drawing.Point(130, 40);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(250, 25);
            this.dtpDebut.TabIndex = 1;
            // 
            // dtpFin
            // 
            this.dtpFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFin.Location = new System.Drawing.Point(530, 40);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(250, 25);
            this.dtpFin.TabIndex = 3;
            // 
            // lblDebut
            // 
            this.lblDebut.AutoSize = true;
            this.lblDebut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDebut.ForeColor = System.Drawing.Color.LightGray;
            this.lblDebut.Location = new System.Drawing.Point(30, 43);
            this.lblDebut.Name = "lblDebut";
            this.lblDebut.Size = new System.Drawing.Size(86, 19);
            this.lblDebut.TabIndex = 0;
            this.lblDebut.Text = "Date début :";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFin.ForeColor = System.Drawing.Color.LightGray;
            this.lblFin.Location = new System.Drawing.Point(450, 43);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(65, 19);
            this.lblFin.TabIndex = 2;
            this.lblFin.Text = "Date fin :";
            // 
            // btnCalculer
            // 
            this.btnCalculer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCalculer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculer.ForeColor = System.Drawing.Color.White;
            this.btnCalculer.Location = new System.Drawing.Point(830, 35);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(150, 35);
            this.btnCalculer.TabIndex = 4;
            this.btnCalculer.Text = "📊 Calculer";
            this.btnCalculer.UseVisualStyleBackColor = false;
            // 
            // GestionFinances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panelFinancesContent);
            this.Name = "GestionFinances";
            this.Size = new System.Drawing.Size(1200, 650);
            this.panelFinancesContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentes)).EndInit();
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.groupBoxPeriode.ResumeLayout(false);
            this.groupBoxPeriode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFinancesContent;
        private System.Windows.Forms.DataGridView dgvVentes;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label lblRevenuTotal;
        private System.Windows.Forms.Label lblRevenuTotalValue;
        private System.Windows.Forms.Label lblNombreVentes;
        private System.Windows.Forms.Label lblNombreVentesValue;
        private System.Windows.Forms.Label lblRevenuMoyen;
        private System.Windows.Forms.Label lblRevenuMoyenValue;
        private System.Windows.Forms.Label lblFilmPlusVendu;
        private System.Windows.Forms.Label lblFilmPlusVenduValue;
        private System.Windows.Forms.GroupBox groupBoxPeriode;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblDebut;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Button btnCalculer;
    }
}