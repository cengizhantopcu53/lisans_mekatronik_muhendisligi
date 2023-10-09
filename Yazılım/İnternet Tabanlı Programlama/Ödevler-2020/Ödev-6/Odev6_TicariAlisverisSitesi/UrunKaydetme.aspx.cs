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
    public partial class UrunKaydetme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
            OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
            Baglanti.Open();

            OleDbCommand komut = new OleDbCommand("INSERT INTO TBL_URUNLER (UrunAd,KategoriAd,UrunMarkası,UrunFiyat,UrunOzellikleri,UrunResim) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", Baglanti);
            komut.Parameters.AddWithValue("@P1", TxtAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtKategori.Text);
            komut.Parameters.AddWithValue("@P3", TxtMarka.Text);
            komut.Parameters.AddWithValue("@P4", TxtFiyat.Text);
            komut.Parameters.AddWithValue("@P5", TxtOzellik.Text);
            komut.Parameters.AddWithValue("@P6", TxtResim.Text);
            komut.ExecuteNonQuery();
            Baglanti.Close();
            LblAcıklama.Text = "ÜRÜN KAYDEDİLDİ";
        }
    }
}