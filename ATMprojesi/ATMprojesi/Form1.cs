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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        private void gonderbtn_Click(object sender, EventArgs e)
             
        {
        string kullanici_adi, sifre;

            if (btnXbank.Checked==true)
            {
                if (kullaniciaditxtbox.Text == "rojin temel" || sifretxtbox.Text == " 123")
                {
                    XBank xbank = new XBank();
                    xbank.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("HATALI GİRİŞ!!");
                }

            }
            else if( btnYbank.Checked==true)
            {
                if (kullaniciaditxtbox.Text == "rojin temel" || sifretxtbox.Text == " 123")
                {
                    YBank ybank = new YBank();
                    ybank.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("HATALI GİRİŞ!!");
                }


            }

        }
    }
}
