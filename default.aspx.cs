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
            HopDong_Click(sender, e); 
        }

        protected void HopDong_Click(object sender, EventArgs e)
        {
            listItem.Columns[1].HeaderText = "Ngày Hợp Đồng";
            listItem.Columns[2].HeaderText = "Của";
            listItem.Columns[3].HeaderText = "Ngày Thu Tiền Điện";
            listItem.Columns[4].HeaderText = "Ngày Thu Tiền Nước";
            listItem.Columns[5].HeaderText = "Loại Khai Báo";
            listItem.Columns[6].HeaderText = "Phòng Số";
            listItem.Columns[7].HeaderText = "Phiếu Thu";
            listItem.Columns[8].HeaderText = "Phiếu Chi";
            try
            {
                myCon.Open();

                string qry = "SELECT HopDong.Ngay AS Column1, NguoiThue.HoTen AS Column2, Dien.Ngay AS Column3, Nuoc.Ngay AS Column4, KhaiBao.Loai AS Column5, PhongTro.SoPhong AS Column6, PhieuThu.SoCT AS Column7, PhieuChi.SoCT AS Column8 " +
                    "FROM HopDong, NguoiThue, Dien, Nuoc, KhaiBao, PhongTro, PhieuThu, PhieuChi "
                    + "WHERE HopDong.NguoiThue_Id = NguoiThue.Id AND HopDong.Dien_Id = Dien.Id AND HopDong.Nuoc_Id = Nuoc.Id AND " +
                    "HopDong.KhaiBao_Id = KhaiBao.Id AND HopDong.PhongTro_Id = PhongTro.Id AND HopDong.PhieuThu_Id = PhieuThu.Id AND HopDong.PhieuChi_Id = PhieuChi.Id";
                using (SqlCommand cmd = new SqlCommand(qry, myCon))
                {
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
            try
            {
                myCon.Open();

                string qry = "SELECT HoTen AS Column1, SDT AS Column2, CCCD AS Column3, QueQuan AS Column4 FROM NguoiThue";
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

        protected void PhongTro_Click(object sender, EventArgs e)
        {
            try
            {
                myCon.Open();

                string qry = "SELECT SoPhong AS Column1, TinhTrang AS Column2, LoaiPhong AS Column3, DonGia AS Column4 FROM PhongTro";
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

        protected void PhieuThu_Click(object sender, EventArgs e)
        {
            try
            {
                myCon.Open();

                string qry = "SELECT SoCT AS Column1, Ngay AS Column2, TongTien AS Column3, NoiDung AS Column4 FROM PhieuThu";
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

        protected void PhieuChi_Click(object sender, EventArgs e)
        {
            try
            {
                myCon.Open();

                string qry = "SELECT SoCT AS Column1, Ngay AS Column2, TongTien AS Column3, NoiDung AS Column4 FROM PhieuChi";
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

        protected void KhaiBao_Click(object sender, EventArgs e)
        {
            try
            {
                myCon.Open();

                string qry = "SELECT Loai AS Column1, Ngay AS Column2, TinhTrang AS Column3 FROM KhaiBao";
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

        protected void GopY_Click(object sender, EventArgs e)
        {
            try
            {
                myCon.Open();

                string qry = "SELECT Ngay AS Column1, TrangThai AS Column2, NoiDung AS Column3, NguoiThue.HoTen AS Column4 FROM GopY, NguoiThue WHERE GopY.NguoiThue_Id = NguoiThue.Id";
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

        protected void ThietBi_Click(object sender, EventArgs e)
        {
            try
            {
                myCon.Open();

                string qry = "SELECT TenTB AS Column1, Gia AS Column2, NgayMua AS Column3, ThoiGianBH AS Column4, PhongTro.SoPhong AS Column5 FROM ThietBi, PhongTro WHERE ThietBi.PhongTro_Id = PhongTro.Id";
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

        protected void ViewDetail_Click(object sender, EventArgs e)
        {

        }
        protected void Update_Click(object sender, EventArgs e)
        {

        }
        protected void Delete_Click(object sender, EventArgs e)
        {

        }

        

        public void gridView_visible(object sender)
        {
            LinkButton clickedButton = (LinkButton)sender;
            string buttonText = clickedButton.Text;
            switch(buttonText)
            {
                case "Người Thuê":
                    //visible
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = true;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    listItem.Columns[8].Visible = false;
                    //headtext
                    listItem.Columns[1].HeaderText = "Họ Tên";
                    listItem.Columns[2].HeaderText = "Số Điện Thoại";
                    listItem.Columns[3].HeaderText = "Căn Cước Công Dân";
                    listItem.Columns[4].HeaderText = "Quê Quán";

                    break;
                case "Khai Báo":
                    //visible
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = false;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    listItem.Columns[8].Visible = false;
                    //headtext

                    break;
                case "Góp Ý":
                    //visible
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = true;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    listItem.Columns[8].Visible = false;
                    //headtext

                    break;
                case "Điện":
                    //visible
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = false;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    listItem.Columns[8].Visible = false;
                    //headtext
                    listItem.Columns[1].HeaderText = "Ngày";
                    listItem.Columns[2].HeaderText = "Số Chữ Điện";
                    listItem.Columns[3].HeaderText = "Đơn Giá Điện";

                    break;
                case "Nước":
                    //visible
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = false;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    listItem.Columns[8].Visible = false;
                    //headtext
                    listItem.Columns[1].HeaderText = "Ngày";
                    listItem.Columns[2].HeaderText = "Số Chữ Nước";
                    listItem.Columns[3].HeaderText = "Đơn Giá Nước";

                    break;
                case "Phiếu Thu":
                    //visible
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = true;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    listItem.Columns[8].Visible = false;
                    //headtext
                    listItem.Columns[1].HeaderText = "Só Chứng Từ";
                    listItem.Columns[2].HeaderText = "Ngày Thu";
                    listItem.Columns[3].HeaderText = "Tổng Tiền Thu";
                    listItem.Columns[4].HeaderText = "Nội Dung Thu";

                    break;
                case "Phiếu Chi":
                    //visible
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = true;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    listItem.Columns[8].Visible = false;
                    //headtext
                    listItem.Columns[1].HeaderText = "Só Chứng Từ";
                    listItem.Columns[2].HeaderText = "Ngày Chi";
                    listItem.Columns[3].HeaderText = "Tổng Tiền Chi";
                    listItem.Columns[4].HeaderText = "Nội Dung Chi";

                    break;
                case "Phòng Trọ":
                    //visible
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = true;
                    listItem.Columns[5].Visible = false;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    listItem.Columns[8].Visible = false;
                    //headtext
                    listItem.Columns[1].HeaderText = "Số Phòng";
                    listItem.Columns[2].HeaderText = "Tình Trạng";
                    listItem.Columns[3].HeaderText = "Loại Phòng";
                    listItem.Columns[4].HeaderText = "Đơn Giá";

                    break;
                case "Thiết Bị":
                    //visible
                    listItem.Columns[1].Visible = true;
                    listItem.Columns[2].Visible = true;
                    listItem.Columns[3].Visible = true;
                    listItem.Columns[4].Visible = true;
                    listItem.Columns[5].Visible = true;
                    listItem.Columns[6].Visible = false;
                    listItem.Columns[7].Visible = false;
                    listItem.Columns[8].Visible = false;
                    //headtext
                    listItem.Columns[1].HeaderText = "Tên Thiết Bị";
                    listItem.Columns[2].HeaderText = "Giá";
                    listItem.Columns[3].HeaderText = "Ngày Mua";
                    listItem.Columns[4].HeaderText = "Thời Gian Bảo Hành";
                    listItem.Columns[5].HeaderText = "Của Phòng";

                    break;
            }
        }
    }
}