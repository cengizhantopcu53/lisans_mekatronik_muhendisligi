using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odev6_TicariAlisverisSitesi
{
    public partial class UrunSıralaEnPahalı : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //EnPahalı=SELECT *  FROM TBL_URUNLER ORDER BY UrunFiyat DESC
            DataSet1TableAdapters.TBL_URUNLER1TableAdapter dt = new DataSet1TableAdapters.TBL_URUNLER1TableAdapter();
            Repeater1.DataSource = dt.EnPahalı();
            Repeater1.DataBind();
        }
    }
}