<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownList.aspx.cs" Inherits="WebFormUI.DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 321px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Select a City of your Choice</p>
            <div>
                <asp:DropDownList ID="DropDownList1" runat="server">

                    <asp:ListItem Value="">Please Select</asp:ListItem>
                    <asp:ListItem>NewDelhi</asp:ListItem>
                    <asp:ListItem>Chennai</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />

        <br />
        <asp:Label ID="Label1" runat="server" EnableViewState="True" />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged1" Text="UG" />
    </form>
</body>
</html>
