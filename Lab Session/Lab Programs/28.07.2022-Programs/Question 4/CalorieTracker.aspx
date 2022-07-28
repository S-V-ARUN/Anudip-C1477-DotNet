<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalorieTracker.aspx.cs" Inherits="Lab_Session.CalorieTracker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 0;
            height: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 704px">
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 211px; top: 29px; position: absolute; height: 151px; width: 974px">
                <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 234px; top: 35px; position: absolute; width: 519px; height: 102px; text-align:center;" Text="Chicken Nutritions Tracker" Font-Bold="True" Font-Names="Century" Font-Size="XX-Large"></asp:Label>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/png-clipart-chicken-leg-cartoon-drawing-fat-animals-chicken-meat.png" style="z-index: 1; left: 137px; top: 5px; position: absolute; height: 144px; width: 137px" />
                <asp:Image ID="Image2" runat="server" ImageUrl="~/images.png" style="z-index: 1; left: 697px; top: 4px; position: absolute; height: 144px; width: 160px" />
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
            <img class="auto-style1" src="Chicken.JPEG" /><br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" style="z-index: 1; left: 209px; top: 203px; position: absolute; height: 433px; width: 1002px">
                <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 186px; top: 64px; position: absolute; height: 38px; width: 261px;" Text="Enter Weight Here" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" Font-Bold="True" Font-Size="X-Large" Height="41px" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 469px; top: 58px; position: absolute; width: 91px; height: 43px"></asp:TextBox>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" style="z-index: 1; left: 572px; top: 61px; text-align:center;position: absolute; height: 43px; width: 91px">
                    <asp:ListItem>Gram</asp:ListItem>
                    <asp:ListItem>KG</asp:ListItem>
                </asp:DropDownList>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Calculate.jpg" OnClick="ImageButton1_Click" style="z-index: 1; left: 379px; top: 146px; position: absolute; height: 109px; width: 225px" />
                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 259px; top: 313px; position: absolute; height: 21px" Text="Protein"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="Label9" runat="server" Height="88px" style="z-index: 1; left: 733px; top: 356px; position: absolute; text-align:center; height: 45px; width: 100px" Width="88px" Font-Bold="True" Font-Size="Large"></asp:Label>
                <br />
                <asp:Label ID="Label8" runat="server" Height="88px" style="z-index: 1; left: 469px; top: 363px;text-align:center; position: absolute; width: 136px; height: 46px" Width="88px" Font-Bold="True" Font-Size="Large"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 490px; top: 315px; position: absolute" Text="Calories"></asp:Label>
                <br />
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 762px; top: 316px; position: absolute" Text="Fat"></asp:Label>
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Height="88px" style="z-index: 1; left: 466px; top: 565px; text-align:center; position: absolute; height: 36px; width: 87px" Width="88px" Font-Bold="True" Font-Size="Large"></asp:Label>
        </div>
    </form>
</body>
</html>
