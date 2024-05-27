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


// satır 104 hataya bak!!! doğum tarihini yazmıyor sayfaya!!!


namespace DisProje01
{
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Enabled = true;
        }
        void doldur()
        {
            BenimHastam hastam = new BenimHastam();
            string query = "select * from HastaTablo";
            DataSet ds = hastam.HastaTblGoster(query);
            HastaDGV.DataSource = ds.Tables[0];
        }

        private void Hasta_Load(object sender, EventArgs e)
        {
            doldur();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into HastaTablo values ('" + HastAdTb.Text + "','" + HastTelMtb.Text + "','" + HastAdresTb.Text + "','" + DT_Date.Value.Date + "','" + CinsiyetCb.SelectedItem.ToString() + "','" + AlerjiTb.Text + "')";
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
        private void HastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HastAdTb.Text = HastaDGV.SelectedRows[0].Cells[1].Value.ToString();
            HastTelMtb.Text = HastaDGV.SelectedRows[0].Cells[2].Value.ToString();
            HastAdresTb.Text = HastaDGV.SelectedRows[0].Cells[3].Value.ToString();
            DT_Date.Value = DateTime.Parse(HastaDGV.SelectedRows[0].Cells[4].Value.ToString());
            CinsiyetCb.SelectedItem = HastaDGV.SelectedRows[0].Cells[5].Value.ToString();
            AlerjiTb.Text = HastaDGV.SelectedRows[0].Cells[6].Value.ToString();

            if (HastAdTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(HastaDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BenimHastam hastam = new BenimHastam();
            if (key == 0)
            {
                MessageBox.Show("Lütfen Hastayı Seçin.");
            }
            else
            {
                try
                {
                    string query = " update Hastatablo set HastaAdıSoyadı='" + HastAdTb.Text + "',HastaTelefon='" + HastTelMtb.Text + "',HastaAdres='" + HastAdresTb.Text + "',HastaD_Tarih='" + DT_Date.Value.Date + "',HastaCinsiyet='" + CinsiyetCb.SelectedItem.ToString() + "',HastaAlerji='" + AlerjiTb.Text + "' where HastaId=" + key + ",";
                    hastam.HastaSil(query);
                    MessageBox.Show("Hasta Başarıyla Güncellendi.");
                    doldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BenimHastam hastam = new BenimHastam();
            if (key == 0)
            {
                MessageBox.Show("Lütfen Hastayı Seçin.");
            }
            else
            {
                try
                {
                    string query = "Delete from HastaTablo where HastaId = " + key + "";
                    hastam.HastaSil(query);
                    MessageBox.Show("Hasta Başarıyla Silindi.");
                    doldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

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

        private void label17_Click(object sender, EventArgs e)
        {
            Kullanıcı kullanıcı = new Kullanıcı();
            kullanıcı.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
