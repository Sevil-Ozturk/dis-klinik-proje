using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisProje01
{
    public partial class Giris : Form
    {


        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AdminGiris admingiris = new AdminGiris();
            admingiris.Show();
            this.Hide();

        }
        ConnectionString benimBaglantim = new ConnectionString();

        private void button1_Click(object sender, EventArgs e)
        {
              SqlConnection baglanti = benimBaglantim.Getbaglanti();
              baglanti.Open();
              SqlDataAdapter sda = new SqlDataAdapter(" select count(*) from KullaniciTablo where KullaniciAdi = '" + KullaniciAdiTb.Text + "' and KullaniciSifre = '" + GirisSifreTb.Text + "'", baglanti);
              DataTable dt = new DataTable();
              sda.Fill(dt);
              if (dt.Rows[0][0].ToString() == "1")
              {
               Randevu randevu = new Randevu();
                  randevu.Show();
                  this.Hide();
              } 
              else 
              {
                  MessageBox.Show("Kullanýcý Adý Yada Þifre Hatalý.Lütfen Kontrol Ediniz");
              }

              baglanti.Close();


            
        } 

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giris_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Þifre Göster

            if (GirisSifreTb.PasswordChar == '*')
                GirisSifreTb.PasswordChar = '\0'; // Karakteri göster
            else
                GirisSifreTb.PasswordChar = '*'; // Asterisk (*) karakterini kullanarak gizle
        }
    }
}

