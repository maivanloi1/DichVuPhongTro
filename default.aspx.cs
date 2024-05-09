using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD10_DichVuPhongTro
{
    public partial class _default : System.Web.UI.Page
    {
        String tableName = "1";
        int ID;
        SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["localConnection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

            string user = (string)Session["username"];

            if (user == "admin")
            { 
                Session["username"] = "admin";

            }
            else
                listItem.Visible = false;

            if (string.IsNullOrEmpty(user) == false)
            {
                LoginBtn.Visible = false;
                LogoutBtn.Visible = true;
                CurrentUser.Text = user;
            }
            else
            {
                LoginBtn.Visible = true;
                LogoutBtn.Visible = false;
                CurrentUser.Text = "";
            }


        }

        protected void HopDong_Click(object sender, EventArgs e)
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
                    gridView_visible("Hợp Đồng");
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
                    sdr.Close();
                }



            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
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
                    gridView_visible("Nước");
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
                    sdr.Close();
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
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
                    gridView_visible("Điện");
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
                    sdr.Close();
                }



            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
            finally
            {
                myCon.Close();
            }
        }

        protected void NguoiThue_Click(object sender, EventArgs e)
        {
            try
            {
                myCon.Open();

                string qry = "SELECT HoTen AS Column1, SDT AS Column2, CCCD AS Column3, QueQuan AS Column4 FROM NguoiThue";
                using (SqlCommand cmd = new SqlCommand(qry, myCon))
                {
                    gridView_visible("Người Thuê");
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
                    sdr.Close();
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
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
                    gridView_visible("Phòng Trọ");
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
                    sdr.Close();
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
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
                    gridView_visible("Phiếu Thu");
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
                    sdr.Close();
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
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
                    gridView_visible("Phiếu Chi");
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
                    sdr.Close();
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
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
                    gridView_visible("Khai Báo");
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
                    sdr.Close();
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
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
                    gridView_visible("Góp Ý");
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
                    sdr.Close();
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
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
                    gridView_visible("Thiết Bị");
                    listItem.DataSource = null;
                    listItem.DataBind();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    listItem.DataSource = sdr;
                    listItem.DataBind();
                    sdr.Close();
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
            finally { myCon.Close(); }
        }

        protected void ThongKe_Click(object sender, EventArgs e)
        {
            lblTK.Visible = true;
            close_TK.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "LaunchServerSide", "$(function() { openTK(); });", true);
        }

        public void btnDel_Click(object sender, EventArgs e)
        {
            ID = int.Parse(txtDel.Text);
            String nametable = dlDel.SelectedValue;

            try
            {
                myCon = DBClass.OpenConn();
                switch(nametable)
                {
                    case "HopDong":
                        using (SqlCommand cmd = new SqlCommand("dbo.DelHD", myCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.ExecuteScalar();
                        }
                        break;
                    case "NguoiThue":
                        using (SqlCommand cmd = new SqlCommand("dbo.DelNT", myCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.ExecuteScalar();
                        }
                        break;
                    case "PhongTro":
                        using (SqlCommand cmd = new SqlCommand("dbo.DelPTro", myCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.ExecuteScalar();
                        }
                        break;
                    case "Dien":
                        using (SqlCommand cmd = new SqlCommand("dbo.DelDien", myCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.ExecuteScalar();
                        }
                        break;
                    case "Nuoc":
                        using (SqlCommand cmd = new SqlCommand("dbo.DelNuoc", myCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.ExecuteScalar();
                        }
                        break;
                    case "KhaiBao":
                        using (SqlCommand cmd = new SqlCommand("dbo.DelKB", myCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.ExecuteScalar();
                        }
                        break;
                    case "ThietBi":
                        using (SqlCommand cmd = new SqlCommand("dbo.DelTB", myCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.ExecuteScalar();
                        }
                        break;
                    case "PhieuThu":
                        using (SqlCommand cmd = new SqlCommand("dbo.DelPT", myCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.ExecuteScalar();
                        }
                        break;
                    case "PhieuChi":
                        using (SqlCommand cmd = new SqlCommand("dbo.DelPC", myCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.ExecuteScalar();
                        }
                        break;
                    case "GopY":
                        using (SqlCommand cmd = new SqlCommand("dbo.DelGY", myCon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.ExecuteScalar();
                        }
                        break;

                }

            }
            catch (Exception ex) { Response.Write("<script>alert('btnDel Error with "+ex.Message+"')</script>"); }
            finally { myCon.Close(); }
        }
        public void btnTK_Click(object sender, EventArgs e)
        {

            ID = int.Parse(TbTK.Text);
            DateTime year = DateTime.Now;
            int yearNow = Convert.ToInt32(DateTime.Parse(year.ToString()).Year);
            try
            {
                myCon = DBClass.OpenConn();
                using (SqlCommand cmd = new SqlCommand("dbo.ThongKeThu_Thang", myCon))
                {
                    cmd.Connection = myCon;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Month", SqlDbType.Int).Value = ID;
                    cmd.Parameters.Add("@Year", SqlDbType.Int).Value = yearNow;
                    SqlDataReader myDr1 = cmd.ExecuteReader();

                    if (myDr1.HasRows)
                    {
                        while (myDr1.Read())
                        {
                            lbltkpt.Text = "Tổng Thu Năm " + yearNow + " là: " + myDr1.GetValue(0).ToString();
                        }


                    }
                    myCon.Close();
                }
                myCon = DBClass.OpenConn();
                using (SqlCommand cmd = new SqlCommand("dbo.ThongKeChi_Thang", myCon))
                {
                    cmd.Connection = myCon;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Month", SqlDbType.Int).Value = ID;
                    cmd.Parameters.Add("@Year", SqlDbType.Int).Value = yearNow;
                    SqlDataReader myDr2 = cmd.ExecuteReader();

                    if (myDr2.HasRows)
                    {
                        while (myDr2.Read())
                        {
                            lbltkpc.Text = "Tổng Chi Năm " + yearNow + " là: " + myDr2.GetValue(0).ToString();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Thống Kê Error With " + ex.Message + "')</script>");
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "LaunchServerSide", "$(function() { openTK(); });", true);

        }


        protected void btnSlcID_Click(object sender, EventArgs e)
        {
            tableName = listTable.SelectedValue;
            try
            {
                ID = Convert.ToInt32(TbID.Text);
                String sql = "SELECT * FROM " + tableName + " WHERE Id = " + ID;
                getNhomForDL(tableName);
                View_Upd(tableName);
                try
                {
                    myCon = DBClass.OpenConn();
                    using (SqlCommand myCmd = new SqlCommand(sql, myCon))
                    {
                        myCmd.Connection = myCon;
                        myCmd.CommandType = CommandType.Text;

                        SqlDataReader myDr = myCmd.ExecuteReader();

                        if (myDr.HasRows)
                        {
                            while (myDr.Read())
                            {

                                switch (tableName)
                                {
                                    case "HopDong":
                                        txt1.Text = myDr.GetValue(1).ToString();

                                        dl1.SelectedValue = myDr.GetValue(2).ToString();
                                        dl2.SelectedValue = myDr.GetValue(3).ToString();
                                        dl3.SelectedValue = myDr.GetValue(4).ToString();
                                        dl4.SelectedValue = myDr.GetValue(5).ToString();
                                        dl5.SelectedValue = myDr.GetValue(6).ToString();
                                        dl6.SelectedValue = myDr.GetValue(7).ToString();
                                        dl7.SelectedValue = myDr.GetValue(8).ToString();

                                        break;
                                    case "NguoiThue":
                                        txt1.Text = myDr.GetValue(1).ToString();
                                        txt2.Text = myDr.GetValue(2).ToString();
                                        txt3.Text = myDr.GetValue(3).ToString();
                                        txt4.Text = myDr.GetValue(4).ToString();

                                        break;
                                    case "PhongTro":
                                        txt1.Text = myDr.GetValue(1).ToString();
                                        txt2.Text = myDr.GetValue(2).ToString();
                                        txt3.Text = myDr.GetValue(3).ToString();
                                        txt4.Text = myDr.GetValue(4).ToString();

                                        break;
                                    case "Dien":
                                        txt1.Text = myDr.GetValue(1).ToString();
                                        txt2.Text = myDr.GetValue(2).ToString();
                                        txt3.Text = myDr.GetValue(3).ToString();

                                        break;
                                    case "Nuoc":
                                        txt1.Text = myDr.GetValue(1).ToString();
                                        txt2.Text = myDr.GetValue(2).ToString();
                                        txt3.Text = myDr.GetValue(3).ToString();

                                        break;
                                    case "KhaiBao":
                                        txt1.Text = myDr.GetValue(1).ToString();
                                        txt2.Text = myDr.GetValue(2).ToString();
                                        txt3.Text = myDr.GetValue(3).ToString();

                                        break;
                                    case "PhieuThu":
                                        txt1.Text = myDr.GetValue(1).ToString();
                                        txt2.Text = myDr.GetValue(2).ToString();
                                        txt3.Text = myDr.GetValue(3).ToString();
                                        txt4.Text = myDr.GetValue(4).ToString();

                                        break;
                                    case "PhieuChi":
                                        txt1.Text = myDr.GetValue(1).ToString();
                                        txt2.Text = myDr.GetValue(2).ToString();
                                        txt3.Text = myDr.GetValue(3).ToString();
                                        txt4.Text = myDr.GetValue(4).ToString();

                                        break;
                                    case "ThietBi":
                                        txt1.Text = myDr.GetValue(1).ToString();
                                        txt2.Text = myDr.GetValue(2).ToString();
                                        txt3.Text = myDr.GetValue(3).ToString();
                                        txt4.Text = myDr.GetValue(4).ToString();
                                        dl1.SelectedValue = myDr.GetValue(5).ToString();

                                        break;
                                    case "GopY":
                                        txt1.Text = myDr.GetValue(1).ToString();
                                        txt2.Text = myDr.GetValue(2).ToString();
                                        txt3.Text = myDr.GetValue(3).ToString();
                                        dl1.SelectedValue = myDr.GetValue(4).ToString();

                                        break;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>");
                }
                finally { myCon.Close(); }
                ScriptManager.RegisterStartupScript(this, this.GetType(), "LaunchServerSide", "$(function() { openDetail(); });", true);


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Vui Lòng Nhập ID" + ex.Message + "')</script>");
            }

        }
        protected void Update_Click(object sender, EventArgs e)
        {

            lblUpd.Visible = true;
            btnUpd.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "LaunchServerSide", "$(function() { openDetail(); });", true);

        }

        protected void btnUpd_Click(object sender, EventArgs e)
        {
            String nametb = listTable.SelectedValue;
            Upd_Table(nametb);
            switch(nametb)
            {
                case "HopDong":
                    HopDong_Click(sender, e); 
                    break;
                case "NguoiThue":
                    NguoiThue_Click(sender, e); 
                    break;
                case "PhongTro":
                    PhongTro_Click(sender, e); 
                    break;
                case "Dien":
                    Dien_Click(sender, e); 
                    break;
                case "Nuoc":
                    Nuoc_Click(sender, e); 
                    break;
                case "PhieuThu":
                    PhieuThu_Click(sender, e); 
                    break;
                case "PhieuChi":
                    PhieuChi_Click(sender, e); 
                    break;
                case "KhaiBao":
                    KhaiBao_Click(sender, e); 
                    break;
                case "GopY":
                    GopY_Click(sender, e); 
                    break;
                case "ThietBi":
                    ThietBi_Click(sender, e); 
                    break;
                
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            lbDel.Visible = true;
            btnDelete.Visible = true;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "LaunchServerSide", "$(function() { openDelete(); });", true);
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Response.Redirect("Default.aspx");
        }

        public void getNhomForDL(String tbname)
        {
            try
            {
                myCon = DBClass.OpenConn();
                switch (tbname)
                {

                    case "HopDong":
                        String mysqlhp1 = "SELECT * FROM NguoiThue";

                        using (SqlCommand cmd = new SqlCommand(mysqlhp1, myCon))
                        {
                            SqlDataReader myDr = cmd.ExecuteReader();
                            dl1.DataSource = myDr;
                            dl1.DataTextField = "HoTen";
                            dl1.DataValueField = "Id";
                            dl1.DataBind();
                            dl1.Items.Insert(0, new ListItem("-- Chọn Người Thuê --", "0"));
                            myDr.Close();
                        }
                        String mysqlhp2 = "SELECT * FROM Dien";
                        using (SqlCommand cmd = new SqlCommand(mysqlhp2, myCon))
                        {
                            SqlDataReader myDr = cmd.ExecuteReader();
                            dl2.DataSource = myDr;
                            dl2.DataTextField = "Ngay";
                            dl2.DataValueField = "Id";
                            dl2.DataBind();
                            dl2.Items.Insert(0, new ListItem("-- Chọn Ngày --", "0"));
                            myDr.Close();
                        }
                        String mysqlhp3 = "SELECT * FROM Nuoc";

                        using (SqlCommand cmd = new SqlCommand(mysqlhp3, myCon))
                        {
                            SqlDataReader myDr = cmd.ExecuteReader();
                            dl3.DataSource = myDr;
                            dl3.DataTextField = "Ngay";
                            dl3.DataValueField = "Id";
                            dl3.DataBind();
                            dl3.Items.Insert(0, new ListItem("-- Chọn Ngày --", "0"));
                            myDr.Close();
                        }
                        String mysqlhp4 = "SELECT * FROM KhaiBao";

                        using (SqlCommand cmd = new SqlCommand(mysqlhp4, myCon))
                        {
                            SqlDataReader myDr = cmd.ExecuteReader();
                            dl4.DataSource = myDr;
                            dl4.DataTextField = "Loai";
                            dl4.DataValueField = "Id";
                            dl4.DataBind();
                            dl4.Items.Insert(0, new ListItem("-- Chọn Loại Khai Báo --", "0"));
                            myDr.Close();
                        }
                        String mysqlhp5 = "SELECT * FROM PhongTro";

                        using (SqlCommand cmd = new SqlCommand(mysqlhp5, myCon))
                        {
                            SqlDataReader myDr = cmd.ExecuteReader();
                            dl5.DataSource = myDr;
                            dl5.DataTextField = "SoPhong";
                            dl5.DataValueField = "Id";
                            dl5.DataBind();
                            dl5.Items.Insert(0, new ListItem("-- Chọn Phòng --", "0"));
                            myDr.Close();
                        }
                        String mysqlhp6 = "SELECT * FROM PhieuThu";

                        using (SqlCommand cmd = new SqlCommand(mysqlhp6, myCon))
                        {
                            SqlDataReader myDr = cmd.ExecuteReader();
                            dl6.DataSource = myDr;
                            dl6.DataTextField = "SoCT";
                            dl6.DataValueField = "Id";
                            dl6.DataBind();
                            dl6.Items.Insert(0, new ListItem("-- Chọn Số Phiếu Thu --", "0"));
                            myDr.Close();
                        }
                        String mysqlhp7 = "SELECT * FROM PhieuChi";

                        using (SqlCommand cmd = new SqlCommand(mysqlhp7, myCon))
                        {
                            SqlDataReader myDr = cmd.ExecuteReader();
                            dl7.DataSource = myDr;
                            dl7.DataTextField = "SoCT";
                            dl7.DataValueField = "Id";
                            dl7.DataBind();
                            dl7.Items.Insert(0, new ListItem("-- Chọn Số Phiếu Chi --", "0"));
                            myDr.Close();
                        }
                        break;

                    case "GopY":
                        String mysqlnt1 = "SELECT * FROM NguoiThue";

                        using (SqlCommand cmd = new SqlCommand(mysqlnt1, myCon))
                        {
                            SqlDataReader myDr = cmd.ExecuteReader();
                            dl1.DataSource = myDr;
                            dl1.DataTextField = "HoTen";
                            dl1.DataValueField = "Id";
                            dl1.DataBind();
                            dl1.Items.Insert(0, new ListItem("-- Chọn Người Thuê --", "0"));
                            myDr.Close();
                        }
                        break;
                    case "ThietBi":
                        String mysqlpt1 = "SELECT * FROM PhongTro";

                        using (SqlCommand cmd = new SqlCommand(mysqlpt1, myCon))
                        {
                            SqlDataReader myDr = cmd.ExecuteReader();
                            dl1.DataSource = myDr;
                            dl1.DataTextField = "SoPhong";
                            dl1.DataValueField = "Id";
                            dl1.DataBind();
                            dl1.Items.Insert(0, new ListItem("-- Chọn Số Phòng --", "0"));
                            myDr.Close();
                        }
                        break;
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
            finally { myCon.Close(); }
        }
        public void View_Upd(String tbname)
        {
            switch (tbname)
            {
                case "HopDong":
                    txt1.Visible = true;
                    txt2.Visible = false;
                    txt3.Visible = false;
                    txt4.Visible = false;
                    dl1.Visible = true;
                    dl2.Visible = true;
                    dl3.Visible = true;
                    dl4.Visible = true;
                    dl5.Visible = true;
                    dl6.Visible = true;
                    dl7.Visible = true;

                    txt1.ToolTip = "Ngày Hợp Đồng";
                    break;
                case "NguoiThue":
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    dl1.Visible = false;
                    dl2.Visible = false;
                    dl3.Visible = false;
                    dl4.Visible = false;
                    dl5.Visible = false;
                    dl6.Visible = false;
                    dl7.Visible = false;

                    txt1.ToolTip = "Họ Tên";
                    txt2.ToolTip = "Số Điện Thoại";
                    txt3.ToolTip = "Căn Cước Công Dân";
                    txt4.ToolTip = "Quê Quán";
                    break;
                case "PhongTro":
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    dl1.Visible = false;
                    dl2.Visible = false;
                    dl3.Visible = false;
                    dl4.Visible = false;
                    dl5.Visible = false;
                    dl6.Visible = false;
                    dl7.Visible = false;

                    txt1.ToolTip = "Số Phòng";
                    txt2.ToolTip = "Tình Trạng";
                    txt3.ToolTip = "Loại Phòng";
                    txt4.ToolTip = "Đơn Giá";
                    break;
                case "PhieuThu":
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    dl1.Visible = false;
                    dl2.Visible = false;
                    dl3.Visible = false;
                    dl4.Visible = false;
                    dl5.Visible = false;
                    dl6.Visible = false;
                    dl7.Visible = false;

                    txt1.ToolTip = "Số Chứng Từ";
                    txt2.ToolTip = "Ngày Thu";
                    txt3.ToolTip = "Tổng Tiền Thu";
                    txt4.ToolTip = "Nội Dung Thu";
                    break;
                case "PhieuChi":
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    dl1.Visible = false;
                    dl2.Visible = false;
                    dl3.Visible = false;
                    dl4.Visible = false;
                    dl5.Visible = false;
                    dl6.Visible = false;
                    dl7.Visible = false;

                    txt1.ToolTip = "Số Chứng Từ";
                    txt2.ToolTip = "Ngày Thu";
                    txt3.ToolTip = "Tổng Tiền Chi";
                    txt4.ToolTip = "Nội Dung Chi";
                    break;
                case "Nuoc":
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = false;
                    dl1.Visible = false;
                    dl2.Visible = false;
                    dl3.Visible = false;
                    dl4.Visible = false;
                    dl5.Visible = false;
                    dl6.Visible = false;
                    dl7.Visible = false;

                    txt1.ToolTip = "Ngày";
                    txt2.ToolTip = "Số Chữ Nước";
                    txt3.ToolTip = "Đơn Giá Nước";
                    break;
                case "Dien":
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = false;
                    dl1.Visible = false;
                    dl2.Visible = false;
                    dl3.Visible = false;
                    dl4.Visible = false;
                    dl5.Visible = false;
                    dl6.Visible = false;
                    dl7.Visible = false;

                    txt1.ToolTip = "Ngày";
                    txt2.ToolTip = "Số Chữ Điện";
                    txt3.ToolTip = "Đơn Giá Điện";
                    break;
                case "ThietBi":
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = true;
                    dl1.Visible = true;
                    dl2.Visible = false;
                    dl3.Visible = false;
                    dl4.Visible = false;
                    dl5.Visible = false;
                    dl6.Visible = false;
                    dl7.Visible = false;

                    txt1.ToolTip = "Tên Thiết Bị";
                    txt2.ToolTip = "Giá";
                    txt3.ToolTip = "Ngày Mua";
                    txt4.ToolTip = "Thời Gian Bảo Hành";
                    break;
                case "KhaiBao":
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = false;
                    dl1.Visible = false;
                    dl2.Visible = false;
                    dl3.Visible = false;
                    dl4.Visible = false;
                    dl5.Visible = false;
                    dl6.Visible = false;
                    dl7.Visible = false;

                    txt1.ToolTip = "Loại Khai Báo";
                    txt2.ToolTip = "Ngày";
                    txt3.ToolTip = "Tình Trạng";
                    break;
                case "GopY":
                    txt1.Visible = true;
                    txt2.Visible = true;
                    txt3.Visible = true;
                    txt4.Visible = false;
                    dl1.Visible = true;
                    dl2.Visible = false;
                    dl3.Visible = false;
                    dl4.Visible = false;
                    dl5.Visible = false;
                    dl6.Visible = false;
                    dl7.Visible = false;

                    txt1.ToolTip = "Ngày";
                    txt2.ToolTip = "Trạng Thái";
                    txt3.ToolTip = "Nội Dung";
                    break;
            }
        }

        public void Upd_Table(String tbname)
        {
            try
            {
                myCon = DBClass.OpenConn();
                ID = Convert.ToInt32(TbID.Text);
                switch(tbname)
                {
                    case "HopDong":
                        using (SqlCommand cmd = new SqlCommand("dbo.UpdateHD", myCon))
                        {
                            cmd.Connection = myCon;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.Parameters.Add("@Ngay", SqlDbType.DateTime).Value = DateTime.Parse(txt1.Text);
                            cmd.Parameters.Add("@NT_ID", SqlDbType.NVarChar).Value = dl1.SelectedValue;
                            cmd.Parameters.Add("@D_ID", SqlDbType.NVarChar).Value = dl2.SelectedValue;
                            cmd.Parameters.Add("@N_ID", SqlDbType.NVarChar).Value = dl3.SelectedValue;
                            cmd.Parameters.Add("@KB_ID", SqlDbType.NVarChar).Value = dl4.SelectedValue;
                            cmd.Parameters.Add("@PTro_ID", SqlDbType.NVarChar).Value = dl5.SelectedValue;
                            cmd.Parameters.Add("@PT_ID", SqlDbType.NVarChar).Value = dl6.SelectedValue;
                            cmd.Parameters.Add("@PC_ID", SqlDbType.NVarChar).Value = dl7.SelectedValue;


                            int rows = cmd.ExecuteNonQuery();
                        }
                        break;
                    case "NguoiThue":
                        using (SqlCommand cmd = new SqlCommand("dbo.UpdateNT", myCon))
                        {
                            cmd.Connection = myCon;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = txt1.Text;
                            cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = txt2.Text;
                            cmd.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = txt3.Text;
                            cmd.Parameters.Add("@QueQuan", SqlDbType.NVarChar).Value = txt4.Text;

                            int rows = cmd.ExecuteNonQuery();
                        }
                        break;
                    case "PhieuThu":
                    case "PhieuChi":
                        using (SqlCommand cmd = new SqlCommand("dbo.UpdatePTPC", myCon))
                        {
                            cmd.Connection = myCon;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.Parameters.Add("@SoCT", SqlDbType.NVarChar).Value = txt1.Text;
                            cmd.Parameters.Add("@Ngay", SqlDbType.DateTime).Value = DateTime.Parse(txt2.Text);
                            cmd.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = decimal.Parse(txt3.Text);
                            cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar).Value = txt4.Text;

                            int rows = cmd.ExecuteNonQuery();
                        }
                        break;
                    case "Nuoc":
                        using (SqlCommand cmd = new SqlCommand("dbo.UpdateNuoc", myCon))
                        {
                            cmd.Connection = myCon;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.Parameters.Add("@Ngay", SqlDbType.DateTime).Value = DateTime.Parse(txt1.Text);
                            cmd.Parameters.Add("@SoChuNuoc", SqlDbType.Float).Value = float.Parse(txt2.Text);
                            cmd.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = decimal.Parse(txt3.Text);

                            int rows = cmd.ExecuteNonQuery();
                        }
                        break;
                    case "Dien":
                        using (SqlCommand cmd = new SqlCommand("dbo.UpdateDien", myCon))
                        {
                            cmd.Connection = myCon;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.Parameters.Add("@Ngay", SqlDbType.DateTime).Value = DateTime.Parse(txt1.Text);
                            cmd.Parameters.Add("@SoChuDien", SqlDbType.Float).Value = float.Parse(txt2.Text);
                            cmd.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = decimal.Parse(txt3.Text);

                            int rows = cmd.ExecuteNonQuery();
                        }
                        break;
                    case "PhongTro":
                        using (SqlCommand cmd = new SqlCommand("dbo.UpdatePTro", myCon))
                        {
                            cmd.Connection = myCon;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.Parameters.Add("@SoPhong", SqlDbType.Int).Value = int.Parse(txt1.Text);
                            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = txt2.Text;
                            cmd.Parameters.Add("@LoaiPhong", SqlDbType.NVarChar).Value = txt3.Text;
                            cmd.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = decimal.Parse(txt4.Text);

                            int rows = cmd.ExecuteNonQuery();
                        }
                        break;
                    case "GopY":
                        using (SqlCommand cmd = new SqlCommand("dbo.UpdateGY", myCon))
                        {
                            cmd.Connection = myCon;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.Parameters.Add("@Ngay", SqlDbType.DateTime).Value = DateTime.Parse(txt1.Text);
                            cmd.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = txt2.Text;
                            cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar).Value = txt3.Text;
                            cmd.Parameters.Add("@NT_ID", SqlDbType.NVarChar).Value = dl1.SelectedValue;

                            int rows = cmd.ExecuteNonQuery();
                        }
                        break;
                    case "KhaiBao":
                        using (SqlCommand cmd = new SqlCommand("dbo.UpdateKB", myCon))
                        {
                            cmd.Connection = myCon;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.Parameters.Add("@Loai", SqlDbType.NVarChar).Value = txt1.Text;
                            cmd.Parameters.Add("@Ngay", SqlDbType.DateTime).Value = DateTime.Parse(txt2.Text);
                            cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = txt3.Text;

                            int rows = cmd.ExecuteNonQuery();
                        }
                        break;
                    case "ThietBi":
                        using (SqlCommand cmd = new SqlCommand("dbo.UpdateTB", myCon))
                        {
                            cmd.Connection = myCon;
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                            cmd.Parameters.Add("@TenTB", SqlDbType.NVarChar).Value = txt1.Text;
                            cmd.Parameters.Add("@Gia", SqlDbType.Decimal).Value = decimal.Parse(txt2.Text);
                            cmd.Parameters.Add("@NgayMua", SqlDbType.DateTime).Value = DateTime.Parse(txt3.Text);
                            cmd.Parameters.Add("@ThoiGianBH", SqlDbType.NVarChar).Value = txt4.Text;
                            cmd.Parameters.Add("@PT_ID", SqlDbType.NVarChar).Value = dl1.SelectedValue;

                            int rows = cmd.ExecuteNonQuery();
                        }
                        break;
                }
            }
            catch (Exception ex) { Response.Write("<script>alert('Button Selected Error: " + ex.Message + "')</script>"); }
            finally { myCon.Close(); }
        }

        public void gridView_visible(String name)
        {
           
                switch (name)
                {
                    case "Hợp Đồng":
                        listItem.Columns[1].Visible = true;
                        listItem.Columns[2].Visible = true;
                        listItem.Columns[3].Visible = true;
                        listItem.Columns[4].Visible = true;
                        listItem.Columns[5].Visible = true;
                        listItem.Columns[6].Visible = true;
                        listItem.Columns[7].Visible = true;
                        listItem.Columns[8].Visible = true;
                        listItem.Columns[1].HeaderText = "Ngày Hợp Đồng";
                        listItem.Columns[2].HeaderText = "Của";
                        listItem.Columns[3].HeaderText = "Ngày Thu Tiền Điện";
                        listItem.Columns[4].HeaderText = "Ngày Thu Tiền Nước";
                        listItem.Columns[5].HeaderText = "Loại Khai Báo";
                        listItem.Columns[6].HeaderText = "Phòng Số";
                        listItem.Columns[7].HeaderText = "Phiếu Thu";
                        listItem.Columns[8].HeaderText = "Phiếu Chi";

                        break;
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
                        listItem.Columns[1].HeaderText = "Loại Khai Báo";
                        listItem.Columns[2].HeaderText = "Ngày";
                        listItem.Columns[3].HeaderText = "Tình Trạng";

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
                        listItem.Columns[1].HeaderText = "Ngày";
                        listItem.Columns[2].HeaderText = "Trạng Thái";
                        listItem.Columns[3].HeaderText = "Nội Dung";
                        listItem.Columns[4].HeaderText = "Của";

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