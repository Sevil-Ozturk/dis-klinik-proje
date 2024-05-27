using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisProje01
{
    public partial class GostergePaneli : Form
    {
        public GostergePaneli()
        {
            InitializeComponent();
        }
        ConnectionString benimBaglantim = new ConnectionString();
        private void Gösterge_Paneli_Load(object sender, EventArgs e)
        {   // progressbarlara ilk değerleri verildi
            HastalarProgressBar.Value = 0;
            KullanicilarlarProgressBar.Value = 0;
            RandevularProgressBar.Value = 0;


            SqlConnection baglanti = benimBaglantim.Getbaglanti();
            baglanti.Open();

            // randevu tablosundaki randevu sayısını toplayıp label a aktarır
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from RandevuTablo", baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            RandevularLbl.Text = dt.Rows[0][0].ToString();

            // hasta tablosundaki hasta sayısını toplayıp label a aktarır
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from HastaTablo", baglanti);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            HastalarLbl.Text = dt1.Rows[0][0].ToString();

            // kulllanıcı tablosundaki kullanıcı sayısını toplayıp label a aktarır
              SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from KullaniciTablo", baglanti);
              DataTable dt2 = new DataTable();
              sda2.Fill(dt2);
              KullanicilarLbl.Text = dt2.Rows[0][0].ToString();

            

           /* // Doğru SqlDataAdapter'ı (sda2) kullanın
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from KullaniciTablo", baglanti);

            // ExecuteScalar'ı doğrudan kullanarak tek bir değeri alabilirsiniz
            int kullaniciSayisi = (int)sda2.SelectCommand.ExecuteScalar();

            // Label'a sayıyı atayın
            KullanicilarLbl.Text = kullaniciSayisi.ToString();
            */

            /*
              // kod çalışmadı.

             SqlDataAdapter sda3 = new SqlDataAdapter("select min(Tarih) from RandevuTablo", baglanti);
             DataTable dt3 = new DataTable();
             sda.Fill(dt3);
             SonrakiRandevuLbl.Text = dt3.Rows[0][0].ToString();
            
             */



            // randevu tablosundaki tarihleri küçükten büyüğe sırala ve en başta satırdaki tarih verisini al.
            SqlDataAdapter sda3 = new SqlDataAdapter("SELECT TOP 1 Tarih FROM RandevuTablo ORDER BY Tarih ASC", baglanti);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            if (dt3.Rows.Count > 0)
            {
                SonrakiRandevuLbl.Text = dt3.Rows[0]["Tarih"].ToString();
            }
            else
            {
                // Eğer hiç kayıt yoksa, bir mesaj veya varsayılan değeri ayarlayabilirsiniz.
                SonrakiRandevuLbl.Text = "Kayıt Yok";
            }


            baglanti.Close();

        }


        // geri label ına tıklandığında randevu formuna gider
        private void label9_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.Show();
            this.Hide();
        }


        // geri ok işareti randevu formuna gider
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.Show();
            this.Hide();
        }


        // çarpı işareti randevu formuna gider
        private void label6_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.Show();
            this.Hide();
        }

       
    }
}
