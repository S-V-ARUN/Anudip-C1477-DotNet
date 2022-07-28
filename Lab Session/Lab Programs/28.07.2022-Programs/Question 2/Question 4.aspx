<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Question 4.aspx.cs" Inherits="Lab_Session.Question_4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 1277px">
            <br />
            <asp:Panel ID="Panel1" runat="server" Font-Bold="True" Font-Size="XX-Large"  style="z-index: 1; left: 10px; text-align:center; top: 47px; position: absolute; height: 113px; width: 1449px">
                LAB SESSION<br />
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 609px; top: 65px; position: absolute; height: 25px"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/calendar-clipart-logo-design-template-9a3d7bbcf620587d4b74313072040475_screen.jpg" OnClick="ImageButton1_Click" style="z-index: 1; left: 797px; top: 65px; position: absolute; height: 30px; width: 33px" />
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            Program 3
            <br />
            <br />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" style="z-index: 1; left: 599px; top: 171px; position: absolute; height: 124px; width: 190px"></asp:Calendar>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="~/Message.aspx" style="z-index: 1; left: 344px; top: 454px; position: absolute">-------First Assignment-------</asp:HyperLink>
            <asp:LinkButton ID="LinkButton1" runat="server" BorderStyle="Solid" BorderWidth="1px" OnClick="LinkButton1_Click" PostBackUrl="~/CalorieTracker.aspx" style="z-index: 1; left: 998px; top: 457px; position: absolute">-------Third Assignment-------</asp:LinkButton>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:Panel ID="Panel2" runat="server" style="z-index: 1; left: 10px; top: 1292px; position: absolute; height: 22px; width: 1355px">
        </asp:Panel>
    </form>
</body>
</html>
