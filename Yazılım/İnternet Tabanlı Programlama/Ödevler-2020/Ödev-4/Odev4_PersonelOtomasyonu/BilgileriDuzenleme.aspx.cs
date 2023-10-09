using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Odev4_PersonelOtomasyonu
{
    public partial class BilgileriDuzenleme : System.Web.UI.Page
    {
		// Bağlantı adresini tanımlama
		OleDbConnection Baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\cengi\Desktop\Odev4_PersonelOtomasyonu\App_Data\PersonelVeriTabani.mdb");

		protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnBilgiGetir_Click(object sender, EventArgs e)
        {
			TxtAd.Text = "";
			TxtSoyad.Text = "";
			TxtNo.Text = "";
			TxtBrans.Text = "";
			Baglanti.Open();
			//Bilgileri Arama/Bulma
			OleDbCommand KmtBilgiGetir = new OleDbCommand("SELECT PersonelAd,PersonelSoyad,PersonelBrans,PersonelFoto FROM Personeller WHERE PersonelNo=@p1", Baglanti);
			KmtBilgiGetir.Parameters.AddWithValue("@p1", TxtNo.Text);
			OleDbDataReader Okuyucu = KmtBilgiGetir.ExecuteReader();
			while (Okuyucu.Read() == true)
			{
				TxtAd.Text = Okuyucu["PersonelAd"].ToString();
				TxtSoyad.Text = Okuyucu["PersonelSoyad"].ToString();
				TxtBrans.Text = Okuyucu["PersonelBrans"].ToString();
			}
			Baglanti.Close();
			Okuyucu.Close();
			KmtBilgiGetir.Dispose();
		}

        protected void BtnSil_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            ////Bilgileri Sİlme
            OleDbCommand KmtSil = new OleDbCommand("DELETE * FROM Personeller WHERE PersonelNo=@p1", Baglanti);
            KmtSil.Parameters.AddWithValue("@p1", TxtNo.Text);
            KmtSil.ExecuteNonQuery();
            LblAcıklama.Text = "KAYIT SİLİNDİ";
            Baglanti.Close();
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            Bilgileri Güncelleme
            OleDbCommand KmtGuncelle = new OleDbCommand("UPDATE Personeller SET PersonelAd=@p1, PersonelSoyad=@p2, PersonelBrans=@p3 WHERE PersonelNo=@p4", Baglanti);
            KmtGuncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            KmtGuncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            KmtGuncelle.Parameters.AddWithValue("@p3", TxtBrans);
            KmtGuncelle.Parameters.AddWithValue("@p4", TxtNo.Text);
            KmtGuncelle.ExecuteNonQuery();
            LblAcıklama.Text = "KAYIT GÜNCELLENDİ";
            Baglanti.Close();
        }
    }
}