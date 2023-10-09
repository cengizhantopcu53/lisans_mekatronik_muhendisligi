using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev1_UçakSerbestAtışAnimasyonu
{
    public partial class OyunGiris : Form
    {
        public OyunGiris()
        {
            InitializeComponent();
        }

        string kullaniciadi, sifre, kayitad, kayitsifre;
        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciadi = textBox1.Text;
            sifre = textBox2.Text;
            kayitad = textBox3.Text;
            kayitsifre = textBox4.Text;
            if (kullaniciadi == kayitad && sifre == kayitsifre)
            {
                OyunAlanı frm = new OyunAlanı();
                frm.Show();
                this.Hide();
            }
            else
            {
                label5.Text = "YANLIŞ GİRDİNİZ LÜTFEN TEKRAR DENEYİNİZ";
            }
        }
    }
}
