using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisProje01
{
    public partial class Kullanıcı : Form
    {
        public Kullanıcı()
        {
            InitializeComponent();
        }
        void doldur()
        {
            BenimHastam hastam = new BenimHastam();
            string query = "select * from KullaniciTablo";
            DataSet ds = hastam.HastaTblGoster(query);
            KullaniciDGV.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into KullaniciTablo values ('" + KullaniciAdSoyad.Text + "','" + KullaniciTelMtb.Text + "','" + KullaniciSifre.Text + "')";
            BenimHastam hastam = new BenimHastam();
            try
            {
                hastam.HastaEkle(query);
                MessageBox.Show("Kullanıcı Başarıyla Eklendi.");
                doldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Kullanıcı_Load(object sender, EventArgs e)
        {
            doldur();
        }
        int key = 0;
        private void button2_Click(object sender, EventArgs e)
        {   //sil butonu
            BenimHastam hastam = new BenimHastam();
            if (key == 0)
            {
                MessageBox.Show("Lütfen İptal Etmek İçin Kullanıcı Seçin.");
            }
            else
            {
                try
                {
                    string query = "Delete from KullaniciTablo where KullaniciId = " + key + "";
                    hastam.HastaSil(query);
                    MessageBox.Show("Kullanıcı Başarıyla Silindi.");
                    doldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // güncelle butonu
        private void button3_Click(object sender, EventArgs e)
        {
            BenimHastam hastam = new BenimHastam();
            if (key == 0)
            {
                MessageBox.Show("Lütfen Kullanıcı Seçin.");
            }
            else
            {
                try
                {
                    string query = " update KullaniciTablo set KullaniciAdi='" + KullaniciAdSoyad.Text + "', KullaniciTelefon = '" + KullaniciTelMtb.Text + "' , KullaniciSifre = '" + KullaniciSifre.Text + "' where KullaniciId= " + key + " ";
                    hastam.HastaGuncelle(query);
                    MessageBox.Show("Kullanıcı Bilgileri Başarıyla Güncellendi.");
                    doldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void KullaniciDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KullaniciAdSoyad.Text = KullaniciDGV.SelectedRows[0].Cells[1].Value.ToString();
            KullaniciTelMtb.Text = KullaniciDGV.SelectedRows[0].Cells[2].Value.ToString();
            KullaniciSifre.Text = KullaniciDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (KullaniciAdSoyad.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(KullaniciDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
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
