using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odev3_PopulerUygulamalarWebSayfasi
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtEkran.Text = "0";
        }

        int islem = 0;
        double sayi1 = 0, sayi2 = 0;

        protected void Button10_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
            {
                TxtEkran.Text = "";
            }
            TxtEkran.Text += "1";
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
            {
                TxtEkran.Text = "";
            }
            TxtEkran.Text += "2";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
                TxtEkran.Text = "";
            TxtEkran.Text += "3";
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
                TxtEkran.Text = "";
            TxtEkran.Text += "4";
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
                TxtEkran.Text = "";
            TxtEkran.Text += "5";
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
                TxtEkran.Text = "";
            TxtEkran.Text += "6";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
                TxtEkran.Text = "";
            TxtEkran.Text += "7";
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
                TxtEkran.Text = "";
            TxtEkran.Text += "8";
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
                TxtEkran.Text = "";
            TxtEkran.Text += "9";
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
                TxtEkran.Text = "";
            TxtEkran.Text += "0";
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            if (TxtEkran.Text == "0")
                TxtEkran.Text = "";
            TxtEkran.Text += ",";
        }

        protected void BtnSilme_Click(object sender, EventArgs e)
        {
            sifirla();
        }

        public void sifirla()
        {
            TxtEkran.Text = "0";
        }

        protected void BtnCikarma_Click(object sender, EventArgs e)
        {
            islem = 2;
            sayi1 = double.Parse(TxtEkran.Text);
            sifirla();
        }

        protected void BtnCarpma_Click(object sender, EventArgs e)
        {
            islem = 3;
            sayi1 = double.Parse(TxtEkran.Text);
            sifirla();
        }

        protected void BtnBolme_Click(object sender, EventArgs e)
        {
            islem = 4;
            sayi1 = double.Parse(TxtEkran.Text);
            sifirla();
        }

        protected void BtnEsittir_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(TxtEkran.Text);
            TxtEkran.Text = hesapla().ToString("#,#.00");
        }

        public double hesapla()
        {
            double sonuc = 0;
            if (islem == 1)
                sonuc = sayi1 + sayi2;
            else if (islem == 2)
                sonuc = sayi1 - sayi2;
            else if (islem == 3)
                sonuc = sayi1 * sayi2;
            else if (islem == 4)
                sonuc = sayi1 / sayi2;
            else
                sonuc = 0;
            return sonuc;
        }

        protected void BtnHaneSilme_Click(object sender, EventArgs e)
        {
            string veri = TxtEkran.Text;
            TxtEkran.Text = "";
            int i;
            for (i = 0; i < veri.Length - 1; i++)
            {
                TxtEkran.Text += veri[i].ToString();
            }
        }

        protected void BtnTopla_Click(object sender, EventArgs e)
        {
            islem = 1;
            sayi1 = double.Parse(TxtEkran.Text);
            sifirla();
        }
    }
}