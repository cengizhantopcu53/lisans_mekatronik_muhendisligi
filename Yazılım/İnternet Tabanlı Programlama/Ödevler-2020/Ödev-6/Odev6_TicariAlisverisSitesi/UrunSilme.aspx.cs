using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odev6_TicariAlisverisSitesi
{
    public partial class SilmeSayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //UrunSil=DELETE FROM TBL_URUNLER WHERE UrunID=@P1
            int x = Convert.ToInt32(Request.QueryString["UrunID"].ToString());
            DataSet1TableAdapters.TBL_URUNLER1TableAdapter dt = new DataSet1TableAdapters.TBL_URUNLER1TableAdapter();
            dt.UrunSil(x);
            Response.Redirect("Urunler.aspx");
        }
    }
}