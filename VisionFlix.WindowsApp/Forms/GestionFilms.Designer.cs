namespace VisionFlix.WindowsApp.Forms
{
    partial class GestionFilms
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
            this.panelFilmsList = new System.Windows.Forms.Panel();
            this.dgvFilms = new System.Windows.Forms.DataGridView();
            this.panelFilmActions = new System.Windows.Forms.Panel();
            this.btnAjouterFilm = new System.Windows.Forms.Button();
            this.btnModifierFilm = new System.Windows.Forms.Button();
            this.btnSupprimerFilm = new System.Windows.Forms.Button();
            this.btnRafraichirFilms = new System.Windows.Forms.Button();
            this.panelFilmsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).BeginInit();
            this.panelFilmActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilmsList
            // 
            this.panelFilmsList.Controls.Add(this.dgvFilms);
            this.panelFilmsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilmsList.Location = new System.Drawing.Point(0, 0);
            this.panelFilmsList.Name = "panelFilmsList";
            this.panelFilmsList.Padding = new System.Windows.Forms.Padding(10);
            this.panelFilmsList.Size = new System.Drawing.Size(1200, 570);
            this.panelFilmsList.TabIndex = 0;
            // 
            // dgvFilms
            // 
            this.dgvFilms.AllowUserToAddRows = false;
            this.dgvFilms.AllowUserToDeleteRows = false;
            this.dgvFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilms.Location = new System.Drawing.Point(10, 10);
            this.dgvFilms.MultiSelect = false;
            this.dgvFilms.Name = "dgvFilms";
            this.dgvFilms.ReadOnly = true;
            this.dgvFilms.RowTemplate.Height = 25;
            this.dgvFilms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilms.Size = new System.Drawing.Size(1180, 550);
            this.dgvFilms.TabIndex = 0;
            // 
            // panelFilmActions
            // 
            this.panelFilmActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelFilmActions.Controls.Add(this.btnAjouterFilm);
            this.panelFilmActions.Controls.Add(this.btnModifierFilm);
            this.panelFilmActions.Controls.Add(this.btnSupprimerFilm);
            this.panelFilmActions.Controls.Add(this.btnRafraichirFilms);
            this.panelFilmActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFilmActions.Location = new System.Drawing.Point(0, 570);
            this.panelFilmActions.Name = "panelFilmActions";
            this.panelFilmActions.Size = new System.Drawing.Size(1200, 80);
            this.panelFilmActions.TabIndex = 1;
            // 
            // btnAjouterFilm
            // 
            this.btnAjouterFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.btnAjouterFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterFilm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjouterFilm.ForeColor = System.Drawing.Color.White;
            this.btnAjouterFilm.Location = new System.Drawing.Point(20, 20);
            this.btnAjouterFilm.Name = "btnAjouterFilm";
            this.btnAjouterFilm.Size = new System.Drawing.Size(150, 40);
            this.btnAjouterFilm.TabIndex = 0;
            this.btnAjouterFilm.Text = "➕ Ajouter";
            this.btnAjouterFilm.UseVisualStyleBackColor = false;
            // 
            // btnModifierFilm
            // 
            this.btnModifierFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(150)))), ((int)(((byte)(50)))));
            this.btnModifierFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierFilm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifierFilm.ForeColor = System.Drawing.Color.White;
            this.btnModifierFilm.Location = new System.Drawing.Point(190, 20);
            this.btnModifierFilm.Name = "btnModifierFilm";
            this.btnModifierFilm.Size = new System.Drawing.Size(150, 40);
            this.btnModifierFilm.TabIndex = 1;
            this.btnModifierFilm.Text = "✏️ Modifier";
            this.btnModifierFilm.UseVisualStyleBackColor = false;
            // 
            // btnSupprimerFilm
            // 
            this.btnSupprimerFilm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSupprimerFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerFilm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimerFilm.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerFilm.Location = new System.Drawing.Point(360, 20);
            this.btnSupprimerFilm.Name = "btnSupprimerFilm";
            this.btnSupprimerFilm.Size = new System.Drawing.Size(150, 40);
            this.btnSupprimerFilm.TabIndex = 2;
            this.btnSupprimerFilm.Text = "🗑️ Supprimer";
            this.btnSupprimerFilm.UseVisualStyleBackColor = false;
            // 
            // btnRafraichirFilms
            // 
            this.btnRafraichirFilms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRafraichirFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRafraichirFilms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRafraichirFilms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRafraichirFilms.ForeColor = System.Drawing.Color.White;
            this.btnRafraichirFilms.Location = new System.Drawing.Point(1030, 20);
            this.btnRafraichirFilms.Name = "btnRafraichirFilms";
            this.btnRafraichirFilms.Size = new System.Drawing.Size(150, 40);
            this.btnRafraichirFilms.TabIndex = 3;
            this.btnRafraichirFilms.Text = "🔄 Rafraîchir";
            this.btnRafraichirFilms.UseVisualStyleBackColor = false;
            // 
            // GestionFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panelFilmsList);
            this.Controls.Add(this.panelFilmActions);
            this.Name = "GestionFilms";
            this.Size = new System.Drawing.Size(1200, 650);
            this.panelFilmsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilms)).EndInit();
            this.panelFilmActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilmsList;
        private System.Windows.Forms.DataGridView dgvFilms;
        private System.Windows.Forms.Panel panelFilmActions;
        private System.Windows.Forms.Button btnAjouterFilm;
        private System.Windows.Forms.Button btnModifierFilm;
        private System.Windows.Forms.Button btnSupprimerFilm;
        private System.Windows.Forms.Button btnRafraichirFilms;
    }
}