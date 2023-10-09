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
    public partial class Kayıt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKayıt_Click(object sender, EventArgs e)
        {
            String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
            OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
            Baglanti.Open();

            OleDbCommand komut = new OleDbCommand("INSERT INTO TBL_UYELER (UyeAd,UyeSoyad,UyeMail,UyeSifre) VALUES (@P1,@P2,@P3,@P4)", Baglanti);
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@P2", TxtMail.Text);
            komut.Parameters.AddWithValue("@P2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            Label1.Text = "Kaydınız Gerçekleşmiştir";
        }
    }
}