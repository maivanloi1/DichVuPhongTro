<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="BD10_DichVuPhongTro._default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>DichVuPhongTro</title>
    <link rel="stylesheet" href="css/style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="grid">
               <div class="container__header">
                   <div class="container__title">
                       <h2>Dịch Vụ Phòng Trọ</h2>
                   </div>
               </div>
        </div>
        <div class="container__body">
    <div class="grid">
        <div class="grid__row-3">
            <div class="">
                <span class="container__item-title">Danh Mục</span>
            </div>
            <div class="container__body-item">
                <asp:LinkButton class="container__item-name" ID="HopDong" runat="server" Text="Hợp Đồng" OnClick="HopDong_Click"/>
            </div>
            <div class="container__body-item">
                <asp:LinkButton class="container__item-name" ID="NguoiThue" runat="server" Text="Người Thuê" OnClick="NguoiThue_Click"/>
            </div>
            <div class="container__body-item">
                <asp:LinkButton class="container__item-name" ID="PhongTro" runat="server" Text="Phòng Trọ" OnClick="PhongTro_Click"/>
            </div>
            <div class="container__body-item">
                <asp:LinkButton class="container__item-name" ID="PhieuThu" runat="server" Text="Phiếu Thu" OnClick="PhieuThu_Click"/>
            </div>
            <div class="container__body-item">
                <asp:LinkButton class="container__item-name" ID="PhieuChi" runat="server" Text="Phiếu Chi" OnClick="PhieuChi_Click"/>
            </div>
            <div class="container__body-item">
                <asp:LinkButton class="container__item-name" ID="Nuoc" runat="server" Text="Nước" OnClick="Nuoc_Click"/>
            </div>
            <div class="container__body-item">
                <asp:LinkButton class="container__item-name" ID="Dien" runat="server" Text="Điện" OnClick="Dien_Click"/>
            </div>
            <div class="container__body-item">
                <asp:LinkButton class="container__item-name" ID="ThietBi" runat="server" Text="Thiết Bị" OnClick="ThietBi_Click"/>
            </div>
            <div class="container__body-item">
                <asp:LinkButton class="container__item-name" ID="KhaiBao" runat="server" Text="Khai Báo" OnClick="KhaiBao_Click"/>
            </div>
            <div class="container__body-item">
                <asp:LinkButton class="container__item-name" ID="GopY" runat="server" Text="Góp Ý" OnClick="GopY_Click"/>
            </div>
        </div>
        <div class="grid__row-6 ">
            <div class="container__item-list"> 
       <asp:GridView ID="listItem_HopDong" runat="server" AutoGenerateColumns="False" AllowSorting="True" width="100%">
       <Columns>
       <asp:TemplateField>
           <ItemTemplate>
               <%# Container.DataItemIndex + 1 %>
           </ItemTemplate>
           <HeaderStyle HorizontalAlign="Left" Width="25px" />
           <ItemStyle HorizontalAlign="Left" Font-Bold="true" />
       </asp:TemplateField>

       <asp:BoundField DataField="Ngay" HeaderText="Ngày Hợp Đồng">
           <HeaderStyle HorizontalAlign="Left" />
           <ItemStyle HorizontalAlign="Left" />
       </asp:BoundField>
       <asp:BoundField DataField="HoTen" HeaderText=" Của Người Thuê">
           <HeaderStyle HorizontalAlign="Left" />
           <ItemStyle HorizontalAlign="Left" />
       </asp:BoundField>
       <asp:BoundField DataField="Ngay" HeaderText="Điện">
           <HeaderStyle HorizontalAlign="Left" />
           <ItemStyle HorizontalAlign="Left" />
       </asp:BoundField>
       <asp:BoundField DataField="Ngay" HeaderText="Nước">
           <HeaderStyle HorizontalAlign="Left" />
           <ItemStyle HorizontalAlign="Left" />
       </asp:BoundField>
       <asp:BoundField DataField="Loai" HeaderText="Khai Báo">
           <HeaderStyle HorizontalAlign="Left" />
           <ItemStyle HorizontalAlign="Left" />
       </asp:BoundField>
       <asp:BoundField DataField="SoPhong" HeaderText="Phòng Trọ">
           <HeaderStyle HorizontalAlign="Left" />
           <ItemStyle HorizontalAlign="Left" />
       </asp:BoundField>
       <asp:BoundField DataField="PhieuThu" HeaderText="Phiếu Thu">
           <HeaderStyle HorizontalAlign="Left" />
           <ItemStyle HorizontalAlign="Left" />
       </asp:BoundField>
       <asp:BoundField DataField="PhieuChi" HeaderText="Phiếu Chi">
           <HeaderStyle HorizontalAlign="Left" />
           <ItemStyle HorizontalAlign="Left" />
       </asp:BoundField>   
   </Columns>
   </asp:GridView>

             <asp:GridView ID="listItem_Nuoc" runat="server" AutoGenerateColumns="False" AllowSorting="True" width="100%">
     <Columns>
         <asp:TemplateField>
             <ItemTemplate>
                 <%# Container.DataItemIndex + 1 %>
             </ItemTemplate>
             <HeaderStyle HorizontalAlign="Left" Width="25px" />
             <ItemStyle HorizontalAlign="Left" Font-Bold="true" />
         </asp:TemplateField>

         <asp:BoundField DataField="Ngay" HeaderText="Ngày">
             <HeaderStyle HorizontalAlign="Left" />
             <ItemStyle HorizontalAlign="Left" />
         </asp:BoundField>
         <asp:BoundField DataField="SoChuNuoc" HeaderText="Số Chữ Nước">
             <HeaderStyle HorizontalAlign="Left" />
             <ItemStyle HorizontalAlign="Left" />
         </asp:BoundField>
         <asp:BoundField DataField="DonGia" HeaderText="Đơn giá">
             <HeaderStyle HorizontalAlign="Left" />
             <ItemStyle HorizontalAlign="Left" />
         </asp:BoundField>
     </Columns>


 </asp:GridView>
        <asp:GridView ID="listItem_Dien" runat="server" AutoGenerateColumns="False" AllowSorting="True" width="100%"
               >
        <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <%# Container.DataItemIndex + 1 %>
            </ItemTemplate>
            <HeaderStyle HorizontalAlign="Left" Width="25px" />
            <ItemStyle HorizontalAlign="Left" Font-Bold="true" />
        </asp:TemplateField>

        <asp:BoundField DataField="Ngay" HeaderText="Ngày">
            <HeaderStyle HorizontalAlign="Left" />
            <ItemStyle HorizontalAlign="Left" />
        </asp:BoundField>
        <asp:BoundField DataField="SoChuDien" HeaderText="Số Chữ Điện">
            <HeaderStyle HorizontalAlign="Left" />
            <ItemStyle HorizontalAlign="Left" />
        </asp:BoundField>
        <asp:BoundField DataField="DonGia" HeaderText="Đơn giá">
            <HeaderStyle HorizontalAlign="Left" />
            <ItemStyle HorizontalAlign="Left" />
        </asp:BoundField>
    </Columns>
    </asp:GridView>
        </div>
            </div>
    </div>
</div>
    </form>
    
</body>
</html>
