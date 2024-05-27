namespace DisProje01
{
    partial class Randevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randevu));
            label10 = new Label();
            groupBox2 = new GroupBox();
            RandevuDGV = new DataGridView();
            groupBox1 = new GroupBox();
            HastaCb = new ComboBox();
            TedaviCb = new ComboBox();
            Saat = new DateTimePicker();
            Tarih = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            pictureBox8 = new PictureBox();
            label17 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            logo = new PictureBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RandevuDGV).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bell MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(293, 9);
            label10.Name = "label10";
            label10.Size = new Size(190, 39);
            label10.TabIndex = 4;
            label10.Tag = "Hasta";
            label10.Text = "RANDEVU";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RandevuDGV);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(289, 380);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(905, 279);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hasta Adına Göre Filtreleme";
            // 
            // RandevuDGV
            // 
            RandevuDGV.BackgroundColor = Color.White;
            RandevuDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RandevuDGV.Cursor = Cursors.Hand;
            RandevuDGV.Location = new Point(11, 31);
            RandevuDGV.Name = "RandevuDGV";
            RandevuDGV.RowHeadersWidth = 51;
            RandevuDGV.RowTemplate.Height = 29;
            RandevuDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RandevuDGV.Size = new Size(883, 241);
            RandevuDGV.TabIndex = 1;
            RandevuDGV.CellContentClick += RandevuDGV_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(HastaCb);
            groupBox1.Controls.Add(TedaviCb);
            groupBox1.Controls.Add(Saat);
            groupBox1.Controls.Add(Tarih);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(289, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(909, 305);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bilgiler";
            // 
            // HastaCb
            // 
            HastaCb.FormattingEnabled = true;
            HastaCb.Location = new Point(208, 35);
            HastaCb.Name = "HastaCb";
            HastaCb.Size = new Size(151, 36);
            HastaCb.TabIndex = 8;
            // 
            // TedaviCb
            // 
            TedaviCb.FormattingEnabled = true;
            TedaviCb.Location = new Point(208, 125);
            TedaviCb.Name = "TedaviCb";
            TedaviCb.Size = new Size(151, 36);
            TedaviCb.TabIndex = 7;
            // 
            // Saat
            // 
            Saat.Format = DateTimePickerFormat.Time;
            Saat.Location = new Point(676, 129);
            Saat.Name = "Saat";
            Saat.Size = new Size(161, 34);
            Saat.TabIndex = 6;
            Saat.Value = new DateTime(2023, 12, 6, 22, 51, 0, 0);
            // 
            // Tarih
            // 
            Tarih.Checked = false;
            Tarih.Format = DateTimePickerFormat.Short;
            Tarih.Location = new Point(676, 34);
            Tarih.Name = "Tarih";
            Tarih.Size = new Size(161, 34);
            Tarih.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.ForeColor = Color.White;
            button2.Location = new Point(401, 243);
            button2.Name = "button2";
            button2.Size = new Size(117, 43);
            button2.TabIndex = 5;
            button2.Text = "GÜNCELLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            button3.Location = new Point(554, 243);
            button3.Name = "button3";
            button3.Size = new Size(117, 43);
            button3.TabIndex = 5;
            button3.Text = "İPTAL";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.Location = new Point(251, 243);
            button1.Name = "button1";
            button1.Size = new Size(117, 43);
            button1.TabIndex = 5;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bell MT", 14.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(567, 132);
            label15.Name = "label15";
            label15.Size = new Size(84, 29);
            label15.TabIndex = 3;
            label15.Tag = "Hasta";
            label15.Text = "SAAT:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bell MT", 14.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(554, 40);
            label14.Name = "label14";
            label14.Size = new Size(97, 29);
            label14.TabIndex = 3;
            label14.Tag = "Hasta";
            label14.Text = "TARİH:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bell MT", 14.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(81, 129);
            label12.Name = "label12";
            label12.Size = new Size(113, 29);
            label12.TabIndex = 3;
            label12.Tag = "Hasta";
            label12.Text = "TEDAVİ:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bell MT", 14.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(91, 39);
            label11.Name = "label11";
            label11.Size = new Size(103, 29);
            label11.TabIndex = 3;
            label11.Tag = "Hasta";
            label11.Text = "HASTA:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 139, 180);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(logo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 659);
            panel1.TabIndex = 8;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 557);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(48, 49);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 4;
            pictureBox8.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Verdana", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(58, 578);
            label17.Name = "label17";
            label17.Size = new Size(137, 28);
            label17.TabIndex = 5;
            label17.Tag = "Hasta";
            label17.Text = "Kullanıcılar";
            label17.Click += label17_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Red;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(241, 630);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 28);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 475);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 49);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 393);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(27, 139, 180);
            label9.Font = new Font("Verdana", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(146, 630);
            label9.Name = "label9";
            label9.Size = new Size(89, 28);
            label9.TabIndex = 3;
            label9.Tag = "Hasta";
            label9.Text = "ÇIKIŞ";
            label9.Click += label9_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 224);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(57, 496);
            label8.Name = "label8";
            label8.Size = new Size(193, 28);
            label8.TabIndex = 3;
            label8.Tag = "Hasta";
            label8.Text = "Gösterge Paneli";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(57, 414);
            label7.Name = "label7";
            label7.Size = new Size(90, 28);
            label7.TabIndex = 3;
            label7.Tag = "Hasta";
            label7.Text = "Reçete";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(57, 329);
            label6.Name = "label6";
            label6.Size = new Size(86, 28);
            label6.TabIndex = 3;
            label6.Tag = "Hasta";
            label6.Text = "Tedavi";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(58, 246);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 3;
            label5.Tag = "Hasta";
            label5.Text = "Randevu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(58, 162);
            label4.Name = "label4";
            label4.Size = new Size(74, 29);
            label4.TabIndex = 3;
            label4.Tag = "Hasta";
            label4.Text = "Hasta";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(136, 71);
            label3.Name = "label3";
            label3.Size = new Size(114, 28);
            label3.TabIndex = 3;
            label3.Tag = "Hasta";
            label3.Text = "Randevu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(97, 31);
            label2.Name = "label2";
            label2.Size = new Size(154, 31);
            label2.TabIndex = 1;
            label2.Text = "DİŞ KLİNİĞİ";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 308);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(97, -1);
            label1.Name = "label1";
            label1.Size = new Size(94, 31);
            label1.TabIndex = 1;
            label1.Text = "SİRİUS";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(-1, -1);
            logo.Name = "logo";
            logo.Size = new Size(92, 100);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // Randevu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1204, 659);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Randevu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevu";
            Load += Randevu_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RandevuDGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button button2;
        private Button button3;
        private Button button1;
        private Label label15;
        private Label label14;
        private Label label12;
        private Label label11;
        private DateTimePicker Saat;
        private DateTimePicker Tarih;
        private Panel panel1;
        private PictureBox pictureBox8;
        private Label label17;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label9;
        private PictureBox pictureBox4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox logo;
        private ComboBox TedaviCb;
        private ComboBox HastaCb;
        private DataGridView RandevuDGV;
    }
}