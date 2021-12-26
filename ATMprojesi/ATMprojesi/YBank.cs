using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMprojesi
{
    public partial class YBank : Form
    {
        public YBank()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ybankatm ybankatm = new Ybankatm();
            ybankatm.Miktar = Convert.ToDouble(txtparayatırma.Text);
            ybankatm.Sube_adi = "yıldız";
            ybankatm.Adres = "mardin";
            ybankatm.Metre_Kare = "30";
            ybankatm.Hesaptaki_miktar = 3000;
            ybankatm.Para_Yatırma();
            listView1.Items.Add("sube adı:" + ybankatm.Sube_adi);
            listView1.Items.Add("\nadres:" + ybankatm.Adres);
            listView1.Items.Add("\nmetre kare:" + ybankatm.Metre_Kare);
            listView1.Items.Add("\nhesaptaki miktar:" + Convert.ToString(ybankatm.Hesaptaki_miktar));
            listView1.Items.Add("\nbankaya eklenen miktar:" + Convert.ToString(ybankatm.Miktar));
            listView1.Items.Add("\nhesaptaki güncel miktar:" + Convert.ToString(ybankatm.Para_Yatırma()));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txtparacekme.Text = "";
            txtparayatırma.Text = "";

          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ybankatm ybankatm = new Ybankatm();
            ybankatm.Sube_adi = "yıldız";
            ybankatm.Adres = "mardin";
            ybankatm.Metre_Kare = "30";
            ybankatm.Hesaptaki_miktar = 3000;
            ybankatm.Miktar = Convert.ToDouble(txtparacekme.Text);
            ybankatm.Para_Cekme();
            if (ybankatm.Miktar > ybankatm.Hesaptaki_miktar)
            {
                MessageBox.Show("HESAPTAN BU MİKTARDA PARA ÇEKEMEZSİNİZ");
            }
            else
            {
                listView1.Items.Add("sube adı:" + ybankatm.Sube_adi);
                listView1.Items.Add("\nadres:" + ybankatm.Adres);
                listView1.Items.Add("\nmetre kare:" + ybankatm.Metre_Kare);
                listView1.Items.Add("\nhesaptaki miktar:" + Convert.ToString(ybankatm.Hesaptaki_miktar));
                listView1.Items.Add("\nhesaptan çekilen miktar:" + Convert.ToString(ybankatm.Miktar));
                listView1.Items.Add("\nhesaptaki güncel miktar:" + Convert.ToString(ybankatm.Para_Cekme()));
            }








        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ybankatm ybankatm = new Ybankatm();
            ybankatm.Sube_adi = "yıldız";
            ybankatm.Adres = "mardin";
            ybankatm.Metre_Kare = "30";
            ybankatm.Hesaptaki_miktar = 3000;

            listView1.Items.Add("sube adı:" + ybankatm.Sube_adi);
            listView1.Items.Add("\nadres:" + ybankatm.Adres);
            listView1.Items.Add("\nmetre kare:" + ybankatm.Metre_Kare);
            listView1.Items.Add("\nhesaptaki miktar:" + Convert.ToString(ybankatm.Hesaptaki_miktar));







        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 girismenu = new Form1();
            girismenu.Show();
            this.Hide();
        }
    }
}
