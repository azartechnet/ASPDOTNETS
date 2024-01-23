<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/index.aspx.cs"   
Inherits="WebFormsControlls.WebControls" %>  
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
        <div>
            <asp:Label runat="server">User Name</asp:Label>
            <asp:TextBox runat="server" ToolTip="Enter User Name"></asp:TextBox>
        </div>
        <h1>RadioButton</h1>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="g1" />
        <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="g1" />
        <asp:Button ID="button1" runat="server" Text="Submit" OnClick="Button1_Click"/>
        <asp:Label runat="server" ID="genderId"></asp:Label>
        <br />
        
    </form>
    <asp:Label runat="server">HyperReference</asp:Label>
    <div>
        <asp:HyperLink runat="server" Text="Java" NavigateUrl="~/Home.aspx"></asp:HyperLink>
    </div>       
    
    
    
    

    
</body>
</html>
