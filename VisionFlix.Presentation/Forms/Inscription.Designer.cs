namespace VisionFlix.Presentation.Forms
{
	partial class Inscription
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            label1 = new Label();
            nom = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Name = "label1";
            // 
            // nom
            // 
            resources.ApplyResources(nom, "nom");
            nom.Name = "nom";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            resources.ApplyResources(textBox4, "textBox4");
            textBox4.Name = "textBox4";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // textBox5
            // 
            resources.ApplyResources(textBox5, "textBox5");
            textBox5.Name = "textBox5";
            // 
            // textBox6
            // 
            resources.ApplyResources(textBox6, "textBox6");
            textBox6.Name = "textBox6";
            // 
            // textBox7
            // 
            resources.ApplyResources(textBox7, "textBox7");
            textBox7.Name = "textBox7";
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.BackColor = Color.FromArgb(200, 50, 50);
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Name = "label2";
            // 
            // linkLabel2
            // 
            resources.ApplyResources(linkLabel2, "linkLabel2");
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.TabStop = true;
            // 
            // Inscription
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(linkLabel2);
            Controls.Add(btnLogin);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(nom);
            Controls.Add(label1);
            Name = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private TextBox nom;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox1;
		private TextBox textBox5;
		private TextBox textBox6;
		private TextBox textBox7;
		private Button btnLogin;
		private Label label2;
		private LinkLabel linkLabel2;
	}
}