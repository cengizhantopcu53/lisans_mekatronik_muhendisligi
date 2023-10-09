using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;

namespace Odev5_UrunKayitFormuveListeleme
{
    public partial class KayitForm : System.Web.UI.Page
    {
        //Magazaları Listeleme  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack!=true)
            {
                String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
                OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
                Baglanti.Open();

                OleDbCommand Komut = new OleDbCommand("SELECT * FROM TBL_MAGAZALAR", Baglanti);
                OleDbDataReader Okuyucu = Komut.ExecuteReader();
                //Magazaları Listeleme
                //DDwnMgzToKtgr.Items.Clear();
                ListItem Eleman = new ListItem();
                Eleman.Text = "Magaza Seç";
                Eleman.Value = "0";
                DDwnMgzToKtgr.Items.Add(Eleman);
                DDwnMgzToUrun.Items.Add(Eleman);
                while (Okuyucu.Read())
                {
                    Eleman = new ListItem();
                    Eleman.Text = Okuyucu["MagazaAD"].ToString();
                    Eleman.Value = Okuyucu["MagazaID"].ToString();
                    DDwnMgzToKtgr.Items.Add(Eleman);
                    DDwnMgzToUrun.Items.Add(Eleman);
                }
                Baglanti.Close();
              }
        }

        //Magaza Kaydetme
        protected void BtnMgzKydt_Click(object sender, EventArgs e)
        {
            String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
            OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
            Baglanti.Open();

            OleDbCommand Komut = new OleDbCommand("INSERT INTO TBL_MAGAZALAR (MagazaAD) VALUES (@P1)", Baglanti);
            Komut.Parameters.AddWithValue("@P1", TxtMgz.Text);
            Komut.ExecuteNonQuery();
            Baglanti.Close();   
            Komut.Dispose();
        }

        //Kategori Kaydetme
        protected void BtnKtgrKydt_Click(object sender, EventArgs e)
        {
            String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
            OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
            Baglanti.Open();

            int MagazaID = Convert.ToInt32(DDwnMgzToKtgr.SelectedItem.Value);
            OleDbCommand Komut = new OleDbCommand("INSERT INTO TBL_KATEGORİLER (MagazaID,KategoriAD) VALUES (@P1,@p2)", Baglanti);
            Komut.Parameters.AddWithValue("@P1", MagazaID);
            Komut.Parameters.AddWithValue("@P2", TxtKtgr.Text);
                Komut.ExecuteNonQuery();
            Baglanti.Close();
            Komut.Dispose();
        }

        //Kategorileri Listeleme    
        protected void DDwnMgzToUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
            OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
            Baglanti.Open();

            int MagazaID = Convert.ToInt32(DDwnMgzToUrun.SelectedItem.Value);
            OleDbCommand Komut = new OleDbCommand("SELECT * FROM TBL_KATEGORILER WHERE MagazaID=@P1", Baglanti);
            Komut.Parameters.AddWithValue("@P1", MagazaID);
            OleDbDataReader Okuyucu = Komut.ExecuteReader();
            DDwnKtrgrToUrun.Items.Clear();
            ListItem Eleman = new ListItem();
            Eleman.Text = "Kategori Seç";
            Eleman.Value = "0";
            DDwnKtrgrToUrun.Items.Add(Eleman);    
            while (Okuyucu.Read())
            {
                Eleman = new ListItem();
                Eleman.Text = Okuyucu["KategoriAD"].ToString();
                Eleman.Value = Okuyucu["KategoriID"].ToString();
                DDwnKtrgrToUrun.Items.Add(Eleman);;
            }
            Baglanti.Close();
        }

        protected void BtnUrunKydt_Click(object sender, EventArgs e)
        {
            String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
            OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
            Baglanti.Open();

            int KategoriID = Convert.ToInt32(DDwnKtrgrToUrun.SelectedItem.Value);
            OleDbCommand Komut = new OleDbCommand("INSERT INTO TBL_URUNLER (KategoriID,UrunAD,UrunMarkası,UrunFiyat,UrunSatısTarihi,MusteriAd,MusteriSoyad,MusteriTelefon,MusteriMail) VALUES (@p1,@p2,@p3,@P4,@p5,@p6,@P7,@p8,@p9)", Baglanti);
            Komut.Parameters.AddWithValue("@P1", KategoriID);
            Komut.Parameters.AddWithValue("@P2", TxtUrunAdi.Text);
            Komut.Parameters.AddWithValue("@P3", TxtUrunMarkasi.Text);
            Komut.Parameters.AddWithValue("@P4", TxtUrunFiyati.Text);
            Komut.Parameters.AddWithValue("@P5", TxtUrunSatisTarihi.Text);
            Komut.Parameters.AddWithValue("@P6", TxtMusteriAdi.Text);
            Komut.Parameters.AddWithValue("@P7", TxtMusteriSoyadi.Text);
            Komut.Parameters.AddWithValue("@P8", TxtMusteriTlfNo.Text);
            Komut.Parameters.AddWithValue("@P9", TxtMusteriMail.Text);
            Komut.ExecuteNonQuery();
            Baglanti.Close();
            Komut.Dispose();
        }
    }
}