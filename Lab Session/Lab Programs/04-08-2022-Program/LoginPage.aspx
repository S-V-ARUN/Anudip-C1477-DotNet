<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="DBweb.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 686px">
            <br />
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 261px; top: 33px; position: absolute; height: 242px; width: 1059px">
                <br />
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Pics/Dec4.jpg" style="z-index: 1; left: 12px; top: 9px; position: absolute; height: 222px; width: 233px" />
                <asp:Image ID="Image3" runat="server" ImageUrl="~/Pics/Students-leaving-school-clipart-kid.jpg" style="z-index: 1; left: 686px; top: 30px; position: absolute; width: 182px" />
                <br />
                <asp:Label ID="Label1" runat="server" BorderStyle="None" Font-Bold="False" Font-Names="Forte" Font-Size="60pt" ForeColor="#333399" style="z-index: 1; left: 270px; top: 67px; position: absolute; width: 496px;" Text="Login Page"></asp:Label>
                <br />
                <br />
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" style="z-index: 1; left: 160px; top: 315px; position: absolute; height: 280px; width: 1100px">
                <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 327px; top: 120px; position: absolute" Text="Enter Your Password"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 598px; top: 65px; position: absolute; width: 195px"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 327px; top: 68px; position: absolute" Text="Enter Phone number"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 599px; top: 122px; position: absolute; width: 195px" TextMode="Password"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Font-Size="Large" ForeColor="#275189" style="z-index: 1; left: 346px; top: -8px; position: absolute" Text="Login Your Details for View And Edit Your Details"></asp:Label>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Pics/login-button-png-md.png" OnClick="ImageButton1_Click" style="z-index: 1; left: 490px; top: 172px; position: absolute; height: 57px; width: 123px" />
            </asp:Panel>
            <asp:Panel ID="Panel3" runat="server" style="z-index: 1; left: 135px; top: 312px; position: absolute; height: 314px; width: 1190px">
                <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: 152px; top: 72px; position: absolute; height: 152px; width: 870px" CellPadding="3" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#5D7B9D" style="z-index: 1; left: 501px; top: 0px; position: absolute; width: 212px" Text="Students Details"></asp:Label>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
