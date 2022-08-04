<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestMe.aspx.cs" Inherits="DBMStest.TestMe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 394px">
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 158px; top: 61px; position: absolute; height: 169px; width: 809px">
                <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 191px; top: 13px; position: absolute; width: 133px;" Text="Student NAme"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="Page_Load" style="z-index: 1; left: 325px; top: 12px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 191px; top: 43px; position: absolute" Text="Student id"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 325px; top: 45px; position: absolute"></asp:TextBox>
                <asp:Button ID="Id1" runat="server" OnClick="Id1_Click" style="z-index: 1; left: 291px; top: 89px; position: absolute" Text="Add" />
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
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Con1 %>" SelectCommand="SELECT * FROM [TestTable]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
