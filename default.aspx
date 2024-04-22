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
                <asp:LinkButton class="container__item-name" ID="Nuoc" runat="server" Text="Nước" OnClick="Nuoc_Click"/>
            </div>
            <div class="container__body-item">
                <asp:LinkButton class="container__item-name" ID="Dien" runat="server" Text="Điện" OnClick="Dien_Click"/>
            </div>

        </div>
        <div class="grid__row-6 ">
            <div class="container__item-list"> 
             <asp:GridView ID="listItem_Nuoc" runat="server" AutoGenerateColumns="False" AllowSorting="True" width="100%"
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
