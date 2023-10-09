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
    public partial class GuncellemeSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["UrunID"].ToString());
            TxtID.Text = x.ToString();

            String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
            OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
            Baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT UrunAd, KategoriAd, UrunMarkası, UrunFiyat, UrunOzellikleri, UrunResim FROM TBL_URUNLER WHERE UrunID=@P1", Baglanti);
            komut.Parameters.AddWithValue("@P1", TxtID.Text);
            OleDbDataReader Okuyucu = komut.ExecuteReader();
            while (Okuyucu.Read() == true)
            {
                TxtAd.Text = Okuyucu["UrunAd"].ToString();
                TxtKategori.Text = Okuyucu["KategoriAd"].ToString();
                TxtMarka.Text = Okuyucu["UrunMarkası"].ToString();
                TxtFiyat.Text = Okuyucu["UrunFiyat"].ToString();
                TxtOzellik.Text = Okuyucu["UrunOzellikleri"].ToString();
                TxtResim.Text = Okuyucu["UrunResim"].ToString();
            }
            Baglanti.Close();
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
            OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
            Baglanti.Open();

            OleDbCommand komut = new OleDbCommand("UPDATE TBL_URUNLER SET UrunAd=@P2, KategoriAd=@P3, UrunMarkası=@P4, UrunFiyat=@P5, UrunOzellikleri=@P6, UrunResim=@P7 WHERE UrunID=@P1", Baglanti);
            komut.Parameters.AddWithValue("@P2", TxtAd.Text);
            komut.Parameters.AddWithValue("@P3", TxtKategori.Text);
            komut.Parameters.AddWithValue("@P4", TxtMarka.Text);
            komut.Parameters.AddWithValue("@P5", TxtFiyat.Text);
            komut.Parameters.AddWithValue("@P6", TxtOzellik.Text);
            komut.Parameters.AddWithValue("@P7", TxtResim.Text);
            komut.Parameters.AddWithValue("@P1", TxtID.Text);
            komut.ExecuteNonQuery();
            LblAcıklama.Text="KAYIT GÜNCELLENDİ";
            Baglanti.Close();
        }
    }
}