namespace VisionFlix.WindowsApp.Forms
{
    partial class Accueil
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            panelTop = new Panel();
            btnProfil = new Button();
            lblTitle = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panelSidebar = new Panel();
            lblFilters = new Label();
            cmbGenre = new ComboBox();
            lblGenre = new Label();
            cmbYear = new ComboBox();
            lblYear = new Label();
            cmbRating = new ComboBox();
            lblRating = new Label();
            btnApplyFilters = new Button();
            btnResetFilters = new Button();
            flowLayoutPanelMovies = new FlowLayoutPanel();
            panelBottom = new Panel();
            lblStatus = new Label();
            panelTop.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(20, 20, 20);
            panelTop.BackgroundImageLayout = ImageLayout.Stretch;
            panelTop.Controls.Add(btnProfil);
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(btnSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 5, 4, 5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1714, 133);
            panelTop.TabIndex = 0;
            // 
            // btnProfil
            // 
            btnProfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfil.BackColor = Color.FromArgb(200, 50, 50);
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnProfil.ForeColor = Color.White;
            btnProfil.Location = new Point(1636, 42);
            btnProfil.Margin = new Padding(4, 5, 4, 5);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(50, 48);
            btnProfil.TabIndex = 3;
            btnProfil.Text = "👤";
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += BtnProfil_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(29, 33);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(247, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "VisionFlix";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(1171, 42);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Rechercher un film...";
            txtSearch.Size = new Size(355, 39);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(200, 50, 50);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1543, 42);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(50, 48);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍︎";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(30, 30, 30);
            panelSidebar.BackgroundImageLayout = ImageLayout.Stretch;
            panelSidebar.Controls.Add(lblFilters);
            panelSidebar.Controls.Add(cmbGenre);
            panelSidebar.Controls.Add(lblGenre);
            panelSidebar.Controls.Add(cmbYear);
            panelSidebar.Controls.Add(lblYear);
            panelSidebar.Controls.Add(cmbRating);
            panelSidebar.Controls.Add(lblRating);
            panelSidebar.Controls.Add(btnApplyFilters);
            panelSidebar.Controls.Add(btnResetFilters);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 133);
            panelSidebar.Margin = new Padding(4, 5, 4, 5);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(357, 917);
            panelSidebar.TabIndex = 1;
            // 
            // lblFilters
            // 
            lblFilters.AutoSize = true;
            lblFilters.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFilters.ForeColor = Color.White;
            lblFilters.Location = new Point(29, 33);
            lblFilters.Margin = new Padding(4, 0, 4, 0);
            lblFilters.Name = "lblFilters";
            lblFilters.Size = new Size(97, 38);
            lblFilters.TabIndex = 0;
            lblFilters.Text = "Filtres";
            // 
            // cmbGenre
            // 
            cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenre.Font = new Font("Segoe UI", 10F);
            cmbGenre.FormattingEnabled = true;
            cmbGenre.Items.AddRange(new object[] { "Tous", "Action", "Comédie", "Drame", "Science-Fiction", "Thriller", "Horreur", "Romance", "Documentaire" });
            cmbGenre.Location = new Point(29, 150);
            cmbGenre.Margin = new Padding(4, 5, 4, 5);
            cmbGenre.Name = "cmbGenre";
            cmbGenre.Size = new Size(298, 36);
            cmbGenre.TabIndex = 2;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.BackColor = Color.Transparent;
            lblGenre.Font = new Font("Segoe UI", 10F);
            lblGenre.ForeColor = Color.LightGray;
            lblGenre.Location = new Point(29, 108);
            lblGenre.Margin = new Padding(4, 0, 4, 0);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(64, 28);
            lblGenre.TabIndex = 1;
            lblGenre.Text = "Genre";
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.Font = new Font("Segoe UI", 10F);
            cmbYear.FormattingEnabled = true;
            cmbYear.Items.AddRange(new object[] { "Toutes", "2024", "2023", "2022", "2021", "2020", "2010-2019", "2000-2009", "1990-1999", "Classiques" });
            cmbYear.Location = new Point(29, 267);
            cmbYear.Margin = new Padding(4, 5, 4, 5);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(298, 36);
            cmbYear.TabIndex = 4;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.BackColor = Color.Transparent;
            lblYear.Font = new Font("Segoe UI", 10F);
            lblYear.ForeColor = Color.LightGray;
            lblYear.Location = new Point(29, 225);
            lblYear.Margin = new Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(67, 28);
            lblYear.TabIndex = 3;
            lblYear.Text = "Année";
            // 
            // cmbRating
            // 
            cmbRating.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRating.Font = new Font("Segoe UI", 10F);
            cmbRating.FormattingEnabled = true;
            cmbRating.Items.AddRange(new object[] { "Toutes", "★★★★★ (5.0)", "★★★★☆ (4.0+)", "★★★☆☆ (3.0+)", "★★☆☆☆ (2.0+)" });
            cmbRating.Location = new Point(29, 383);
            cmbRating.Margin = new Padding(4, 5, 4, 5);
            cmbRating.Name = "cmbRating";
            cmbRating.Size = new Size(298, 36);
            cmbRating.TabIndex = 6;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.BackColor = Color.Transparent;
            lblRating.Font = new Font("Segoe UI", 10F);
            lblRating.ForeColor = Color.LightGray;
            lblRating.Location = new Point(29, 342);
            lblRating.Margin = new Padding(4, 0, 4, 0);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(127, 28);
            lblRating.TabIndex = 5;
            lblRating.Text = "Note critique";
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.FromArgb(200, 50, 50);
            btnApplyFilters.FlatStyle = FlatStyle.Flat;
            btnApplyFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnApplyFilters.ForeColor = Color.White;
            btnApplyFilters.Location = new Point(29, 483);
            btnApplyFilters.Margin = new Padding(4, 5, 4, 5);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(300, 58);
            btnApplyFilters.TabIndex = 7;
            btnApplyFilters.Text = "Appliquer";
            btnApplyFilters.UseVisualStyleBackColor = false;
            // 
            // btnResetFilters
            // 
            btnResetFilters.BackColor = Color.FromArgb(60, 60, 60);
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI", 9F);
            btnResetFilters.ForeColor = Color.White;
            btnResetFilters.Location = new Point(29, 558);
            btnResetFilters.Margin = new Padding(4, 5, 4, 5);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(300, 50);
            btnResetFilters.TabIndex = 8;
            btnResetFilters.Text = "Réinitialiser";
            btnResetFilters.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanelMovies
            // 
            flowLayoutPanelMovies.AutoScroll = true;
            flowLayoutPanelMovies.BackColor = Color.FromArgb(15, 15, 15);
            flowLayoutPanelMovies.BackgroundImage = (Image)resources.GetObject("flowLayoutPanelMovies.BackgroundImage");
            flowLayoutPanelMovies.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanelMovies.Dock = DockStyle.Fill;
            flowLayoutPanelMovies.Location = new Point(357, 133);
            flowLayoutPanelMovies.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanelMovies.Name = "flowLayoutPanelMovies";
            flowLayoutPanelMovies.Padding = new Padding(29, 33, 29, 33);
            flowLayoutPanelMovies.Size = new Size(1357, 867);
            flowLayoutPanelMovies.TabIndex = 2;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(20, 20, 20);
            panelBottom.Controls.Add(lblStatus);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(357, 1000);
            panelBottom.Margin = new Padding(4, 5, 4, 5);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1357, 50);
            panelBottom.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.LightGray;
            lblStatus.Location = new Point(29, 13);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(206, 25);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "0 films dans la collection";
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1714, 1050);
            Controls.Add(flowLayoutPanelMovies);
            Controls.Add(panelBottom);
            Controls.Add(panelSidebar);
            Controls.Add(panelTop);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1419, 959);
            Name = "Accueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisionFlix - Accueil";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMovies;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblStatus;
        private Button btnProfil;
    }
}