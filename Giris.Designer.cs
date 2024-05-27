namespace DisProje01
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            button3 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            logo = new PictureBox();
            label1 = new Label();
            KullaniciAdiTb = new TextBox();
            GirisSifreTb = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Gray;
            button3.Location = new Point(191, 281);
            button3.Name = "button3";
            button3.Size = new Size(165, 30);
            button3.TabIndex = 20;
            button3.Text = "Şifreyi Göster";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(143, 364);
            button1.Name = "button1";
            button1.Size = new Size(136, 52);
            button1.TabIndex = 18;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(102, 246);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 14;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(14, 202);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 13;
            label2.Text = "Kullanıcı Adı:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 139, 180);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(logo);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 110);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(389, 0);
            label5.Name = "label5";
            label5.Size = new Size(27, 29);
            label5.TabIndex = 3;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(163, 11);
            logo.Name = "logo";
            logo.Size = new Size(95, 82);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(111, 131);
            label1.Name = "label1";
            label1.Size = new Size(241, 31);
            label1.TabIndex = 0;
            label1.Text = "SİRİUS DİŞ KLİNİĞİ";
            // 
            // KullaniciAdiTb
            // 
            KullaniciAdiTb.CharacterCasing = CharacterCasing.Upper;
            KullaniciAdiTb.Cursor = Cursors.IBeam;
            KullaniciAdiTb.Location = new Point(180, 197);
            KullaniciAdiTb.Name = "KullaniciAdiTb";
            KullaniciAdiTb.Size = new Size(190, 30);
            KullaniciAdiTb.TabIndex = 21;
            // 
            // GirisSifreTb
            // 
            GirisSifreTb.BackColor = SystemColors.Window;
            GirisSifreTb.Location = new Point(180, 245);
            GirisSifreTb.Name = "GirisSifreTb";
            GirisSifreTb.PasswordChar = '*';
            GirisSifreTb.Size = new Size(190, 30);
            GirisSifreTb.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(164, 419);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 22;
            label4.Text = "Admin";
            label4.Click += label4_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 479);
            Controls.Add(label4);
            Controls.Add(GirisSifreTb);
            Controls.Add(label1);
            Controls.Add(KullaniciAdiTb);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(720, 580);
            Margin = new Padding(4);
            Name = "Giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Giris_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button1;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private PictureBox logo;
        private Label label1;
        private TextBox KullaniciAdiTb;
        private TextBox GirisSifreTb;
        private Label label4;
        private Label label5;
    }
}