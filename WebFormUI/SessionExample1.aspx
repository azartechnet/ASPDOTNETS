<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionExample1.aspx.cs" Inherits="WebFormUI.SessionExample1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label Text="Email" runat="server"></asp:Label>
            <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
            <asp:Label Text="Password" runat="server"></asp:Label>
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="Login" runat="server" Text="Login" OnClick="login_click" />
            <br />
            <asp:Label ID="Label6" runat="server"></asp:Label>
            <asp:Label ID="Label7" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
