using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace eTicaretSayfasi
{
    public partial class KitapTur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cnn1 = new SqlConnection("Server=.;Database=webKitap;Trusted_Connection=True");
            SqlCommand cmd1 = new SqlCommand("SELECT DISTINCT KitapTur FROM UrunTbl", cnn1);
            cnn1.Open();
            SqlDataReader rd1 = cmd1.ExecuteReader();
            DataList2.DataSource = rd1;
            DataList2.DataBind();
            cnn1.Close();
        }
    }
}