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
    public partial class UrunSatis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["UrunID"].ToString());

            String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
            OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
            Baglanti.Open();

            OleDbCommand komut = new OleDbCommand("SELECT UrunAd, KategoriAd, UrunMarkası, UrunFiyat, UrunOzellikleri, UrunResim FROM TBL_URUNLER WHERE UrunID=@P1", Baglanti);
            komut.Parameters.AddWithValue("@P1", x);
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
    }
}