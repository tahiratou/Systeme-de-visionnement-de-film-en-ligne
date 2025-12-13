namespace VisionFlix.WindowsApp.Forms
{
    partial class GestionCategories
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.Panel panelCategoriesList; // New panel for padding

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
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.panelCategoriesList = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.panelActions.SuspendLayout();
            this.panelCategoriesList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCategoriesList
            // 
            this.panelCategoriesList.Controls.Add(this.dgvCategories);
            this.panelCategoriesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategoriesList.Location = new System.Drawing.Point(0, 0);
            this.panelCategoriesList.Name = "panelCategoriesList";
            this.panelCategoriesList.Padding = new System.Windows.Forms.Padding(10);
            this.panelCategoriesList.Size = new System.Drawing.Size(750, 350);
            this.panelCategoriesList.TabIndex = 0;
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.Location = new System.Drawing.Point(10, 10);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowTemplate.Height = 25;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(730, 330);
            this.dgvCategories.TabIndex = 0;
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
            // GestionCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panelCategoriesList);
            this.Controls.Add(this.panelActions);
            this.Name = "GestionCategories";
            this.Size = new System.Drawing.Size(750, 430);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.panelCategoriesList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}