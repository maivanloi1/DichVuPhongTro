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
            try
            {
                myCon.Open();

                string qry = "SELECT HopDong.Ngay, NguoiThue.HoTen, Dien.Ngay,Nuoc.Ngay, KhaiBao.Loai, PhongTro.SoPhong, PhieuThu.SoCT AS PhieuThu, PhieuChi.SoCT AS PhieuChi " +
                    "FROM HopDong, NguoiThue, Dien, Nuoc, KhaiBao, PhongTro, PhieuThu, PhieuChi "
                    + "WHERE HopDong.NguoiThue_Id = NguoiThue.Id AND HopDong.Dien_Id = Dien.Id AND HopDong.Nuoc_Id = Nuoc.Id AND " +
                    "HopDong.KhaiBao_Id = KhaiBao.Id AND HopDong.PhongTro_Id = PhongTro.Id AND HopDong.PhieuThu_Id = PhieuThu.Id AND HopDong.PhieuChi_Id = PhieuChi.Id";
                using (SqlCommand cmd = new SqlCommand(qry, myCon))
                {
                    clearBind();
                    listItem_HopDong.DataSource = null;
                    listItem_HopDong.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem_HopDong.DataSource = sdr;
                    listItem_HopDong.DataBind();
                    sdr.Close();
                }



            }
            catch (Exception ex) { }
            finally { myCon.Close(); }
        }

        protected void HopDong_Click(object sender, EventArgs e)
        {
            Page_Load(sender, e);
        }
        protected void Nuoc_Click(object sender, EventArgs e)
        {
            try
            { 
                myCon.Open();

                string qry = "SELECT * FROM Nuoc";
                using (SqlCommand cmd = new SqlCommand(qry, myCon))
                {
                    clearBind();
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
                    clearBind();
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

        protected void NguoiThue_Click(object sender, EventArgs e)
        {
        }

        protected void PhongTro_Click(object sender, EventArgs e)
        {

        }

        protected void PhieuThu_Click(object sender, EventArgs e)
        {
        }

        protected void PhieuChi_Click(object sender, EventArgs e)
        {
        }

        protected void KhaiBao_Click(object sender, EventArgs e)
        {
        }

        protected void GopY_Click(object sender, EventArgs e)
        {
        }

        protected void ThietBi_Click(object sender, EventArgs e)
        {
        }

        public void clearBind()
        {
            listItem_Dien.DataSource = null;
            listItem_Dien.DataBind();
            listItem_HopDong.DataSource = null;
            listItem_HopDong.DataBind();
            listItem_Nuoc.DataSource = null;
            listItem_Nuoc.DataBind();
        }
    }
}