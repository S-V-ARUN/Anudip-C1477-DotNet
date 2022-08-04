<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegPage.aspx.cs" Inherits="DBweb.RegPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 838px">
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
            <asp:Panel ID="Panel2" runat="server" style="z-index: 1; left: 234px; top: 411px; position: absolute; height: 155px; width: 890px">
                <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 339px; top: 18px; position: absolute" Text="Registration SuccessFull" ForeColor="#056FBB" Font-Size="Large"></asp:Label>
                <asp:LinkButton ID="LinkButton1" runat="server" BorderStyle="Ridge" Font-Bold="True" Font-Size="Large" Font-Underline="False" ForeColor="#086DBC" PostBackUrl="~/DisplayPage.aspx" style="z-index: 1; left: 388px; top: 82px; position: absolute" OnClick="LinkButton1_Click">Main Menu</asp:LinkButton>
            </asp:Panel>
            <br />
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 298px; top: 386px; position: absolute; height: 458px; width: 746px">
                <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 203px; top: 77px; position: absolute" Text="Student Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 204px; top: 124px; position: absolute" Text="Father name"></asp:Label>
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 204px; top: 215px; position: absolute" Text="DOB"></asp:Label>
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 204px; top: 169px; position: absolute" Text="Gender"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 438px; top: 80px; position: absolute"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 438px; top: 301px; position: absolute"></asp:TextBox>
                <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 438px; top: 133px; position: absolute"></asp:TextBox>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" style="z-index: 1; left: 433px; top: 177px; position: absolute; height: 28px; width: 253px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Others</asp:ListItem>
                </asp:RadioButtonList>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Pics/Reg Button.png" OnClick="ImageButton1_Click" style="z-index: 1; left: 329px; top: 398px; position: absolute; width: 119px; height: 46px" />
                <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="#146BAD" style="z-index: 1; left: 317px; top: 14px; position: absolute" Text="REGISTER DOWN"></asp:Label>
                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 204px; top: 340px; position: absolute" Text="Confirm Password"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 438px; top: 216px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 204px; top: 298px; position: absolute" Text="Enter Password"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 437px; top: 348px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 204px; top: 257px; position: absolute" Text="Phone Number"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server" style="z-index: 1; left: 438px; top: 258px; position: absolute"></asp:TextBox>
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
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Pics/PS-Reg-Pic.JPEG" style="z-index: 1; left: 267px; top: 19px; position: absolute; height: 336px; width: 824px" />
        </div>
    </form>
</body>
</html>
