using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;

namespace Odev6_TicariAlisverisSitesi
{
    public partial class LoginRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGiris_Click(object sender, EventArgs e)
        {
            String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
            OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
            Baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT * FROM TBL_UYELER WHERE UyeMail=@P1 AND UyeSifre=@P2", Baglanti);
            komut.Parameters.AddWithValue("@P1", TxtMail.Text);
            komut.Parameters.AddWithValue("@P2", TxtSifre.Text);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("AnaSayfa.aspx");
            }
            else
            {
                Label1.Text="Hatalı Veri Girişi";
            }
            Baglanti.Close();
        }
    }
}