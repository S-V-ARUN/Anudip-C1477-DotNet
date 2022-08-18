<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Banking.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 459px">
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/login-icon-png-22.jpg.png" style="z-index: 1; left: 486px; top: 8px; position: absolute; height: 152px; width: 269px; right: 273px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 408px; top: 170px; position: absolute; height: 133px; width: 482px">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx" style="z-index: 1; left: 614px; top: 359px; position: absolute">MainMenu</asp:HyperLink>
    </form>
</body>
</html>
