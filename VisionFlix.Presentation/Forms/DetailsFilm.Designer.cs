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
            pictureBoxFilm = new PictureBox();
            lblTitre = new Label();
            lblAnnee = new Label();
            lblGenre = new Label();
            lblDuree = new Label();
            lblRealisateur = new Label();
            lblPrix = new Label();
            panelCote = new Panel();
            lblCoteTexte = new Label();
            lblEtoilesCote = new Label();
            lblCoteValeur = new Label();
            lblDescriptionHeader = new Label();
            txtDescription = new TextBox();
            btnAcheter = new Button();
            btnVisionner = new Button();
            panelNotation = new Panel();
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
            panelNotation.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxFilm
            // 
            pictureBoxFilm.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFilm.Location = new Point(34, 40);
            pictureBoxFilm.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFilm.Name = "pictureBoxFilm";
            pictureBoxFilm.Size = new Size(285, 499);
            pictureBoxFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFilm.TabIndex = 0;
            pictureBoxFilm.TabStop = false;
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitre.ForeColor = Color.White;
            lblTitre.Location = new Point(354, 40);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(514, 53);
            lblTitre.TabIndex = 1;
            // 
            // lblAnnee
            // 
            lblAnnee.Font = new Font("Segoe UI", 10F);
            lblAnnee.ForeColor = Color.LightGray;
            lblAnnee.Location = new Point(354, 100);
            lblAnnee.Name = "lblAnnee";
            lblAnnee.Size = new Size(514, 33);
            lblAnnee.TabIndex = 2;
            // 
            // lblGenre
            // 
            lblGenre.Font = new Font("Segoe UI", 10F);
            lblGenre.ForeColor = Color.LightGray;
            lblGenre.Location = new Point(354, 167);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(514, 33);
            lblGenre.TabIndex = 4;
            // 
            // lblDuree
            // 
            lblDuree.Font = new Font("Segoe UI", 10F);
            lblDuree.ForeColor = Color.LightGray;
            lblDuree.Location = new Point(354, 200);
            lblDuree.Name = "lblDuree";
            lblDuree.Size = new Size(514, 33);
            lblDuree.TabIndex = 5;
            // 
            // lblRealisateur
            // 
            lblRealisateur.Font = new Font("Segoe UI", 10F);
            lblRealisateur.ForeColor = Color.LightGray;
            lblRealisateur.Location = new Point(354, 133);
            lblRealisateur.Name = "lblRealisateur";
            lblRealisateur.Size = new Size(514, 33);
            lblRealisateur.TabIndex = 3;
            // 
            // lblPrix
            // 
            lblPrix.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPrix.ForeColor = Color.FromArgb(255, 215, 0);
            lblPrix.Location = new Point(354, 240);
            lblPrix.Name = "lblPrix";
            lblPrix.Size = new Size(514, 40);
            lblPrix.TabIndex = 6;
            // 
            // panelCote
            // 
            panelCote.BackColor = Color.Transparent;
            panelCote.Controls.Add(lblCoteTexte);
            panelCote.Controls.Add(lblEtoilesCote);
            panelCote.Controls.Add(lblCoteValeur);
            panelCote.Location = new Point(354, 287);
            panelCote.Margin = new Padding(3, 4, 3, 4);
            panelCote.Name = "panelCote";
            panelCote.Size = new Size(514, 47);
            panelCote.TabIndex = 7;
            // 
            // lblCoteTexte
            // 
            lblCoteTexte.Location = new Point(0, 0);
            lblCoteTexte.Name = "lblCoteTexte";
            lblCoteTexte.Size = new Size(114, 31);
            lblCoteTexte.TabIndex = 0;
            // 
            // lblEtoilesCote
            // 
            lblEtoilesCote.Font = new Font("Segoe UI", 20F);
            lblEtoilesCote.ForeColor = Color.Gold;
            lblEtoilesCote.Location = new Point(137, 0);
            lblEtoilesCote.Name = "lblEtoilesCote";
            lblEtoilesCote.Size = new Size(229, 40);
            lblEtoilesCote.TabIndex = 1;
            lblEtoilesCote.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCoteValeur
            // 
            lblCoteValeur.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCoteValeur.ForeColor = Color.White;
            lblCoteValeur.Location = new Point(320, 7);
            lblCoteValeur.Name = "lblCoteValeur";
            lblCoteValeur.Size = new Size(114, 33);
            lblCoteValeur.TabIndex = 2;
            lblCoteValeur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescriptionHeader
            // 
            lblDescriptionHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescriptionHeader.ForeColor = Color.White;
            lblDescriptionHeader.Location = new Point(34, 567);
            lblDescriptionHeader.Name = "lblDescriptionHeader";
            lblDescriptionHeader.Size = new Size(834, 33);
            lblDescriptionHeader.TabIndex = 8;
            lblDescriptionHeader.Text = "Synopsis :";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.FromArgb(40, 40, 40);
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = Color.White;
            txtDescription.Location = new Point(34, 607);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(834, 106);
            txtDescription.TabIndex = 9;
            // 
            // btnAcheter
            // 
            btnAcheter.BackColor = Color.FromArgb(0, 120, 215);
            btnAcheter.Cursor = Cursors.Hand;
            btnAcheter.FlatAppearance.BorderSize = 0;
            btnAcheter.FlatStyle = FlatStyle.Flat;
            btnAcheter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAcheter.ForeColor = Color.White;
            btnAcheter.Location = new Point(354, 353);
            btnAcheter.Margin = new Padding(3, 4, 3, 4);
            btnAcheter.Name = "btnAcheter";
            btnAcheter.Size = new Size(229, 60);
            btnAcheter.TabIndex = 10;
            btnAcheter.Text = "💳 Acheter le film";
            btnAcheter.UseVisualStyleBackColor = false;
            // 
            // btnVisionner
            // 
            btnVisionner.BackColor = Color.FromArgb(46, 125, 50);
            btnVisionner.Cursor = Cursors.Hand;
            btnVisionner.FlatAppearance.BorderSize = 0;
            btnVisionner.FlatStyle = FlatStyle.Flat;
            btnVisionner.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVisionner.ForeColor = Color.White;
            btnVisionner.Location = new Point(606, 353);
            btnVisionner.Margin = new Padding(3, 4, 3, 4);
            btnVisionner.Name = "btnVisionner";
            btnVisionner.Size = new Size(229, 60);
            btnVisionner.TabIndex = 11;
            btnVisionner.Text = "▶ Visionner";
            btnVisionner.UseVisualStyleBackColor = false;
            // 
            // panelNotation
            // 
            panelNotation.BackColor = Color.FromArgb(30, 30, 30);
            panelNotation.BorderStyle = BorderStyle.FixedSingle;
            panelNotation.Controls.Add(lblNotation);
            panelNotation.Controls.Add(lblNote1);
            panelNotation.Controls.Add(lblNote2);
            panelNotation.Controls.Add(lblNote3);
            panelNotation.Controls.Add(lblNote4);
            panelNotation.Controls.Add(lblNote5);
            panelNotation.Controls.Add(btnSauvegarderNote);
            panelNotation.Location = new Point(354, 440);
            panelNotation.Margin = new Padding(3, 4, 3, 4);
            panelNotation.Name = "panelNotation";
            panelNotation.Size = new Size(514, 106);
            panelNotation.TabIndex = 12;
            panelNotation.Visible = false;
            // 
            // lblNotation
            // 
            lblNotation.Location = new Point(0, 0);
            lblNotation.Name = "lblNotation";
            lblNotation.Size = new Size(114, 31);
            lblNotation.TabIndex = 0;
            // 
            // lblNote1
            // 
            lblNote1.Cursor = Cursors.Hand;
            lblNote1.Font = new Font("Segoe UI", 24F);
            lblNote1.ForeColor = Color.Gray;
            lblNote1.Location = new Point(11, 53);
            lblNote1.Name = "lblNote1";
            lblNote1.Size = new Size(46, 53);
            lblNote1.TabIndex = 1;
            lblNote1.Text = "★";
            // 
            // lblNote2
            // 
            lblNote2.Cursor = Cursors.Hand;
            lblNote2.Font = new Font("Segoe UI", 24F);
            lblNote2.ForeColor = Color.Gray;
            lblNote2.Location = new Point(69, 53);
            lblNote2.Name = "lblNote2";
            lblNote2.Size = new Size(46, 53);
            lblNote2.TabIndex = 2;
            lblNote2.Text = "★";
            // 
            // lblNote3
            // 
            lblNote3.Cursor = Cursors.Hand;
            lblNote3.Font = new Font("Segoe UI", 24F);
            lblNote3.ForeColor = Color.Gray;
            lblNote3.Location = new Point(126, 53);
            lblNote3.Name = "lblNote3";
            lblNote3.Size = new Size(46, 53);
            lblNote3.TabIndex = 3;
            lblNote3.Text = "★";
            // 
            // lblNote4
            // 
            lblNote4.Cursor = Cursors.Hand;
            lblNote4.Font = new Font("Segoe UI", 24F);
            lblNote4.ForeColor = Color.Gray;
            lblNote4.Location = new Point(183, 53);
            lblNote4.Name = "lblNote4";
            lblNote4.Size = new Size(46, 53);
            lblNote4.TabIndex = 4;
            lblNote4.Text = "★";
            // 
            // lblNote5
            // 
            lblNote5.Cursor = Cursors.Hand;
            lblNote5.Font = new Font("Segoe UI", 24F);
            lblNote5.ForeColor = Color.Gray;
            lblNote5.Location = new Point(240, 53);
            lblNote5.Name = "lblNote5";
            lblNote5.Size = new Size(46, 53);
            lblNote5.TabIndex = 5;
            lblNote5.Text = "★";
            // 
            // btnSauvegarderNote
            // 
            btnSauvegarderNote.BackColor = Color.FromArgb(0, 120, 215);
            btnSauvegarderNote.Cursor = Cursors.Hand;
            btnSauvegarderNote.FlatAppearance.BorderSize = 0;
            btnSauvegarderNote.FlatStyle = FlatStyle.Flat;
            btnSauvegarderNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSauvegarderNote.ForeColor = Color.White;
            btnSauvegarderNote.Location = new Point(309, 53);
            btnSauvegarderNote.Margin = new Padding(3, 4, 3, 4);
            btnSauvegarderNote.Name = "btnSauvegarderNote";
            btnSauvegarderNote.Size = new Size(183, 47);
            btnSauvegarderNote.TabIndex = 0;
            btnSauvegarderNote.Text = "Sauvegarder";
            btnSauvegarderNote.UseVisualStyleBackColor = false;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.FromArgb(60, 60, 60);
            btnFermer.Cursor = Cursors.Hand;
            btnFermer.FlatAppearance.BorderSize = 0;
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Segoe UI", 10F);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(720, 740);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(149, 47);
            btnFermer.TabIndex = 13;
            btnFermer.Text = "Fermer";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += BtnFermer_Click;
            // 
            // DetailsFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(914, 800);
            Controls.Add(pictureBoxFilm);
            Controls.Add(lblTitre);
            Controls.Add(lblAnnee);
            Controls.Add(lblRealisateur);
            Controls.Add(lblGenre);
            Controls.Add(lblDuree);
            Controls.Add(lblPrix);
            Controls.Add(panelCote);
            Controls.Add(lblDescriptionHeader);
            Controls.Add(txtDescription);
            Controls.Add(btnAcheter);
            Controls.Add(btnVisionner);
            Controls.Add(panelNotation);
            Controls.Add(btnFermer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "DetailsFilm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisionFlix - Détails du film";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilm).EndInit();
            panelCote.ResumeLayout(false);
            panelNotation.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCoteTexte;
        private Label lblNotation;
    }
}