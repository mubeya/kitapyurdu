using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
 
namespace eTicaretSayfasi
{
    public partial class UrunDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["uid"]))
                Response.Redirect("~/Default.aspx");

            SqlConnection cnn = new SqlConnection("Server=.;Database=webKitap;Trusted_Connection=True");
            SqlCommand cmd = new SqlCommand("SELECT UrunAd,KitapOzet,ResimAdres,BasımEvi,BasımTarih,SayfaSayisi,KitapDil,ISBN,UrunID,UrunUcret,UrunStok FROM UrunTbl WHERE UrunID= @pid", cnn);
            cmd.Parameters.AddWithValue("@pid",Request.QueryString["uid"]);
            cnn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
               /* ltrAd.Text = rd[0].ToString();
                ltrKonu.Text=rd[1].ToString();
                ltrYayın.Text = rd[3].ToString();
                ltrYıl.Text = rd[4].ToString();
                ltrSayfa.Text = rd[5].ToString();
                ltrKitapDil.Text = rd[6].ToString();
                ltrISBN.Text = rd[7].ToString();
                ltrUrunID.Text = rd[8].ToString();
                ltrFiyat.Text = rd[9].ToString();
                ltrStok.Text = rd[10].ToString();
                imgUrun.ImageUrl = rd[2].ToString();
            
                 */
            }
            cnn.Close();
        }

    }
}