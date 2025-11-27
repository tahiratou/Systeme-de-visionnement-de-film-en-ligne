namespace VisionFlix.Presentation.Forms
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtThumbnail = new System.Windows.Forms.TextBox();
            this.txtSynopsis = new System.Windows.Forms.TextBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblThumbnail = new System.Windows.Forms.Label();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(140, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(34, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Titre:";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(140, 60);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(200, 23);
            this.txtDirector.TabIndex = 1;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(30, 63);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(68, 15);
            this.lblDirector.TabIndex = 1;
            this.lblDirector.Text = "Réalisateur:";
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(140, 90);
            this.numYear.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            this.numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            this.numYear.Name = "numYear";
            this.numYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            this.numYear.Size = new System.Drawing.Size(80, 23);
            this.numYear.TabIndex = 2;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(30, 93);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(44, 15);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Année:";
            // 
            // numRating
            // 
            this.numRating.DecimalPlaces = 1;
            this.numRating.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.numRating.Location = new System.Drawing.Point(140, 120);
            this.numRating.Maximum = new decimal(new int[] { 50, 0, 0, 65536 });
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(80, 23);
            this.numRating.TabIndex = 3;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(30, 123);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(77, 15);
            this.lblRating.TabIndex = 3;
            this.lblRating.Text = "Cote (0.0-5.0):";
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(140, 150);
            this.numDuration.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(80, 23);
            this.numDuration.TabIndex = 4;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(30, 153);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(75, 15);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Durée (min):";
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "Action",
            "Comédie",
            "Drame",
            "Science-Fiction",
            "Thriller",
            "Horreur",
            "Romance",
            "Crime"});
            this.cmbGenre.Location = new System.Drawing.Point(140, 180);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(150, 23);
            this.cmbGenre.TabIndex = 5;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(30, 183);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(41, 15);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "Genre:";
            // 
            // txtThumbnail
            // 
            this.txtThumbnail.Location = new System.Drawing.Point(140, 210);
            this.txtThumbnail.Name = "txtThumbnail";
            this.txtThumbnail.Size = new System.Drawing.Size(200, 23);
            this.txtThumbnail.TabIndex = 6;
            // 
            // lblThumbnail
            // 
            this.lblThumbnail.AutoSize = true;
            this.lblThumbnail.Location = new System.Drawing.Point(30, 213);
            this.lblThumbnail.Name = "lblThumbnail";
            this.lblThumbnail.Size = new System.Drawing.Size(64, 15);
            this.lblThumbnail.TabIndex = 6;
            this.lblThumbnail.Text = "Thumbnail:";
            // 
            // txtSynopsis
            // 
            this.txtSynopsis.Location = new System.Drawing.Point(140, 240);
            this.txtSynopsis.Multiline = true;
            this.txtSynopsis.Name = "txtSynopsis";
            this.txtSynopsis.Size = new System.Drawing.Size(200, 60);
            this.txtSynopsis.TabIndex = 7;
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Location = new System.Drawing.Point(30, 243);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(57, 15);
            this.lblSynopsis.TabIndex = 7;
            this.lblSynopsis.Text = "Synopsis:";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Location = new System.Drawing.Point(140, 310);
            this.numPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(80, 23);
            this.numPrice.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 313);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 15);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Prix:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormulaireFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 390);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblSynopsis);
            this.Controls.Add(this.txtSynopsis);
            this.Controls.Add(this.lblThumbnail);
            this.Controls.Add(this.txtThumbnail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Name = "FormulaireFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulaire Film";
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


    }
}