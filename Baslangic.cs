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
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
        }
        int baslangicnoktası = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            baslangicnoktası += 1;
            BaslangicprogressBar.Value = baslangicnoktası;
            if (BaslangicprogressBar.Value == 100)
            {
                BaslangicprogressBar.Value = 0;
                timer1.Stop();
                Giris giris = new Giris();
                giris.Show();
                this.Hide();
            }
        }

        private void Başlangiç_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
