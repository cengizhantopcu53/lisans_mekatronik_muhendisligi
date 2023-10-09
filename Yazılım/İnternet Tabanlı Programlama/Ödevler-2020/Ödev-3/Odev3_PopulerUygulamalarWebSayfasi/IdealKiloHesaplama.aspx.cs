using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odev3_PopulerUygulamalarWebSayfasi
{
    public partial class IdealKiloHesaplama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int kilo, boy, sonuc;
            kilo = Convert.ToInt32(TextBox1.Text);
            boy = Convert.ToInt32(TextBox2.Text);
            sonuc = 0;
            // boy - ((150-boy)/4)+110
            sonuc = boy - (((150 - boy) / 4) + 110);
            if (kilo > sonuc)
            {
                Label2.Text = "Fazla Kilolusunuz. İdeal Kilonuzdan " + Math.Abs(Convert.ToInt32(sonuc - kilo)) + " kg fazlanız var";
                Image3.Visible = true;
            }
            else if (kilo < sonuc)
            {
                Label2.Text = "Zayıfsınız. İdeal Kilonuzdan " + Convert.ToInt32(sonuc - kilo) + "kg eksiğiniz var";
                Image4.Visible = true;
            }
            else
            {
                Label2.Text = "Tebrikler İdeal Kilodasınız...";
                Image5.Visible = true;
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label2.Text = "SONUCUNUZ HESAPLANIYOR ...";
            Image3.Visible = false;
            Image4.Visible = false;
            Image5.Visible = false;
        }
    }
}