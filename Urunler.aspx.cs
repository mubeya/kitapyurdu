using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace eTicaretSayfasi
{
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["catId"]))
            // Response.Redirect("~/Default.aspx");
            {
                SqlConnection cnn = new SqlConnection("Server=.;Database=webKitap;Trusted_Connection=True");
                SqlCommand cmd = new SqlCommand("SELECT UrunAd,UrunID,UrunUcret,ResimAdres FROM UrunTbl", cnn);
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                DataList1.DataSource = rd;
                DataList1.DataBind();
                cnn.Close();


            }

            else
            {
                SqlConnection cnn1 = new SqlConnection("Server=.;Database=webKitap;Trusted_Connection=True");
                SqlCommand cmd1 = new SqlCommand("SELECT UrunAd,UrunID,UrunUcret,ResimAdres FROM UrunTbl WHERE KategoriID= @cid", cnn1);
                cmd1.Parameters.AddWithValue("@cid", Request.QueryString["catID"]); // @cid parametreye değeri atadık
                cnn1.Open();
                SqlDataReader rd1 = cmd1.ExecuteReader();
                DataList1.DataSource = rd1;
                DataList1.DataBind();
                cnn1.Close();
            }
        }
    }
}