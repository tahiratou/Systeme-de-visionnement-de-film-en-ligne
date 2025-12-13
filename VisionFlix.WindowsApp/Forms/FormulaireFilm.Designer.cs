namespace VisionFlix.WindowsApp.Forms
{
    partial class FormulaireFilm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblLangue;
        private System.Windows.Forms.ComboBox cmbLangue;
        private System.Windows.Forms.CheckBox chkDisponible;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtThumbnail;
        private System.Windows.Forms.TextBox txtSynopsis;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblThumbnail;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.Label lblPrice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtDirector = new TextBox();
            numYear = new NumericUpDown();
            numRating = new NumericUpDown();
            numDuration = new NumericUpDown();
            cmbGenre = new ComboBox();
            lblTitle = new Label();
            lblDirector = new Label();
            lblYear = new Label();
            lblRating = new Label();
            lblDuration = new Label();
            lblGenre = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtThumbnail = new TextBox();
            txtSynopsis = new TextBox();
            lblLangue = new Label();
            cmbLangue = new ComboBox();
            chkDisponible = new CheckBox();
            numPrice = new NumericUpDown();
            lblThumbnail = new Label();
            lblSynopsis = new Label();
            lblPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(140, 30);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(140, 60);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(200, 23);
            txtDirector.TabIndex = 1;
            // 
            // numYear
            // 
            numYear.Location = new Point(140, 90);
            numYear.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(80, 23);
            numYear.TabIndex = 2;
            numYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // numRating
            // 
            numRating.DecimalPlaces = 1;
            numRating.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numRating.Location = new Point(140, 120);
            numRating.Maximum = new decimal(new int[] { 50, 0, 0, 65536 });
            numRating.Name = "numRating";
            numRating.Size = new Size(80, 23);
            numRating.TabIndex = 3;
            // 
            // numDuration
            // 
            numDuration.Location = new Point(140, 150);
            numDuration.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(80, 23);
            numDuration.TabIndex = 4;
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Items.AddRange(new object[] { "Action", "Comédie", "Drame", "Science-Fiction", "Thriller", "Horreur", "Romance", "Crime", "Animation", "Documentaire" });
            cmbGenre.Location = new Point(140, 180);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(200, 23);
            cmbGenre.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(30, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(34, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Titre:";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(30, 63);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(67, 15);
            lblDirector.TabIndex = 1;
            lblDirector.Text = "Réalisateur:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(30, 93);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(44, 15);
            lblYear.TabIndex = 2;
            lblYear.Text = "Année:";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(30, 123);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(81, 15);
            lblRating.TabIndex = 3;
            lblRating.Text = "Cote (0.0-5.0):";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(30, 153);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(73, 15);
            lblDuration.TabIndex = 4;
            lblDuration.Text = "Durée (min):";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(30, 183);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(41, 15);
            lblGenre.TabIndex = 5;
            lblGenre.Text = "Genre:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 120, 215);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(72, 478);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 30);
            btnSave.TabIndex = 11;
            btnSave.Text = "Sauvegarder";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(60, 60, 60);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(208, 478);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 30);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // txtThumbnail
            // 
            txtThumbnail.Location = new Point(140, 240);
            txtThumbnail.Name = "txtThumbnail";
            txtThumbnail.Size = new Size(200, 23);
            txtThumbnail.TabIndex = 7;
            // 
            // txtSynopsis
            // 
            txtSynopsis.Location = new Point(140, 323);
            txtSynopsis.Multiline = true;
            txtSynopsis.Name = "txtSynopsis";
            txtSynopsis.ScrollBars = ScrollBars.Vertical;
            txtSynopsis.Size = new Size(200, 99);
            txtSynopsis.TabIndex = 8;
            // 
            // lblLangue
            // 
            lblLangue.AutoSize = true;
            lblLangue.Location = new Point(30, 213);
            lblLangue.Name = "lblLangue";
            lblLangue.Size = new Size(49, 15);
            lblLangue.TabIndex = 10;
            lblLangue.Text = "Langue:";
            // 
            // cmbLangue
            // 
            cmbLangue.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLangue.FormattingEnabled = true;
            cmbLangue.Items.AddRange(new object[] { "Français", "Anglais", "Espagnol", "Allemand", "Italien", "Japonais", "Coréen", "Chinois" });
            cmbLangue.Location = new Point(140, 210);
            cmbLangue.Name = "cmbLangue";
            cmbLangue.Size = new Size(200, 23);
            cmbLangue.TabIndex = 6;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Checked = true;
            chkDisponible.CheckState = CheckState.Checked;
            chkDisponible.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkDisponible.Location = new Point(140, 444);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(108, 19);
            chkDisponible.TabIndex = 10;
            chkDisponible.Text = "Film disponible";
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(140, 280);
            numPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(80, 23);
            numPrice.TabIndex = 9;
            numPrice.Value = new decimal(new int[] { 999, 0, 0, 131072 });
            // 
            // lblThumbnail
            // 
            lblThumbnail.AutoSize = true;
            lblThumbnail.Location = new Point(30, 243);
            lblThumbnail.Name = "lblThumbnail";
            lblThumbnail.Size = new Size(67, 15);
            lblThumbnail.TabIndex = 6;
            lblThumbnail.Text = "Image URL:";
            // 
            // lblSynopsis
            // 
            lblSynopsis.AutoSize = true;
            lblSynopsis.Location = new Point(30, 345);
            lblSynopsis.Name = "lblSynopsis";
            lblSynopsis.Size = new Size(56, 15);
            lblSynopsis.TabIndex = 7;
            lblSynopsis.Text = "Synopsis:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(30, 272);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(29, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Prix:";
            // 
            // FormulaireFilm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(380, 556);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(chkDisponible);
            Controls.Add(lblPrice);
            Controls.Add(numPrice);
            Controls.Add(lblSynopsis);
            Controls.Add(txtSynopsis);
            Controls.Add(lblThumbnail);
            Controls.Add(txtThumbnail);
            Controls.Add(cmbLangue);
            Controls.Add(lblLangue);
            Controls.Add(lblGenre);
            Controls.Add(cmbGenre);
            Controls.Add(lblDuration);
            Controls.Add(numDuration);
            Controls.Add(lblRating);
            Controls.Add(numRating);
            Controls.Add(lblYear);
            Controls.Add(numYear);
            Controls.Add(lblDirector);
            Controls.Add(txtDirector);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormulaireFilm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulaire Film";
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}