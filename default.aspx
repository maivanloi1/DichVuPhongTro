<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="BD10_DichVuPhongTro._default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Dịch Vụ Phòng Trọ</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js">    </script>
    <!--
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    -->
    <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css" />
    <link rel="icon" href="https://logo.com/image-cdn/images/kts928pd/production/1a97a4884a330b23b1592a08163464803626587d-413x384.png?w=1080&q=72">
    <link rel="stylesheet" href="/font/fontawesome-free-6.4.2/css/all.min.css">
    <link rel="stylesheet" href="/css/style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="grid">
            <div class="container__header">
                <div class="container__title">
                    <h2 class="container__title-header">Dịch Vụ Phòng Trọ</h2>
                </div>
                <div class="container__account">
                    <asp:LinkButton ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" />
                    <asp:LinkButton ID="LogoutBtn" runat="server" Text="Logout" OnClick="LogoutBtn_Click" />
                    <asp:Label ID="CurrentUser" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
        <div class="container__body">
            <div class="grid">
                <div class="grid__row-2">
                    <div class="">
                        <span class="container__item-title">Danh Mục</span>
                    </div>
                    <div class="container__body-item">
                        <asp:LinkButton class="container__item-name" ID="HopDong" runat="server" Text="Hợp Đồng" OnClick="HopDong_Click" />
                    </div>
                    <div class="container__body-item">
                        <asp:LinkButton class="container__item-name" ID="NguoiThue" runat="server" Text="Người Thuê" OnClick="NguoiThue_Click" />
                    </div>
                    <div class="container__body-item">
                        <asp:LinkButton class="container__item-name" ID="PhongTro" runat="server" Text="Phòng Trọ" OnClick="PhongTro_Click" />
                    </div>
                    <div class="container__body-item">
                        <asp:LinkButton class="container__item-name" ID="PhieuThu" runat="server" Text="Phiếu Thu" OnClick="PhieuThu_Click" />
                    </div>
                    <div class="container__body-item">
                        <asp:LinkButton class="container__item-name" ID="PhieuChi" runat="server" Text="Phiếu Chi" OnClick="PhieuChi_Click" />
                    </div>
                    <div class="container__body-item">
                        <asp:LinkButton class="container__item-name" ID="Nuoc" runat="server" Text="Nước" OnClick="Nuoc_Click" />
                    </div>
                    <div class="container__body-item">
                        <asp:LinkButton class="container__item-name" ID="Dien" runat="server" Text="Điện" OnClick="Dien_Click" />
                    </div>
                    <div class="container__body-item">
                        <asp:LinkButton class="container__item-name" ID="ThietBi" runat="server" Text="Thiết Bị" OnClick="ThietBi_Click" />
                    </div>
                    <div class="container__body-item">
                        <asp:LinkButton class="container__item-name" ID="KhaiBao" runat="server" Text="Khai Báo" OnClick="KhaiBao_Click" />
                    </div>
                    <div class="container__body-item">
                        <asp:LinkButton class="container__item-name" ID="GopY" runat="server" Text="Góp Ý" OnClick="GopY_Click" />
                    </div>
                </div>
                <div class="grid__row-7 ">
                    <div class="container__item-list">
                        <asp:GridView ID="listItem" runat="server" AutoGenerateColumns="False" AllowSorting="True" Width="100%">
                            <Columns>
                                <asp:TemplateField HeaderText="STT">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" Width="25px" />
                                    <ItemStyle HorizontalAlign="Center" Font-Bold="true" />
                                </asp:TemplateField>

                                <asp:BoundField DataField="Column1" HeaderText="">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Column2" HeaderText="">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Column3" HeaderText="">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Column4" HeaderText="">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Column5" HeaderText="">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Column6" HeaderText="">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Column7" HeaderText="">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Column8" HeaderText="">
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>

                <div class="grid__row-2">

                    <div class="nav-header">
                        <h4 class="nav-header__title">Chức Năng</h4>
                    </div>
                    <div class="nav-body">
                        <ul class="nav-body__list">
                            <li class="nav-body__list-item">
                                <asp:LinkButton ID="BtnTK" runat="server" Text="Thống Kê Doanh Thu" OnClick="ThongKe_Click" /></li>
                            <li class="nav-body__list-item">
                                <asp:LinkButton ID="BtnUpt" runat="server" Text="Cập Nhật" OnClick="Update_Click" /></li>
                            <li class="nav-body__list-item">
                                <asp:LinkButton ID="BtnDel" runat="server" Text="Xoá" OnClick="Delete_Click" /></li>
                        </ul>
                    </div>

                </div>
            </div>
        </div>

        <!-- Modal to Add New or View / Update a Sanpham Details-->
        <div class="modal fade" id="modalDetail" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-lg" style="width: 600px;">
                <div class="modal-content" style="font-size: 11px;">

                    <div class="modal-header" style="text-align: center;">
                        <asp:Label ID="lblUpd" runat="server" Text="" Font-Size="24px" Font-Bold="true" />
                    </div>

                    <div class="modal-body">
                        <div class="row">
                            <div class="col-sm-12">

                                <%-- Sanpham Details Textboxes --%>
                                <div class="col-sm-12">
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-12">
                                            <asp:DropDownList ID="listTable" runat="server" CssClass="form-control input-xs">
                                                <asp:ListItem Text="Hợp Đồng" Value="HopDong" />
                                                <asp:ListItem Text="Người Thuê" Value="NguoiThue" />
                                                <asp:ListItem Text="Phòng Trọ" Value="PhongTro" />
                                                <asp:ListItem Text="Phiếu Thu" Value="PhieuThu" />
                                                <asp:ListItem Text="Phiếu Chi" Value="PhieuChi" />
                                                <asp:ListItem Text="Nước" Value="Nuoc" />
                                                <asp:ListItem Text="Điện" Value="Dien" />
                                                <asp:ListItem Text="Thiết bị" Value="ThietBi" />
                                                <asp:ListItem Text="Khai Báo" Value="KhaiBao" />
                                                <asp:ListItem Text="Góp Ý" Value="GopY" />
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="row" style="margin-top: 20px; border-bottom: 1px solid #000; padding-bottom: 6px">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-8">
                                            <asp:TextBox ID="TbID" runat="server" MaxLength="255" CssClass="form-control input-xs"
                                                ToolTip="ID"
                                                AutoCompleteType="Disabled" placeholder="Nhập ID cần sửa" />
                                        </div>
                                        <div class="col-sm-2">
                                            <asp:Button ID="SelectID" runat="server" class="btn btn-success" data-dismiss="modal"
                                                Text="Submit"
                                                Visible="true" CausesValidation="false"
                                                OnClick="btnSlcID_Click"
                                                UseSubmitBehavior="false" />
                                        </div>
                                        <div class="col-sm-1"></div>
                                    </div>
                                </div>
                                <div class="col-sm-12">
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-10">
                                            <asp:TextBox ID="txt1" runat="server" MaxLength="255" Visible="false" CssClass="form-control input-xs"
                                                AutoCompleteType="Disabled"/>
                                            <asp:Label runat="server" ID="lblID" Visible="false" Font-Size="12px" />
                                        </div>
                                        <div class="col-sm-1">
                                        </div>
                                    </div>
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-10">
                                            <asp:TextBox ID="txt2" runat="server" MaxLength="255" CssClass="form-control input-xs"
                                                AutoCompleteType="Disabled" Visible="false"/>
                                        </div>
                                        <div class="col-sm-1">
                                        </div>
                                    </div>
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-10">
                                            <asp:TextBox ID="txt3" runat="server" MaxLength="255" CssClass="form-control input-xs"
                                                AutoCompleteType="Disabled" Visible="false"/>
                                        </div>
                                        <div class="col-sm-1">
                                        </div>
                                    </div>
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-10">
                                            <asp:TextBox ID="txt4" runat="server" MaxLength="255" CssClass="form-control input-xs"
                                                AutoCompleteType="Disabled" Visible="false"/>
                                        </div>
                                        <div class="col-sm-1">
                                        </div>
                                    </div>
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-10">
                                            <asp:DropDownList ID="dl1" runat="server" CssClass="form-control input-xs" Visible="false"/>
                                        </div>
                                        <div class="col-sm-1">
                                        </div>
                                    </div>
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-10">
                                            <asp:DropDownList ID="dl2" runat="server" CssClass="form-control input-xs" Visible="false"/>
                                        </div>
                                        <div class="col-sm-1">
                                        </div>
                                    </div>
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-10">
                                            <asp:DropDownList ID="dl3" runat="server" CssClass="form-control input-xs" Visible="false"/>
                                        </div>
                                        <div class="col-sm-1">
                                        </div>
                                    </div>
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-10">
                                            <asp:DropDownList ID="dl4" runat="server" CssClass="form-control input-xs" Visible="false"/>
                                        </div>
                                        <div class="col-sm-1">
                                        </div>
                                    </div>
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-10">
                                            <asp:DropDownList ID="dl5" runat="server" CssClass="form-control input-xs" Visible="false"/>
                                        </div>
                                        <div class="col-sm-1">
                                        </div>
                                    </div>
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-10">
                                            <asp:DropDownList ID="dl6" runat="server" CssClass="form-control input-xs" Visible="false"/>
                                        </div>
                                        <div class="col-sm-1">
                                        </div>
                                    </div>
                                    <div class="row" style="margin-top: 20px;">
                                        <div class="col-sm-1"></div>
                                        <div class="col-sm-10">
                                            <asp:DropDownList ID="dl7" runat="server" CssClass="form-control input-xs" Visible="false"/>
                                        </div>
                                        <div class="col-sm-1">
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>

                        <%-- Message label on modal page --%>
                        <div class="row" style="margin-top: 20px; margin-bottom: 10px;">
                            <div class="col-sm-1"></div>
                            <div class="col-sm-10">
                                <asp:Label ID="lblModalMessage" runat="server" ForeColor="Red" Font-Size="12px" Text="" />
                            </div>
                            <div class="col-sm-1"></div>
                        </div>
                    </div>

                    <%-- Add, Update and Cancel Buttons --%>
                    <div class="modal-footer">
                        <asp:Button ID="btnUpd" runat="server" class="btn btn-danger button-xs" data-dismiss="modal"
                            Text="Update"
                            Visible="false" CausesValidation="false"
                            OnClick="btnUpd_Click"
                            UseSubmitBehavior="false" />
                        <asp:Button ID="btnClose" runat="server" class="btn btn-info button-xs" data-dismiss="modal"
                            Text="Close" CausesValidation="false"
                            UseSubmitBehavior="false" />
                    </div>

                </div>
            </div>
        </div>
    </form>
    <script type="text/javascript">
        function openSPDetail(event) {
            //alert("Opening modal!");
            //jQuery.noConflict();
            $('#modalDetail').modal('show');
        }


    </script>
</body>
</html>
