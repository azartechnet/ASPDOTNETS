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
        <h1>Calender</h1>
        <div>
            <asp:Calendar ID="Calendar1" runat="server"  OnSelectionChanged="Calendar1_SelectionChanged">
            </asp:Calendar>

        </div>
        <h1>CheckBox</h1>
        <div>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="J2SE" />
            <asp:CheckBox ID="CheckBox2" runat="server" Text="J2EE" />
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Spring" />
        </div>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        </p>
        <h1>Its is a Hyperlink style button</h1>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">ClickHereHyperlink</asp:LinkButton>
        <h1>FileUploaded</h1>
        <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true"/>
        <asp:Button ID="Button3" runat="server" Text="Upload File" OnClick="Button3_Click" />
        <h1>FileDownloaded</h1>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Download" />
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
    </form>
    <asp:Label runat="server">HyperReference</asp:Label>
    <asp:Label runat="server" ID="ShowDate"></asp:Label>
    <p>
        Courses Selected:<asp:Label runat="server" ID="ShowCourses" />
    </p>
    <div>
        <asp:HyperLink runat="server" Text="Java" NavigateUrl="~/Home.aspx"></asp:HyperLink>
    </div>       
   
    <p>
        <asp:Label ID="Label1" runat="server" ></asp:Label>
    </p>
    <p>
        <asp:Label runat="server" ID="FileUploadStatus" />

    </p>
</body>
</html>
