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
    public partial class Listeleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Ürünleri Listeleme
        protected void BtnUrunList_Click(object sender, EventArgs e)
        {
            String BaglantiYolu = ConfigurationManager.ConnectionStrings["VT_Baglanti"].ConnectionString;
            OleDbConnection Baglanti = new OleDbConnection(BaglantiYolu);
            Baglanti.Open();

            OleDbDataAdapter Adapter1 = new OleDbDataAdapter("SELECT * FROM TBL_URUNLER", Baglanti);
            System.Data.DataSet DataSet1 = new System.Data.DataSet();
            Adapter1.Fill(DataSet1, "Tablo1");
            GridView1.DataSource = DataSet1.Tables["Tablo1"];
            GridView1.DataBind();
            Baglanti.Close();
            Adapter1.Dispose();
        }
    }
}