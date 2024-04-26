<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BD10_DichVuPhongTro.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="icon" href="https://logo.com/image-cdn/images/kts928pd/production/1a97a4884a330b23b1592a08163464803626587d-413x384.png?w=1080&q=72" >
    <link rel="stylesheet" href="/font/fontawesome-free-6.4.2/css/all.min.css">
    <link rel="stylesheet" href="/css/style.css" />
</head>
<body>

    <form id="form1" runat="server">
        <div class="login">
            <div class="modal-login">
                <div class="container-login">
                    <div class="body-heading">
                        <span>Login</span>
                    </div>
                    <div class="body-content">
                        <div class="content">
                            <label class="content__label"><i class="fa-solid fa-user"></i>Username</label>
                            <asp:TextBox ID="TextBox1" runat="server"  CssClass="content__input" placeholder="Username"></asp:TextBox>
                        </div>
                        <div class="content">
                            <label class="content__label"><i class="fa-solid fa-lock"></i>Password</label>
                            <asp:TextBox  ID="TextBox2" runat="server" TextMode="Password" CssClass="content__input" placeholder="Password"></asp:TextBox>
                        </div>

                        <div class="forget-password">
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                            <a href="#">Forget Password?</a>

                        </div>

                        <div class="btn-login">
                            <asp:Button ID="Button1" CssClass="btn-login__btn" runat="server" OnClick="Button1_Click" Text="Login" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
