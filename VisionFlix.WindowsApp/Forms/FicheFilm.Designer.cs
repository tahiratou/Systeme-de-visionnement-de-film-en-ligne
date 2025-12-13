namespace VisionFlix.WindowsApp.Forms
{
    partial class FicheFilm
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panelCard = new Panel();
            picThumbnail = new PictureBox();
            panelInfo = new Panel();
            lblTitle = new Label();
            lblYear = new Label();
            lblRating = new Label();
            lblDirector = new Label();
            lblDuration = new Label();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picThumbnail).BeginInit();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.FromArgb(25, 25, 25);
            panelCard.Controls.Add(picThumbnail);
            panelCard.Controls.Add(panelInfo);
            panelCard.Cursor = Cursors.Hand;
            panelCard.Location = new Point(0, 0);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(200, 320);
            panelCard.TabIndex = 0;
            // 
            // picThumbnail
            // 
            picThumbnail.BackColor = Color.FromArgb(40, 40, 40);
            picThumbnail.Dock = DockStyle.Top;
            picThumbnail.Location = new Point(0, 0);
            picThumbnail.Name = "picThumbnail";
            picThumbnail.Size = new Size(200, 240);
            picThumbnail.SizeMode = PictureBoxSizeMode.StretchImage;
            picThumbnail.TabIndex = 0;
            picThumbnail.TabStop = false;
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(lblTitle);
            panelInfo.Controls.Add(lblYear);
            panelInfo.Controls.Add(lblRating);
            panelInfo.Controls.Add(lblDirector);
            panelInfo.Controls.Add(lblDuration);
            panelInfo.Dock = DockStyle.Bottom;
            panelInfo.Location = new Point(0, 240);
            panelInfo.Name = "panelInfo";
            panelInfo.Padding = new Padding(8);
            panelInfo.Size = new Size(200, 80);
            panelInfo.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(8, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(184, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Titre du Film";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 8F);
            lblYear.ForeColor = Color.LightGray;
            lblYear.Location = new Point(8, 30);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(31, 13);
            lblYear.TabIndex = 1;
            lblYear.Text = "2024";
            // 
            // lblRating
            // 
            lblRating.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRating.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRating.ForeColor = Color.FromArgb(255, 200, 50);
            lblRating.Location = new Point(120, 28);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(72, 15);
            lblRating.TabIndex = 2;
            lblRating.Text = "★★★★☆";
            lblRating.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblDirector.ForeColor = Color.Silver;
            lblDirector.Location = new Point(8, 47);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(89, 13);
            lblDirector.TabIndex = 3;
            lblDirector.Text = "Réalisateur (trice)";
            // 
            // lblDuration
            // 
            lblDuration.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDuration.Font = new Font("Segoe UI", 7F);
            lblDuration.ForeColor = Color.Gray;
            lblDuration.Location = new Point(120, 47);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(72, 13);
            lblDuration.TabIndex = 4;
            lblDuration.Text = "120 min";
            lblDuration.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FicheFilm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelCard);
            Name = "FicheFilm";
            Size = new Size(200, 320);
            panelCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picThumbnail).EndInit();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.PictureBox picThumbnail;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblDuration;
    }
}