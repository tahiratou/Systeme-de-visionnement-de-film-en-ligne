// WindowsApp/Forms/DetailsFilmPublic.Designer.cs
namespace VisionFlix.WindowsApp.Forms
{
    partial class DetailsFilmPublic
    {
        private System.ComponentModel.IContainer components = null;

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
            pictureBoxFilm = new PictureBox();
            lblTitre = new Label();
            lblAnnee = new Label();
            lblRealisateur = new Label();
            lblGenre = new Label();
            lblDuree = new Label();
            lblLangue = new Label();
            lblStatut = new Label();
            lblPrix = new Label();
            panelCote = new Panel();
            lblEtoilesCote = new Label();
            lblCoteValeur = new Label();
            lblDescriptionHeader = new Label();
            txtDescription = new TextBox();
            lblMessageConnexion = new Label();
            btnAcheter = new Button();
            btnVisionner = new Button();
            lblNotation = new Label();
            lblNote1 = new Label();
            lblNote2 = new Label();
            lblNote3 = new Label();
            lblNote4 = new Label();
            lblNote5 = new Label();
            btnSauvegarderNote = new Button();
            btnFermer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilm).BeginInit();
            panelCote.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxFilm
            // 
            pictureBoxFilm.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFilm.Location = new Point(30, 30);
            pictureBoxFilm.Margin = new Padding(3, 2, 3, 2);
            pictureBoxFilm.Name = "pictureBoxFilm";
            pictureBoxFilm.Size = new Size(250, 375);
            pictureBoxFilm.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFilm.TabIndex = 0;
            pictureBoxFilm.TabStop = false;
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitre.ForeColor = Color.White;
            lblTitre.Location = new Point(310, 30);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(450, 40);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Titre du film";
            // 
            // lblAnnee
            // 
            lblAnnee.Font = new Font("Segoe UI", 10F);
            lblAnnee.ForeColor = Color.LightGray;
            lblAnnee.Location = new Point(310, 75);
            lblAnnee.Name = "lblAnnee";
            lblAnnee.Size = new Size(450, 25);
            lblAnnee.TabIndex = 2;
            lblAnnee.Text = "Année: 2024";
            // 
            // lblRealisateur
            // 
            lblRealisateur.Font = new Font("Segoe UI", 10F);
            lblRealisateur.ForeColor = Color.LightGray;
            lblRealisateur.Location = new Point(310, 100);
            lblRealisateur.Name = "lblRealisateur";
            lblRealisateur.Size = new Size(450, 25);
            lblRealisateur.TabIndex = 3;
            lblRealisateur.Text = "Réalisateur: John Doe";
            // 
            // lblGenre
            // 
            lblGenre.Font = new Font("Segoe UI", 10F);
            lblGenre.ForeColor = Color.LightGray;
            lblGenre.Location = new Point(310, 125);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(219, 25);
            lblGenre.TabIndex = 4;
            lblGenre.Text = "Genre: Action";
            // 
            // lblDuree
            // 
            lblDuree.Font = new Font("Segoe UI", 10F);
            lblDuree.ForeColor = Color.LightGray;
            lblDuree.Location = new Point(310, 150);
            lblDuree.Name = "lblDuree";
            lblDuree.Size = new Size(219, 25);
            lblDuree.TabIndex = 5;
            lblDuree.Text = "Durée: 120 min";
            // 
            // lblLangue
            // 
            lblLangue.Font = new Font("Segoe UI", 10F);
            lblLangue.ForeColor = Color.LightGray;
            lblLangue.Location = new Point(310, 175);
            lblLangue.Name = "lblLangue";
            lblLangue.Size = new Size(226, 25);
            lblLangue.TabIndex = 6;
            lblLangue.Text = "Langue: Français";
            // 
            // lblStatut
            // 
            lblStatut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatut.ForeColor = Color.FromArgb(40, 167, 69);
            lblStatut.Location = new Point(602, 209);
            lblStatut.Name = "lblStatut";
            lblStatut.Size = new Size(158, 25);
            lblStatut.TabIndex = 7;
            lblStatut.Text = "✅ Disponible";
            // 
            // lblPrix
            // 
            lblPrix.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPrix.ForeColor = Color.FromArgb(255, 215, 0);
            lblPrix.Location = new Point(310, 204);
            lblPrix.Name = "lblPrix";
            lblPrix.Size = new Size(200, 30);
            lblPrix.TabIndex = 8;
            lblPrix.Text = "Prix: 9.99$";
            // 
            // panelCote
            // 
            panelCote.BackColor = Color.Transparent;
            panelCote.Controls.Add(lblEtoilesCote);
            panelCote.Controls.Add(lblCoteValeur);
            panelCote.Location = new Point(310, 250);
            panelCote.Margin = new Padding(3, 2, 3, 2);
            panelCote.Name = "panelCote";
            panelCote.Size = new Size(450, 35);
            panelCote.TabIndex = 9;
            // 
            // lblEtoilesCote
            // 
            lblEtoilesCote.Font = new Font("Segoe UI", 20F);
            lblEtoilesCote.ForeColor = Color.Gold;
            lblEtoilesCote.Location = new Point(86, 0);
            lblEtoilesCote.Name = "lblEtoilesCote";
            lblEtoilesCote.Size = new Size(200, 30);
            lblEtoilesCote.TabIndex = 0;
            lblEtoilesCote.Text = "★★★★☆";
            lblEtoilesCote.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCoteValeur
            // 
            lblCoteValeur.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCoteValeur.ForeColor = Color.White;
            lblCoteValeur.Location = new Point(292, 5);
            lblCoteValeur.Name = "lblCoteValeur";
            lblCoteValeur.Size = new Size(100, 25);
            lblCoteValeur.TabIndex = 1;
            lblCoteValeur.Text = "4.0/5";
            lblCoteValeur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescriptionHeader
            // 
            lblDescriptionHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescriptionHeader.ForeColor = Color.White;
            lblDescriptionHeader.Location = new Point(30, 425);
            lblDescriptionHeader.Name = "lblDescriptionHeader";
            lblDescriptionHeader.Size = new Size(730, 25);
            lblDescriptionHeader.TabIndex = 10;
            lblDescriptionHeader.Text = "Synopsis :";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(40, 40, 40);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(30, 455);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(730, 80);
            txtDescription.TabIndex = 11;
            txtDescription.Text = "Description du film...";
            // 
            // lblMessageConnexion
            // 
            lblMessageConnexion.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblMessageConnexion.ForeColor = Color.FromArgb(255, 193, 7);
            lblMessageConnexion.Location = new Point(310, 302);
            lblMessageConnexion.Name = "lblMessageConnexion";
            lblMessageConnexion.Size = new Size(421, 17);
            lblMessageConnexion.TabIndex = 12;
            lblMessageConnexion.Text = "🔒 Connectez-vous pour visualiser ou acheter ce film";
            lblMessageConnexion.Click += lblMessageConnexion_Click;
            // 
            // btnAcheter
            // 
            btnAcheter.BackColor = Color.FromArgb(0, 120, 215);
            btnAcheter.Cursor = Cursors.Hand;
            btnAcheter.FlatAppearance.BorderSize = 0;
            btnAcheter.FlatStyle = FlatStyle.Flat;
            btnAcheter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAcheter.ForeColor = Color.White;
            btnAcheter.Location = new Point(310, 337);
            btnAcheter.Margin = new Padding(3, 2, 3, 2);
            btnAcheter.Name = "btnAcheter";
            btnAcheter.Size = new Size(200, 45);
            btnAcheter.TabIndex = 13;
            btnAcheter.Text = "💳 Acheter le film";
            btnAcheter.UseVisualStyleBackColor = false;
            btnAcheter.Click += BtnAcheter_Click;
            // 
            // btnVisionner
            // 
            btnVisionner.BackColor = Color.FromArgb(46, 125, 50);
            btnVisionner.Cursor = Cursors.Hand;
            btnVisionner.FlatAppearance.BorderSize = 0;
            btnVisionner.FlatStyle = FlatStyle.Flat;
            btnVisionner.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVisionner.ForeColor = Color.White;
            btnVisionner.Location = new Point(531, 337);
            btnVisionner.Margin = new Padding(3, 2, 3, 2);
            btnVisionner.Name = "btnVisionner";
            btnVisionner.Size = new Size(200, 45);
            btnVisionner.TabIndex = 14;
            btnVisionner.Text = "▶ Visionner";
            btnVisionner.UseVisualStyleBackColor = false;
            btnVisionner.Click += BtnVisionner_Click;
            // 
            // lblNotation
            // 
            lblNotation.Location = new Point(0, 0);
            lblNotation.Name = "lblNotation";
            lblNotation.Size = new Size(100, 23);
            lblNotation.TabIndex = 0;
            // 
            // lblNote1
            // 
            lblNote1.Location = new Point(0, 0);
            lblNote1.Name = "lblNote1";
            lblNote1.Size = new Size(100, 23);
            lblNote1.TabIndex = 0;
            // 
            // lblNote2
            // 
            lblNote2.Location = new Point(0, 0);
            lblNote2.Name = "lblNote2";
            lblNote2.Size = new Size(100, 23);
            lblNote2.TabIndex = 0;
            // 
            // lblNote3
            // 
            lblNote3.Location = new Point(0, 0);
            lblNote3.Name = "lblNote3";
            lblNote3.Size = new Size(100, 23);
            lblNote3.TabIndex = 0;
            // 
            // lblNote4
            // 
            lblNote4.Location = new Point(0, 0);
            lblNote4.Name = "lblNote4";
            lblNote4.Size = new Size(100, 23);
            lblNote4.TabIndex = 0;
            // 
            // lblNote5
            // 
            lblNote5.Location = new Point(0, 0);
            lblNote5.Name = "lblNote5";
            lblNote5.Size = new Size(100, 23);
            lblNote5.TabIndex = 0;
            // 
            // btnSauvegarderNote
            // 
            btnSauvegarderNote.Location = new Point(0, 0);
            btnSauvegarderNote.Name = "btnSauvegarderNote";
            btnSauvegarderNote.Size = new Size(75, 23);
            btnSauvegarderNote.TabIndex = 0;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.FromArgb(60, 60, 60);
            btnFermer.Cursor = Cursors.Hand;
            btnFermer.FlatAppearance.BorderSize = 0;
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Segoe UI", 10F);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(630, 555);
            btnFermer.Margin = new Padding(3, 2, 3, 2);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(130, 35);
            btnFermer.TabIndex = 16;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += BtnFermer_Click;
            // 
            // DetailsFilmPublic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(808, 600);
            Controls.Add(btnFermer);
            Controls.Add(btnVisionner);
            Controls.Add(btnAcheter);
            Controls.Add(lblMessageConnexion);
            Controls.Add(txtDescription);
            Controls.Add(lblDescriptionHeader);
            Controls.Add(panelCote);
            Controls.Add(lblPrix);
            Controls.Add(lblStatut);
            Controls.Add(lblLangue);
            Controls.Add(lblDuree);
            Controls.Add(lblGenre);
            Controls.Add(lblRealisateur);
            Controls.Add(lblAnnee);
            Controls.Add(lblTitre);
            Controls.Add(pictureBoxFilm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetailsFilmPublic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisionFlix - Détails du Film";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilm).EndInit();
            panelCote.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox pictureBoxFilm;
        private Label lblTitre;
        private Label lblAnnee;
        private Label lblRealisateur;
        private Label lblGenre;
        private Label lblDuree;
        private Label lblLangue;
        private Label lblStatut;
        private Label lblPrix;
        private Panel panelCote;
        private Label lblEtoilesCote;
        private Label lblCoteValeur;
        private Label lblDescriptionHeader;
        private TextBox txtDescription;
        private Label lblMessageConnexion;
        private Button btnAcheter;
        private Button btnVisionner;
        private Label lblNotation;
        private Label lblNote1;
        private Label lblNote2;
        private Label lblNote3;
        private Label lblNote4;
        private Label lblNote5;
        private Button btnSauvegarderNote;
        private Button btnFermer;
    }
}