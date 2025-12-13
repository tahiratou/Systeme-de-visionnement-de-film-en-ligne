namespace VisionFlix.WindowsApp.Forms
{
    partial class GestionPlansAbonnement
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvPlansAbonnement;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.Panel panelPlansAbonnementList;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.dgvPlansAbonnement = new System.Windows.Forms.DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.panelPlansAbonnementList = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlansAbonnement)).BeginInit();
            this.panelActions.SuspendLayout();
            this.panelPlansAbonnementList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlansAbonnementList
            // 
            this.panelPlansAbonnementList.Controls.Add(this.dgvPlansAbonnement);
            this.panelPlansAbonnementList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlansAbonnementList.Location = new System.Drawing.Point(0, 0);
            this.panelPlansAbonnementList.Name = "panelPlansAbonnementList";
            this.panelPlansAbonnementList.Padding = new System.Windows.Forms.Padding(10);
            this.panelPlansAbonnementList.Size = new System.Drawing.Size(750, 350);
            this.panelPlansAbonnementList.TabIndex = 0;
            // 
            // dgvPlansAbonnement
            // 
            this.dgvPlansAbonnement.AllowUserToAddRows = false;
            this.dgvPlansAbonnement.AllowUserToDeleteRows = false;
            this.dgvPlansAbonnement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlansAbonnement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvPlansAbonnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlansAbonnement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlansAbonnement.Location = new System.Drawing.Point(10, 10);
            this.dgvPlansAbonnement.MultiSelect = false;
            this.dgvPlansAbonnement.Name = "dgvPlansAbonnement";
            this.dgvPlansAbonnement.ReadOnly = true;
            this.dgvPlansAbonnement.RowTemplate.Height = 25;
            this.dgvPlansAbonnement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlansAbonnement.Size = new System.Drawing.Size(730, 330);
            this.dgvPlansAbonnement.TabIndex = 0;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelActions.Controls.Add(this.btnRafraichir);
            this.panelActions.Controls.Add(this.btnSupprimer);
            this.panelActions.Controls.Add(this.btnModifier);
            this.panelActions.Controls.Add(this.btnAjouter);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(0, 350);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(750, 80);
            this.panelActions.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(20, 20);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(150, 40);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "➕ Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(190, 20);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(150, 40);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "✏️ Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(360, 20);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(150, 40);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "🗑️ Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRafraichir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRafraichir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRafraichir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRafraichir.ForeColor = System.Drawing.Color.White;
            this.btnRafraichir.Location = new System.Drawing.Point(580, 20);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(150, 40);
            this.btnRafraichir.TabIndex = 3;
            this.btnRafraichir.Text = "🔄 Rafraîchir";
            this.btnRafraichir.UseVisualStyleBackColor = false;
            this.btnRafraichir.Click += new System.EventHandler(this.BtnRafraichir_Click);
            // 
            // GestionPlansAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panelPlansAbonnementList);
            this.Controls.Add(this.panelActions);
            this.Name = "GestionPlansAbonnement";
            this.Size = new System.Drawing.Size(750, 430);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlansAbonnement)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.panelPlansAbonnementList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}