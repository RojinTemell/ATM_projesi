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
    public partial class XBank : Form
    {
        public XBank()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Xbankatm xbankatm = new Xbankatm();
            xbankatm.Miktar = Convert.ToDouble(txtparayatırma.Text);
            xbankatm.Sube_adi = "temel";
            xbankatm.Adres = "izmir";
            xbankatm.Metre_Kare = "25";
            xbankatm.Hesaptaki_miktar = 2000;
            xbankatm.Para_Yatırma();
            listView1.Items.Add("sube adı:"+xbankatm.Sube_adi);
            listView1.Items.Add("\nadres:"+xbankatm.Adres);
            listView1.Items.Add("\nmetre kare:"+xbankatm.Metre_Kare);
            listView1.Items.Add("\nhesaptaki miktar:"+Convert.ToString(xbankatm.Hesaptaki_miktar));
            listView1.Items.Add("\nbankaya eklenen miktar:"+Convert.ToString(xbankatm.Miktar));
            listView1.Items.Add("\nhesaptaki güncel miktar:"+Convert.ToString(xbankatm.Para_Yatırma()));


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txtparacekme.Text = " " ;
            txtparayatırma.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Xbankatm xbankatm = new Xbankatm();
            xbankatm.Miktar = Convert.ToDouble(txtparacekme.Text);
            xbankatm.Sube_adi = "temel";
            xbankatm.Adres = "izmir";
            xbankatm.Metre_Kare = "25";
            xbankatm.Hesaptaki_miktar = 2000;
            xbankatm.Para_Cekme();
            if (xbankatm.Miktar > xbankatm.Hesaptaki_miktar)
            {
                MessageBox.Show("HESAPTAN BU MİKTARDA PARA ÇEKEMEZSİNİZ");
            }
            else
            {
                listView1.Items.Add("sube adı:" + xbankatm.Sube_adi);
                listView1.Items.Add("\nadres:" + xbankatm.Adres);
                listView1.Items.Add("\nmetre kare:" + xbankatm.Metre_Kare);
                listView1.Items.Add("\nhesaptaki miktar:" + Convert.ToString(xbankatm.Hesaptaki_miktar));
                listView1.Items.Add("\nhesaptan çekilen miktar:" + Convert.ToString(xbankatm.Miktar));
                listView1.Items.Add("\nhesaptaki güncel miktar:" + Convert.ToString(xbankatm.Para_Cekme()));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Xbankatm xbankatm = new Xbankatm();
            xbankatm.Sube_adi = "temel";
            xbankatm.Adres = "izmir";
            xbankatm.Metre_Kare = "25";
            xbankatm.Hesaptaki_miktar = 2000;
            

                listView1.Items.Add("sube adı:" + xbankatm.Sube_adi);
                listView1.Items.Add("\nadres:" + xbankatm.Adres);
                listView1.Items.Add("\nmetre kare:" + xbankatm.Metre_Kare);
                listView1.Items.Add("\nhesaptaki miktar:" + Convert.ToString(xbankatm.Hesaptaki_miktar));
            
         


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 girismenu = new Form1();
            girismenu.Show();
            this.Hide();
        }
    }
}
