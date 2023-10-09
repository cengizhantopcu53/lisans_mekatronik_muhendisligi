using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odev3_PopulerUygulamalarWebSayfasi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string KullaniciAd = TextBox1.Text;
            string Sifre = TextBox2.Text;

            if (KullaniciAd == "Cengiz" && Sifre == "123")
            {
                Label2.Text="İSTEDİĞİNİZ UYGULAMAMIZA GİREBİLİRSİNİZ";
            }
            else
            {
                Label2.Text ="YANLIŞ ŞİFRE GİRDİNİZ";
            }
        }
    }
}