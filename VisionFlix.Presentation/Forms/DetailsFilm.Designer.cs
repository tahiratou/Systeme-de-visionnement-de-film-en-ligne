using System.Drawing;

namespace VisionFlix.Presentation.Forms
{
    partial class DetailsFilm
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBoxFilm;
        private Label lblTitre;
        private Label lblAnnee;
        private Label lblGenre;
        private Label lblDuree;
        private Label lblRealisateur;
        private Label lblPrix;
        private Panel panelCote;
        private Label lblEtoilesCote;
        private Label lblCoteValeur;
        private Label lblDescriptionHeader;
        private TextBox txtDescription;
        private Button btnAcheter;
        private Button btnVisionner;
        private Panel panelNotation;
        private Button btnSauvegarderNote;
        private Button btnFermer;
        private Label lblNote1;
        private Label lblNote2;
        private Label lblNote3;
        private Label lblNote4;
        private Label lblNote5;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBoxFilm = new PictureBox();
            this.lblTitre = new Label();
            this.lblAnnee = new Label();
            this.lblGenre = new Label();
            this.lblDuree = new Label();
            this.lblRealisateur = new Label();
            this.lblPrix = new Label();
            this.panelCote = new Panel();
            this.lblEtoilesCote = new Label();
            this.lblCoteValeur = new Label();
            this.lblDescriptionHeader = new Label();
            this.txtDescription = new TextBox();
            this.btnAcheter = new Button();
            this.btnVisionner = new Button();
            this.panelNotation = new Panel();
            this.btnSauvegarderNote = new Button();
            this.btnFermer = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).BeginInit();
            this.panelCote.SuspendLayout();
            this.panelNotation.SuspendLayout();
            this.SuspendLayout();

            // 
            // DetailsFilm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "VisionFlix - Détails du film";
            this.BackColor = Color.FromArgb(20, 20, 20);

            // 
            // pictureBoxFilm
            // 
            this.pictureBoxFilm.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBoxFilm.Location = new Point(30, 30);
            this.pictureBoxFilm.Name = "pictureBoxFilm";
            this.pictureBoxFilm.Size = new Size(250, 375);
            this.pictureBoxFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxFilm.TabIndex = 0;
            this.pictureBoxFilm.TabStop = false;

            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = false;
            this.lblTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitre.ForeColor = Color.White;
            this.lblTitre.Location = new Point(310, 30);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new Size(450, 40);
            this.lblTitre.TabIndex = 1;

            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = false;
            this.lblAnnee.Font = new Font("Segoe UI", 10F);
            this.lblAnnee.ForeColor = Color.LightGray;
            this.lblAnnee.Location = new Point(310, 75);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new Size(450, 25);
            this.lblAnnee.TabIndex = 2;

            // 
            // lblRealisateur
            // 
            this.lblRealisateur.AutoSize = false;
            this.lblRealisateur.Font = new Font("Segoe UI", 10F);
            this.lblRealisateur.ForeColor = Color.LightGray;
            this.lblRealisateur.Location = new Point(310, 100);
            this.lblRealisateur.Name = "lblRealisateur";
            this.lblRealisateur.Size = new Size(450, 25);
            this.lblRealisateur.TabIndex = 3;

            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = false;
            this.lblGenre.Font = new Font("Segoe UI", 10F);
            this.lblGenre.ForeColor = Color.LightGray;
            this.lblGenre.Location = new Point(310, 125);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new Size(450, 25);
            this.lblGenre.TabIndex = 4;

            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = false;
            this.lblDuree.Font = new Font("Segoe UI", 10F);
            this.lblDuree.ForeColor = Color.LightGray;
            this.lblDuree.Location = new Point(310, 150);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new Size(450, 25);
            this.lblDuree.TabIndex = 5;

            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = false;
            this.lblPrix.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblPrix.ForeColor = Color.FromArgb(255, 215, 0);
            this.lblPrix.Location = new Point(310, 180);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new Size(450, 30);
            this.lblPrix.TabIndex = 6;

            // 
            // panelCote
            // 
            this.panelCote.BackColor = Color.Transparent;
            this.panelCote.Location = new Point(310, 215);
            this.panelCote.Name = "panelCote";
            this.panelCote.Size = new Size(450, 35);
            this.panelCote.TabIndex = 7;

            // 
            // lblEtoilesCote
            // 
            this.lblEtoilesCote.Font = new Font("Segoe UI", 20F);
            this.lblEtoilesCote.ForeColor = Color.Gold;
            this.lblEtoilesCote.Location = new Point(120, 0);
            this.lblEtoilesCote.Name = "lblEtoilesCote";
            this.lblEtoilesCote.Size = new Size(200, 30);
            this.lblEtoilesCote.TabIndex = 1;
            this.lblEtoilesCote.TextAlign = ContentAlignment.MiddleRight;

            // 
            // lblCoteValeur
            // 
            this.lblCoteValeur.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblCoteValeur.ForeColor = Color.White;
            this.lblCoteValeur.Location = new Point(280, 5);
            this.lblCoteValeur.Name = "lblCoteValeur";
            this.lblCoteValeur.Size = new Size(100, 25);
            this.lblCoteValeur.TabIndex = 2;
            this.lblCoteValeur.TextAlign = ContentAlignment.MiddleRight;

            // 
            // panelCote controls
            // 
            Label lblCoteTexte = new Label
            {
                Text = "Note moyenne :",
                Location = new Point(0, 5),
                Size = new Size(120, 25),
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.LightGray
            };
            this.panelCote.Controls.Add(lblCoteTexte);
            this.panelCote.Controls.Add(this.lblEtoilesCote);
            this.panelCote.Controls.Add(this.lblCoteValeur);

            // 
            // lblDescriptionHeader
            // 
            this.lblDescriptionHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblDescriptionHeader.ForeColor = Color.White;
            this.lblDescriptionHeader.Location = new Point(30, 425);
            this.lblDescriptionHeader.Name = "lblDescriptionHeader";
            this.lblDescriptionHeader.Size = new Size(730, 25);
            this.lblDescriptionHeader.TabIndex = 8;
            this.lblDescriptionHeader.Text = "Synopsis :";

            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = Color.FromArgb(40, 40, 40);
            this.txtDescription.BorderStyle = BorderStyle.FixedSingle;
            this.txtDescription.Font = new Font("Segoe UI", 10F);
            this.txtDescription.ForeColor = Color.White;
            this.txtDescription.Location = new Point(30, 455);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = ScrollBars.Vertical;
            this.txtDescription.Size = new Size(730, 80);
            this.txtDescription.TabIndex = 9;

            // 
            // btnAcheter
            // 
            this.btnAcheter.BackColor = Color.FromArgb(0, 120, 215);
            this.btnAcheter.Cursor = Cursors.Hand;
            this.btnAcheter.FlatStyle = FlatStyle.Flat;
            this.btnAcheter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnAcheter.ForeColor = Color.White;
            this.btnAcheter.Location = new Point(310, 265);
            this.btnAcheter.Name = "btnAcheter";
            this.btnAcheter.Size = new Size(200, 45);
            this.btnAcheter.TabIndex = 10;
            this.btnAcheter.Text = "💳 Acheter le film";
            this.btnAcheter.UseVisualStyleBackColor = false;
            this.btnAcheter.FlatAppearance.BorderSize = 0;

            // 
            // btnVisionner
            // 
            this.btnVisionner.BackColor = Color.FromArgb(46, 125, 50);
            this.btnVisionner.Cursor = Cursors.Hand;
            this.btnVisionner.FlatStyle = FlatStyle.Flat;
            this.btnVisionner.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnVisionner.ForeColor = Color.White;
            this.btnVisionner.Location = new Point(530, 265);
            this.btnVisionner.Name = "btnVisionner";
            this.btnVisionner.Size = new Size(200, 45);
            this.btnVisionner.TabIndex = 11;
            this.btnVisionner.Text = "▶ Visionner";
            this.btnVisionner.UseVisualStyleBackColor = false;
            this.btnVisionner.FlatAppearance.BorderSize = 0;

            // 
            // panelNotation
            // 
            this.panelNotation.BackColor = Color.FromArgb(30, 30, 30);
            this.panelNotation.BorderStyle = BorderStyle.FixedSingle;
            this.panelNotation.Location = new Point(310, 330);
            this.panelNotation.Name = "panelNotation";
            this.panelNotation.Size = new Size(450, 80);
            this.panelNotation.TabIndex = 12;
            this.panelNotation.Visible = false;

            // 
            // panelNotation controls
            // 
            Label lblNotation = new Label
            {
                Text = "Votre note :",
                Location = new Point(10, 10),
                Size = new Size(100, 25),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.White
            };
            this.lblNote1 = new Label();
            this.lblNote2 = new Label();
            this.lblNote3 = new Label();
            this.lblNote4 = new Label();
            this.lblNote5 = new Label();

            this.panelNotation.Controls.Add(lblNotation);
            this.panelNotation.Controls.Add(this.lblNote1);
            this.panelNotation.Controls.Add(this.lblNote2);
            this.panelNotation.Controls.Add(this.lblNote3);
            this.panelNotation.Controls.Add(this.lblNote4);
            this.panelNotation.Controls.Add(this.lblNote5);

            // 
            // lblNote1
            // 
            this.lblNote1.Cursor = Cursors.Hand;
            this.lblNote1.Font = new Font("Segoe UI", 24F);
            this.lblNote1.ForeColor = Color.Gray;
            this.lblNote1.Location = new Point(10, 40);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.Size = new Size(40, 40);
            this.lblNote1.Text = "★";
            // 
            // lblNote2
            // 
            this.lblNote2.Cursor = Cursors.Hand;
            this.lblNote2.Font = new Font("Segoe UI", 24F);
            this.lblNote2.ForeColor = Color.Gray;
            this.lblNote2.Location = new Point(60, 40);
            this.lblNote2.Name = "lblNote2";
            this.lblNote2.Size = new Size(40, 40);
            this.lblNote2.Text = "★";
            // 
            // lblNote3
            // 
            this.lblNote3.Cursor = Cursors.Hand;
            this.lblNote3.Font = new Font("Segoe UI", 24F);
            this.lblNote3.ForeColor = Color.Gray;
            this.lblNote3.Location = new Point(110, 40);
            this.lblNote3.Name = "lblNote3";
            this.lblNote3.Size = new Size(40, 40);
            this.lblNote3.Text = "★";
            // 
            // lblNote4
            // 
            this.lblNote4.Cursor = Cursors.Hand;
            this.lblNote4.Font = new Font("Segoe UI", 24F);
            this.lblNote4.ForeColor = Color.Gray;
            this.lblNote4.Location = new Point(160, 40);
            this.lblNote4.Name = "lblNote4";
            this.lblNote4.Size = new Size(40, 40);
            this.lblNote4.Text = "★";
            // 
            // lblNote5
            // 
            this.lblNote5.Cursor = Cursors.Hand;
            this.lblNote5.Font = new Font("Segoe UI", 24F);
            this.lblNote5.ForeColor = Color.Gray;
            this.lblNote5.Location = new Point(210, 40);
            this.lblNote5.Name = "lblNote5";
            this.lblNote5.Size = new Size(40, 40);
            this.lblNote5.Text = "★";

            // 
            // btnSauvegarderNote
            // 
            this.btnSauvegarderNote.BackColor = Color.FromArgb(0, 120, 215);
            this.btnSauvegarderNote.Cursor = Cursors.Hand;
            this.btnSauvegarderNote.FlatStyle = FlatStyle.Flat;
            this.btnSauvegarderNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btnSauvegarderNote.ForeColor = Color.White;
            this.btnSauvegarderNote.Location = new Point(270, 40);
            this.btnSauvegarderNote.Name = "btnSauvegarderNote";
            this.btnSauvegarderNote.Size = new Size(160, 35);
            this.btnSauvegarderNote.TabIndex = 0;
            this.btnSauvegarderNote.Text = "Sauvegarder";
            this.btnSauvegarderNote.UseVisualStyleBackColor = false;
            this.btnSauvegarderNote.FlatAppearance.BorderSize = 0;
            this.panelNotation.Controls.Add(this.btnSauvegarderNote);

            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = Color.FromArgb(60, 60, 60);
            this.btnFermer.Cursor = Cursors.Hand;
            this.btnFermer.FlatStyle = FlatStyle.Flat;
            this.btnFermer.Font = new Font("Segoe UI", 10F);
            this.btnFermer.ForeColor = Color.White;
            this.btnFermer.Location = new Point(630, 555);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new Size(130, 35);
            this.btnFermer.TabIndex = 13;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);

            // 
            // Add all controls to form
            // 
            this.Controls.Add(this.pictureBoxFilm);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblAnnee);
            this.Controls.Add(this.lblRealisateur);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.panelCote);
            this.Controls.Add(this.lblDescriptionHeader);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnAcheter);
            this.Controls.Add(this.btnVisionner);
            this.Controls.Add(this.panelNotation);
            this.Controls.Add(this.btnFermer);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).EndInit();
            this.panelCote.ResumeLayout(false);
            this.panelNotation.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}