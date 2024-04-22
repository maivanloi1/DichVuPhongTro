using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD10_DichVuPhongTro
{
    public partial class _default : System.Web.UI.Page
    {
        SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["localConnection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Nuoc_Click(object sender, EventArgs e)
        {
            try
            {
                myCon.Open();

                string qry = "SELECT * FROM Nuoc";
                using (SqlCommand cmd = new SqlCommand(qry, myCon))
                {

                    listItem_Dien.DataSource = null;
                    listItem_Dien.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem_Nuoc.DataSource = sdr;
                    listItem_Nuoc.DataBind();
                    sdr.Close();
                }



            }
            catch (Exception ex) { }
            finally { myCon.Close(); }
        }

        protected void Dien_Click(object sender, EventArgs e)
        {
            try
            {
                myCon.Open();

                string qry = "SELECT * FROM Dien";
                using (SqlCommand cmd = new SqlCommand(qry, myCon))
                {
                    listItem_Nuoc.DataSource = null;
                    listItem_Nuoc.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem_Dien.DataSource = sdr;
                    listItem_Dien.DataBind();
                    sdr.Close();
                }



            }
            catch (Exception ex) { }
            finally { myCon.Close(); }
        }
    }
}