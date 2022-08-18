<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Banking.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 711px">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/clipart1508018 (1).png" style="z-index: 1; left: 486px; top: 42px; position: absolute; height: 159px; width: 377px" />
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 45px; top: 225px; position: absolute; height: 286px; width: 1223px">
                <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 420px; top: 121px; position: absolute" Text="Enter Amount to Deposit"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 672px; top: 41px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 420px; top: 43px; position: absolute" Text="Enter Your Name"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 672px; top: 119px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 420px; top: 82px; position: absolute" Text="Enter Account Type"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 672px; top: 80px; position: absolute"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Submit.jpg" OnClick="ImageButton1_Click" style="z-index: 1; left: 461px; top: 145px; position: absolute; height: 130px; width: 266px" />
                <asp:Panel ID="Panel2" runat="server" style="z-index: 1; left: 165px; top: 6px; position: absolute; height: 250px; width: 1071px">
                    <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 552px; top: 26px; position: absolute" Text="Request Submitted"></asp:Label>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx" style="z-index: 1; left: 575px; top: 69px; position: absolute">Main Menu</asp:HyperLink>
                </asp:Panel>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
