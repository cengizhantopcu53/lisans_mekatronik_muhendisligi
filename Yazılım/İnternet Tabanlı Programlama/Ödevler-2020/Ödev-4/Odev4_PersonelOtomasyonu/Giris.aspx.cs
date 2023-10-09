using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odev4_PersonelOtomasyonu
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string KullaniciAd = TextBox1.Text;
            string Sifre = TextBox2.Text;

            if (KullaniciAd == "Cengiz" && Sifre == "123")
            {
                Label3.Text = "İYİ ÇALIŞMALAR " + KullaniciAd.ToUpper();
            }
            else
            {
                Label3.Text = "YANLIŞ ŞİFRE GİRDİNİZ";
            }
        }
    }
}