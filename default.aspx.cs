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

                string qry = "SELECT HopDong.Ngay AS Column1, NguoiThue.HoTen AS Column2, Dien.Ngay AS Column3, Nuoc.Ngay AS Column4, KhaiBao.Loai AS Column5, PhongTro.SoPhong AS Column6, PhieuThu.SoCT AS Column7, PhieuChi.SoCT AS Column8 " +
                    "FROM HopDong, NguoiThue, Dien, Nuoc, KhaiBao, PhongTro, PhieuThu, PhieuChi "
                    + "WHERE HopDong.NguoiThue_Id = NguoiThue.Id AND HopDong.Dien_Id = Dien.Id AND HopDong.Nuoc_Id = Nuoc.Id AND " +
                    "HopDong.KhaiBao_Id = KhaiBao.Id AND HopDong.PhongTro_Id = PhongTro.Id AND HopDong.PhieuThu_Id = PhieuThu.Id AND HopDong.PhieuChi_Id = PhieuChi.Id";
                using (SqlCommand cmd = new SqlCommand(qry, myCon))
                {
                    gridView_visible(sender);
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
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

                string qry = "SELECT Ngay AS Column1, SoChuNuoc AS Column2, DonGia AS Column3 FROM Nuoc";
                using (SqlCommand cmd = new SqlCommand(qry, myCon))
                {
                    gridView_visible(sender);
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
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

                string qry = "SELECT Ngay AS Column1, SoChuDien AS Column2, DonGia AS Column3 FROM Dien";
                using (SqlCommand cmd = new SqlCommand(qry, myCon))
                {
                    gridView_visible(sender);
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
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

        public void gridView_visible(object sender)
        {
            LinkButton clickedButton = (LinkButton)sender;
            string buttonText = clickedButton.Text;
            switch(buttonText)
            {
                case "Hợp Đồng":
                    //visible
                    listItem.Columns[0].Visible = true;
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = true;
                    listItem.Columns[5].Visible = true;
                    listItem.Columns[6].Visible = true;
                    listItem.Columns[7].Visible = true;
                    
                    //headtext
                    listItem.Columns[0].HeaderText = "Ngày Hợp Đồng";
                    listItem.Columns[1].HeaderText = "Của";
                    listItem.Columns[2].HeaderText = "Ngày Thu Tiền Điện";
                    listItem.Columns[3].HeaderText = "Ngày Thu Tiền Nước";
                    listItem.Columns[4].HeaderText = "Loại Khai Báo";
                    listItem.Columns[5].HeaderText = "Phòng Số";
                    listItem.Columns[6].HeaderText = "Phiếu Thu";
                    listItem.Columns[7].HeaderText = "Phiếu Chi";

                    break;
                case "Người Thuê":
                    //visible
                    listItem.Columns[0].Visible = true;
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = false;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    //headtext
                    listItem.Columns[0].HeaderText = "Họ Tên";
                    listItem.Columns[1].HeaderText = "Số Điện Thoại";
                    listItem.Columns[2].HeaderText = "Căn Cước Công Dân";
                    listItem.Columns[3].HeaderText = "Quê Quán";

                    break;
                case "Khai Báo":
                    //visible
                    listItem.Columns[0].Visible = true;
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = false;
                    listItem.Columns[4].Visible = false;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    //headtext

                    break;
                case "Góp Ý":
                    //visible
                    listItem.Columns[0].Visible = true;
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = false;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    //headtext

                    break;
                case "Điện":
                    //visible
                    listItem.Columns[0].Visible = true;
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = false;
                    listItem.Columns[4].Visible = false;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    //headtext
                    listItem.Columns[0].HeaderText = "Ngày";
                    listItem.Columns[1].HeaderText = "Số Chữ Điện";
                    listItem.Columns[2].HeaderText = "Đơn Giá Điện";

                    break;
                case "Nước":
                    //visible
                    listItem.Columns[0].Visible = true;
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = false;
                    listItem.Columns[4].Visible = false;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    //headtext
                    listItem.Columns[0].HeaderText = "Ngày";
                    listItem.Columns[1].HeaderText = "Số Chữ Nước";
                    listItem.Columns[2].HeaderText = "Đơn Giá Nước";

                    break;
                case "Phiếu Thu":
                    //visible
                    listItem.Columns[0].Visible = true;
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = false;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    //headtext

                    break;
                case "Phiếu Chi":
                    //visible
                    listItem.Columns[0].Visible = true;
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = false;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    //headtext

                    break;
                case "Phòng Trọ":
                    //visible
                    listItem.Columns[0].Visible = true;
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = false;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    //headtext

                    break;
                case "Thiết Bị":
                    //visible
                    listItem.Columns[0].Visible = true;
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = true;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    //headtext

                    break;
            }
        }
    }
}