<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Banking.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 348px">
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 316px; top: 132px; position: absolute; height: 153px; width: 809px">
                <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 238px; top: 48px; position: absolute; height: 19px;" Text="New User "></asp:Label>
                <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 238px; top: 83px; position: absolute; " Text="Existing User "></asp:Label>
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="~/Register.aspx" style="z-index: 1; left: 376px; top: 50px; position: absolute">Register Here</asp:HyperLink>
                <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="Blue" NavigateUrl="~/Login.aspx" style="z-index: 1; left: 376px; top: 85px; position: absolute; height: 19px;">Login Here</asp:HyperLink>
            </asp:Panel>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/ABC.png" style="z-index: 1; left: 435px; top: 33px; position: absolute; width: 474px; height: 127px; right: 401px" />
&nbsp;</div>
    </form>
</body>
</html>
