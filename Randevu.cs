using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace DisProje01
//67. ve 85. satır baktır.
{
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }
        ConnectionString benimBaglantim = new ConnectionString();
        private void HastaDoldur()
        {
            SqlConnection Baglanti = benimBaglantim.Getbaglanti();
            Baglanti.Open();
            SqlCommand cmd = new SqlCommand("select HastaAdıSoyadı from HastaTablo", Baglanti);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("HastaAdıSoyadı", typeof(string));
            dt.Load(rdr);
            HastaCb.ValueMember = "HastaAdıSoyadı";
            HastaCb.DataSource = dt;
            Baglanti.Close();
        }
        private void TedaviDoldur()
        {
            SqlConnection Baglanti = benimBaglantim.Getbaglanti();
            Baglanti.Open();
            SqlCommand cmd = new SqlCommand("select tedaviAdi from TedaviTablo", Baglanti);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TedaviAdi", typeof(string));
            dt.Load(rdr);
            TedaviCb.ValueMember = "TedaviAdi";
            TedaviCb.DataSource = dt;
            Baglanti.Close();
        }
        private void Randevu_Load(object sender, EventArgs e)
        {
            HastaDoldur();
            TedaviDoldur();
            doldur();
        }
        void doldur()
        {
            BenimHastam hastam = new BenimHastam();
            string query = "select * from RandevuTablo";
            DataSet ds = hastam.HastaTblGoster(query);
            RandevuDGV.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {

            /*    string query = "insert into RandevuTablo values ('" + HastaCb.SelectedValue.ToString() + "','" + TedaviCb.SelectedValue.ToString() + "','" + Tarih.Value.Date + "','" + Saat.Value.TimeOfDay + "')";


                BenimHastam hastam = new BenimHastam();
                try
                {
                    hastam.HastaEkle(query);
                    MessageBox.Show("Randevu Başarıyla Kaydedildi.");
                    doldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }*/


            BenimHastam hastam = new BenimHastam();
            try
            {
                string query = "INSERT INTO RandevuTablo (Hasta, Tedavi, Tarih, Saat) VALUES (@Hasta, @Tedavi, @Tarih, @Saat)";

                using (SqlConnection connection = benimBaglantim.Getbaglanti())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Hasta", HastaCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Tedavi", TedaviCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Tarih", Tarih.Value.Date);
                    cmd.Parameters.AddWithValue("@Saat", Saat.Value.TimeOfDay);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Randevu Başarıyla Kaydedildi.");
                doldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        int key = 0;
        private void RandevuDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HastaCb.SelectedValue = RandevuDGV.SelectedRows[0].Cells[1].Value.ToString();
            TedaviCb.SelectedValue = RandevuDGV.SelectedRows[0].Cells[2].Value.ToString();
            string hasta = RandevuDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (hasta == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(RandevuDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        //sil butonu tablodan seçilen kişinin verilerini siler.
        private void button3_Click(object sender, EventArgs e)
        {
            BenimHastam hastam = new BenimHastam();
            if (key == 0)
            {
                MessageBox.Show("Lütfen İptal Etmek İçin Randevu Seçin.");
            }
            else
            {
                try
                {
                    string query = "Delete from RandevuTablo where RandevuId = " + key + "";
                    hastam.HastaSil(query);
                    MessageBox.Show("Randevu Başarıyla İptal Edildi.");
                    doldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        //güncelle butonu tabloda seçilen kişinin verilerini siler.
        private void button2_Click(object sender, EventArgs e)
        {
            BenimHastam hastam = new BenimHastam();
            if (key == 0)
            {
                MessageBox.Show("Lütfen Randevu Seçin.");
            }
            else
            {
                try
                {
                    string query = " update RandevuTablo set Hasta='" + HastaCb.SelectedValue.ToString() + "' , Tedavi='" + TedaviCb.SelectedValue.ToString() + "' , Tarih='" + Tarih.Value.Date + "' , Saat='" + Saat.Value.TimeOfDay + "'  where RandevuId=" + key + " ";
                    hastam.HastaGuncelle(query);
                    MessageBox.Show("Randevu Başarıyla Güncellendi.");
                    doldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        //  paneldeki labellardan geçiş kodaları
        private void label4_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Tedavi tedavi = new Tedavi();
            tedavi.Show();
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


        // çıkış kodları
        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


