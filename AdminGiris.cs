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

    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdminSifreTb.Text == "")
            {
                MessageBox.Show("Lütfen Yönetici Şifresini Girin");
            }
            else if (AdminSifreTb.Text == "Şifre")
            {
                Kullanıcı kullanici = new Kullanıcı();
                kullanici.Show();
                this.Hide();
            }
            else { MessageBox.Show("Şifre Yanlış. Lütfen Yönetici İle İletişime Geçin."); }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {     // Şifre Göster

            if (AdminSifreTb.PasswordChar == '*')
                AdminSifreTb.PasswordChar = '\0'; // Karakteri göster
            else
                AdminSifreTb.PasswordChar = '*'; // Asterisk (*) karakterini kullanarak gizle
        }
    }
}
