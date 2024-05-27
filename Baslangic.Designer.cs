namespace DisProje01
{
    partial class Baslangic
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baslangic));
            logo = new PictureBox();
            label1 = new Label();
            BaslangicprogressBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(123, 40);
            logo.Name = "logo";
            logo.Size = new Size(123, 111);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(64, 196);
            label1.Name = "label1";
            label1.Size = new Size(241, 31);
            label1.TabIndex = 28;
            label1.Text = "SİRİUS DİŞ KLİNİĞİ";
            // 
            // BaslangicprogressBar
            // 
            BaslangicprogressBar.Location = new Point(71, 273);
            BaslangicprogressBar.Name = "BaslangicprogressBar";
            BaslangicprogressBar.Size = new Size(227, 29);
            BaslangicprogressBar.TabIndex = 29;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Baslangic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(367, 380);
            Controls.Add(BaslangicprogressBar);
            Controls.Add(label1);
            Controls.Add(logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Baslangic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Başlangiç";
            Load += Başlangiç_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label label1;
        private ProgressBar BaslangicprogressBar;
        private System.Windows.Forms.Timer timer1;
    }
}