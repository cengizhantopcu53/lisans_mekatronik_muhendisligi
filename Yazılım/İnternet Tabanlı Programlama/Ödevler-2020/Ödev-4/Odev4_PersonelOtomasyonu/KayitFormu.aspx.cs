using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Odev4_PersonelOtomasyonu
{
    public partial class KayitFormu : System.Web.UI.Page
    {
        // Bağlantı adresini tanımlama
        OleDbConnection Baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\cengi\Desktop\Odev4_PersonelOtomasyonu\App_Data\PersonelVeriTabani.mdb");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            //Bilgileri Kaydetme
            string Ad = TxtAd.Text;
            OleDbCommand kmtkaydet = new OleDbCommand("INSERT INTO Personeller (PersonelAd,PersonelSoyad,PersonelNo,PersonelBrans,PersonelFoto) VALUES (@p1,@p2,@p3,@p4,@p5)", Baglanti);
            kmtkaydet.Parameters.AddWithValue("@p1", Ad);
            kmtkaydet.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            kmtkaydet.Parameters.AddWithValue("@p3", TxtNo.Text);
            kmtkaydet.Parameters.AddWithValue("@p4", TxtBrans.Text);
            kmtkaydet.Parameters.AddWithValue("@p5", "Bos.jpg");
            kmtkaydet.ExecuteNonQuery();
            Baglanti.Close();
            kmtkaydet.Dispose();
            Baglanti.Dispose();
            LblAcıklama.Text = "Personelimiz " + Ad.ToUpper() + "'İN KAYDI GERÇEKLEŞMİŞTİR.";
        }
    }
}