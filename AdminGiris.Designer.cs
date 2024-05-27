namespace DisProje01
{
    partial class AdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
            panel1 = new Panel();
            label2 = new Label();
            logo = new PictureBox();
            AdminSifreTb = new TextBox();
            SifregosterTb = new Button();
            label3 = new Label();
            AdminGirisBtn = new Button();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 139, 180);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(logo);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 110);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(337, 1);
            label2.Name = "label2";
            label2.Size = new Size(27, 29);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(143, 11);
            logo.Name = "logo";
            logo.Size = new Size(95, 82);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // AdminSifreTb
            // 
            AdminSifreTb.BackColor = SystemColors.Window;
            AdminSifreTb.Location = new Point(118, 195);
            AdminSifreTb.Name = "AdminSifreTb";
            AdminSifreTb.PasswordChar = '*';
            AdminSifreTb.Size = new Size(190, 27);
            AdminSifreTb.TabIndex = 24;
            // 
            // SifregosterTb
            // 
            SifregosterTb.BackColor = Color.White;
            SifregosterTb.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SifregosterTb.ForeColor = Color.Gray;
            SifregosterTb.Location = new Point(129, 231);
            SifregosterTb.Name = "SifregosterTb";
            SifregosterTb.Size = new Size(165, 30);
            SifregosterTb.TabIndex = 23;
            SifregosterTb.Text = "Şifreyi Göster";
            SifregosterTb.UseVisualStyleBackColor = false;
            SifregosterTb.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(22, 195);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 22;
            label3.Text = "Şifre:";
            // 
            // AdminGirisBtn
            // 
            AdminGirisBtn.BackColor = Color.LightSkyBlue;
            AdminGirisBtn.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            AdminGirisBtn.ForeColor = Color.Transparent;
            AdminGirisBtn.Location = new Point(118, 280);
            AdminGirisBtn.Name = "AdminGirisBtn";
            AdminGirisBtn.Size = new Size(136, 52);
            AdminGirisBtn.TabIndex = 25;
            AdminGirisBtn.Text = "GİRİŞ";
            AdminGirisBtn.UseVisualStyleBackColor = false;
            AdminGirisBtn.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(156, 335);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 26;
            label4.Text = "İptal";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(67, 134);
            label1.Name = "label1";
            label1.Size = new Size(241, 31);
            label1.TabIndex = 27;
            label1.Text = "SİRİUS DİŞ KLİNİĞİ";
            // 
            // AdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(368, 375);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(AdminGirisBtn);
            Controls.Add(AdminSifreTb);
            Controls.Add(SifregosterTb);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminGiris";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox logo;
        private TextBox AdminSifreTb;
        private Button SifregosterTb;
        private Label label3;
        private Button AdminGirisBtn;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}