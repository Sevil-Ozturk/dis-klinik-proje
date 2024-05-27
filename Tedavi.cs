using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DisProje01.Properties;
using HelixToolkit.Wpf;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DisProje01
{
    public partial class Tedavi : Form
    {
        public Tedavi()
        {
            InitializeComponent();

       /*     // PictureBox'ın üzerindeki Label'lara Click olayını abone edin
            d1.Click += Label_Click;
            d2.Click += Label_Click;
            d3.Click += Label_Click;

            // ListView için sütun başlıklarını ayarla
            listView1.Columns.Add("diş", 100);
            listView1.Columns.Add("Fiyat", 100);
       */
        }



        void doldur()
        {
            BenimHastam hastam = new BenimHastam();
            string query = "select * from TedaviTablo";
            DataSet ds = hastam.HastaTblGoster(query);
            TedaviDGV.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into TedaviTablo values ('" + TedaviAdiTb.Text + "','" + TedaviFiyatTb.Text + "','" + TedaviTaniTb.Text + "')";
            BenimHastam hastam = new BenimHastam();
            try
            {

                if (string.IsNullOrEmpty(TedaviAdiTb.Text))
                {
                    MessageBox.Show("Tedavi Adı Alanı Boş Geçilemez.Lütfen Kontrol Edin.");
                }
                else
                {
                    hastam.HastaEkle(query);
                    MessageBox.Show("Tedavi Başarıyla Eklendi.");
                    doldur();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BenimHastam hastam = new BenimHastam();
            if (key == 0)
            {
                MessageBox.Show("Lütfen Tedaviyi Seçin.");
            }
            else
            {
                try
                {
                    string query = "Delete from HastaTablo where TedaviId = " + key + "";
                    hastam.HastaSil(query);
                    MessageBox.Show("Tedavi Başarıyla Silindi.");
                    doldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BenimHastam hastam = new BenimHastam();
            if (key == 0)
            {
                MessageBox.Show("Lütfen Tedaviyi Seçin.");
            }
            else
            {
                try
                {
                    string query = " update Hastatablo set TedaviAdi='" + TedaviAdiTb.Text + "',TedaviUcret='" + TedaviFiyatTb.Text + "',TedaviTani='" + TedaviTaniTb.Text + "' where TedaviId=" + key + ",";
                    hastam.HastaSil(query);
                    MessageBox.Show("Tedavi Başarıyla Güncellendi.");
                    doldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;
        private void HastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TedaviAdiTb.Text = TedaviDGV.SelectedRows[0].Cells[1].Value.ToString();
            TedaviFiyatTb.Text = TedaviDGV.SelectedRows[0].Cells[2].Value.ToString();
            TedaviTaniTb.Text = TedaviDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (TedaviAdiTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TedaviDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }



        /*
        eğer buton1 e basarsa ve TedaviAdiTb.Text ="Diş çürüğü" ise TedaviFiyatTb.Text= "1000" yazsın  
       
        button1 click özelliği textbox ta olabilir.
        {
          if (TedaviAdiTb.Text == "diş temizleme") TedaviFiyatTb.Text = "300";
          if (TedaviAdiTb.Text == "diş dolgu") TedaviFiyatTb.Text = "800";
          if (TedaviAdiTb.Text == "kanal tedavİ") TedaviFiyatTb.Text = "2000";
          if (TedaviAdiTb.Text == "diş çekimi") TedaviFiyatTb.Text = "500";
          if (TedaviAdiTb.Text == "diş protez") TedaviFiyatTb.Text = "5000";
          if (TedaviAdiTb.Text == "ortodontiik tedavi" || TedaviAdiTb.Text == "tel tedavi") {TedaviFiyatTb.Text = "15000";}
        }

        button2 click özelliği textbox ta olabilir.
        {
          if (TedaviAdiTb.Text == "diş temizleme") TedaviFiyatTb.Text = "300";
          if (TedaviAdiTb.Text == "diş dolgu") TedaviFiyatTb.Text = "800";
          if (TedaviAdiTb.Text == "kanal tedavİ") TedaviFiyatTb.Text = "2000";
          if (TedaviAdiTb.Text == "diş çekimi") TedaviFiyatTb.Text = "500";
          if (TedaviAdiTb.Text == "diş protez") TedaviFiyatTb.Text = "5000";
          if (TedaviAdiTb.Text == "ortodontiik tedavi" || TedaviAdiTb.Text == "tel tedavi") {TedaviFiyatTb.Text = "15000";}
        }

        button3 click özelliği textbox ta olabilir.
        {
          if (TedaviAdiTb.Text == "diş temizleme") TedaviFiyatTb.Text = "300";
          if (TedaviAdiTb.Text == "diş dolgu") TedaviFiyatTb.Text = "800";
          if (TedaviAdiTb.Text == "kanal tedavİ") TedaviFiyatTb.Text = "2000";
          if (TedaviAdiTb.Text == "diş çekimi") TedaviFiyatTb.Text = "500";
          if (TedaviAdiTb.Text == "diş protez") TedaviFiyatTb.Text = "5000";
          if (TedaviAdiTb.Text == "ortodontiik tedavi" || TedaviAdiTb.Text == "tel tedavi") {TedaviFiyatTb.Text = "15000";}
        }

        button4 click özelliği textbox ta olabilir.
        {
          if (TedaviAdiTb.Text == "diş temizleme") TedaviFiyatTb.Text = "300";
          if (TedaviAdiTb.Text == "diş dolgu") TedaviFiyatTb.Text = "800";
          if (TedaviAdiTb.Text == "kanal tedavİ") TedaviFiyatTb.Text = "2000";
          if (TedaviAdiTb.Text == "diş çekimi") TedaviFiyatTb.Text = "500";
          if (TedaviAdiTb.Text == "diş protez") TedaviFiyatTb.Text = "5000";
          if (TedaviAdiTb.Text == "ortodontiik tedavi" || TedaviAdiTb.Text == "tel tedavi") {TedaviFiyatTb.Text = "15000";}
        }

        button5 click özelliği textbox ta olabilir.
        {
          if (TedaviAdiTb.Text == "diş temizleme") TedaviFiyatTb.Text = "300";
          if (TedaviAdiTb.Text == "diş dolgu") TedaviFiyatTb.Text = "800";
          if (TedaviAdiTb.Text == "kanal tedavİ") TedaviFiyatTb.Text = "2000";
          if (TedaviAdiTb.Text == "diş çekimi") TedaviFiyatTb.Text = "500";
          if (TedaviAdiTb.Text == "diş protez") TedaviFiyatTb.Text = "5000";
          if (TedaviAdiTb.Text == "ortodontiik tedavi" || TedaviAdiTb.Text == "tel tedavi") {TedaviFiyatTb.Text = "15000";}
        }

        button6 click özelliği textbox ta olabilir.
        {
          if (TedaviAdiTb.Text == "diş temizleme") TedaviFiyatTb.Text = "300";
          if (TedaviAdiTb.Text == "diş dolgu") TedaviFiyatTb.Text = "800";
          if (TedaviAdiTb.Text == "kanal tedavİ") TedaviFiyatTb.Text = "2000";
          if (TedaviAdiTb.Text == "diş çekimi") TedaviFiyatTb.Text = "500";
          if (TedaviAdiTb.Text == "diş protez") TedaviFiyatTb.Text = "5000";
          if (TedaviAdiTb.Text == "ortodontiik tedavi" || TedaviAdiTb.Text == "tel tedavi") {TedaviFiyatTb.Text = "15000";}
        }

        */
        //tek satırda kod.
        /*
        
        private void SetTreatmentPrice(string treatment)
{
    switch (treatment.ToLower())
    {
        case "diş temizleme":
            TedaviFiyatTb.Text = "300";
            break;
        case "diş dolgu":
            TedaviFiyatTb.Text = "800";
            break;
        case "kanal tedavİ":
            TedaviFiyatTb.Text = "2000";
            break;
        case "diş çekimi":
            TedaviFiyatTb.Text = "500";
            break;
        case "diş protez":
            TedaviFiyatTb.Text = "5000";
            break;
        case "ortodontiik tedavi":
        case "tel tedavi":
            TedaviFiyatTb.Text = "15000";
            break;
        default:
                    MessageBox.Show(" Belirtilen tedavi bulunamadı, isteğinize göre bir işlem yapabilirsiniz.");
            break;
    }
}
         

        private void Button_Click(object sender, EventArgs e)
{
    // Tıklanan butonu al
    Button clickedButton = sender as Button;

    // Eğer gönderilen nesne bir buton ise devam et
    if (clickedButton != null)
    {
        // SetTreatmentPrice metodunu çağır ve TedaviAdiTb.Text'i argüman olarak geçir
        SetTreatmentPrice(TedaviAdiTb.Text);
    }
}*/



        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Recete recete = new Recete();
            recete.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            GostergePaneli gostergePaneli = new GostergePaneli();
            gostergePaneli.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Kullanıcı kullanıcı = new Kullanıcı();
            kullanıcı.Show();
            this.Hide();
        }

        private void saggorunum_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.dis1;
            d7.Hide(); d8.Hide(); d9.Hide(); d10.Hide(); d22.Hide(); d23.Hide(); d24.Hide(); d25.Hide(); d26.Hide(); d27.Hide();
            d11.Hide(); d12.Hide(); d13.Hide(); d14.Hide(); d15.Hide(); d16.Hide(); d17.Hide(); d18.Hide(); d19.Hide(); d20.Hide(); d21.Hide();
            d1.Show(); d2.Show(); d3.Show(); d4.Show(); d5.Show(); d6.Show(); d32.Show(); d31.Show(); d30.Show(); d29.Show(); d28.Show();

        }

        private void ongorunum_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.dis2;
            d11.Hide(); d12.Hide(); d13.Hide(); d14.Hide(); d15.Hide(); d16.Hide(); d17.Hide(); d18.Hide(); d19.Hide(); d20.Hide(); d21.Hide();
            d1.Hide(); d2.Hide(); d3.Hide(); d4.Hide(); d5.Hide(); d6.Hide(); d32.Hide(); d31.Hide(); d30.Hide(); d29.Hide(); d28.Hide();
            d7.Show(); d8.Show(); d9.Show(); d10.Show(); d22.Show(); d23.Show(); d24.Show(); d25.Show(); d26.Show(); d27.Show();

        }

        private void solgorunum_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Resources.dis3;
            d7.Hide(); d8.Hide(); d9.Hide(); d10.Hide(); d22.Hide(); d23.Hide(); d24.Hide(); d25.Hide(); d26.Hide(); d27.Hide();
            d1.Hide(); d2.Hide(); d3.Hide(); d4.Hide(); d5.Hide(); d6.Hide(); d32.Hide(); d31.Hide(); d30.Hide(); d29.Hide(); d28.Hide();
            d11.Show(); d12.Show(); d13.Show(); d14.Show(); d15.Show(); d16.Show(); d17.Show(); d18.Show(); d19.Show(); d20.Show(); d21.Show();
        }
        /*

        namespace PictureBoxClickExample
    {
        public partial class MainForm : Form
        {
            private List<Label> clickedLabels = new List<Label>(); // Tıklanan Label'ları takip etmek için liste

            // Fiyatların toplamını takip etmek için bir değişken
            private decimal totalPrice = 0;

            

            private void Label_Click(object sender, EventArgs e)
            {
                Label clickedLabel = (Label)sender;

                // Tıklanan Label'ın arka plan rengini yeşil yap
                clickedLabel.BackColor = Color.Green;

                // Tıklanan Label'ı listeye ekleyin
                clickedLabels.Add(clickedLabel);

                // Eğer işaretlenen Label sayısı 1'den fazlaysa, fiyatı işaretlenen Label sayısıyla çarpın
                if (clickedLabels.Count > 1)
                {
                    decimal price = 15000 * clickedLabels.Count;
                    totalPrice = price;

                    // TextBox'a toplam fiyatı yazın
                    TedaviFiyatTb.Text = totalPrice.ToString("C");
                }
            }
        }
    }*/
}
}
