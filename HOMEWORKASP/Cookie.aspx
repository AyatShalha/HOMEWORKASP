<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookie.aspx.cs" Inherits="HOMEWORKASP.Cookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name :"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 41px" Width="213px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Age :"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 57px" Width="213px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show" />
        </p>
    </form>
</body>
</html>
