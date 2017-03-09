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
    public partial class Yazarlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                SqlConnection cnn1 = new SqlConnection("Server=.;Database=webKitap;Trusted_Connection=True");
                SqlCommand cmd1 = new SqlCommand("SELECT YazarAd,YazarID FROM YazarTbl", cnn1);
                cnn1.Open();
                SqlDataReader rd1 = cmd1.ExecuteReader();
                DataList2.DataSource = rd1;
                DataList2.DataBind();
                cnn1.Close();
        }

        protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Response.Redirect("WebForm2.aspx?yazID=" + e.CommandArgument);

        }
    }
}