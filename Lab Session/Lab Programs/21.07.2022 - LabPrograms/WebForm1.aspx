<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ARunWebsiteCreate.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 735px; top: 197px; position: absolute"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Maroon" style="z-index: 1; left: 452px; top: 194px; position: absolute; width: 206px; height: 26px" Text="Enter a  Number"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="Red" Font-Bold="True" Font-Size="Large" ForeColor="White" OnClick="Button1_Click" style="z-index: 1; left: 608px; top: 278px; position: absolute; height: 38px; width: 133px; margin-top: 2px" Text="Check" />
            <br />
            <br />
            <asp:Label ID="Result1" runat="server" Font-Size="X-Large" style="z-index: 1; left: 618px; top: 390px; position: absolute; right: 743px"></asp:Label>
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
        </div>
    </form>
</body>
</html>
