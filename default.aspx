<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="BD10_DichVuPhongTro._default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Dịch Vụ Phòng Trọ</title>
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
                                    <ItemTemplate >
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
                                <asp:LinkButton ID="BtnView" runat="server" Text="Xem Chi Tiết" OnClick="ViewDetail_Click" /></li>
                            <li class="nav-body__list-item">
                                <asp:LinkButton ID="BtnUpt" runat="server" Text="Cập Nhật" OnClick="Update_Click" /></li>
                            <li class="nav-body__list-item">
                                <asp:LinkButton ID="BtnDel" runat="server" Text="Xoá" OnClick="Delete_Click" /></li>
                        </ul>
                    </div>

                </div>
            </div>
        </div>
        <span><a href="Login.aspx">Login</a> </span>
    </form>

</body>
</html>
