using Microsoft.VisualBasic;
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
    public partial class Recete : Form
    {
        public Recete()
        {
            InitializeComponent();
        }
        ConnectionString benimBaglantim = new ConnectionString();
        private void HastaDoldur()
        {
            SqlConnection Baglanti = benimBaglantim.Getbaglanti();
            Baglanti.Open();
            SqlCommand cmd = new SqlCommand("select Hasta from RandevuTablo", Baglanti);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Hasta", typeof(string));
            dt.Load(rdr);
            HastaId.ValueMember = "Hasta";
            HastaId.DataSource = dt;
            Baglanti.Close();
        }
        private void TedaviDoldur()
        {
            SqlConnection Baglanti = benimBaglantim.Getbaglanti();
            Baglanti.Open();
            SqlCommand cmd = new SqlCommand("select TedaviAdi from TedaviTablo", Baglanti);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Hasta", typeof(string));
            dt.Load(rdr);
            HastaId.ValueMember = "Hasta";
            HastaId.DataSource = dt;
            Baglanti.Close();
        }
        private void GetTedavi()
        {
            SqlConnection Baglanti = benimBaglantim.Getbaglanti();
            Baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from  RandevuTablo where Hasta = '" + HastaId.SelectedValue.ToString() + "'", Baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TedaviTb.Text = dr["Tedavi"].ToString();
            }
            Baglanti.Close();
        }
        private void GetFiyat()
        {
            SqlConnection Baglanti = benimBaglantim.Getbaglanti();
            Baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from  TedaviTablo where TedaviAdi = '" + TedaviTb.Text + "'", Baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TedaviFiyatTb.Text = dr["TedaviUcret"].ToString();
            }
            Baglanti.Close();
        }
        private void Reçete_Load(object sender, EventArgs e)
        {
            HastaDoldur();
            doldur();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTedavi();
        }

        private void TedaviTb_TextChanged(object sender, EventArgs e)
        {
            GetFiyat();
        }
        void doldur()
        {
            BenimHastam hastam = new BenimHastam();
            string query = "select * from ReceteTablo";
            DataSet ds = hastam.HastaTblGoster(query);
            ReceteDGV.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into ReceteTablo values ('" + HastaId.SelectedValue.ToString() + "','" + TedaviTb.Text + "','" + TedaviFiyatTb.Text + "','" + ilaclarTb.Text + "','" + ilacMiktarTb.Text + "')";
            BenimHastam hastam = new BenimHastam();
            try
            {
                hastam.HastaEkle(query);
                MessageBox.Show("Hasta Başarıyla Eklendi.");
                doldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int key = 0;
        private void ReceteDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HastaId.SelectedValue = ReceteDGV.SelectedRows[0].Cells[1].Value.ToString();
            TedaviTb.Text = ReceteDGV.SelectedRows[0].Cells[2].Value.ToString();
            TedaviFiyatTb.Text = ReceteDGV.SelectedRows[0].Cells[3].Value.ToString();
            ilaclarTb.Text = ReceteDGV.SelectedRows[0].Cells[5].Value.ToString();
            ilacMiktarTb.Text = ReceteDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (TedaviTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ReceteDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BenimHastam hastam = new BenimHastam();
            if (key == 0)
            {
                MessageBox.Show("Lütfen Reçeteyi Seçin.");
            }
            else
            {
                try
                {
                    string query = "Delete from ReceteTablo where ReceteId = " + key + "";
                    hastam.HastaSil(query);
                    MessageBox.Show("Reçete Başarıyla Silindi.");
                    doldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
