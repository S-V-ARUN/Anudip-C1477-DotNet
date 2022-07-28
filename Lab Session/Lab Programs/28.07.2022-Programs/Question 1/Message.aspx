<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="Lab_Session.Message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 1050px">
    <form id="form1" runat="server">
        <div style="height: 569px">
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 195px; width: 610px" BorderStyle="Solid">
                <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 1px; top: 3px; position: absolute; width: 605px; text-align :center" Text="Input Tab" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" BorderColor="#99CCFF" BorderStyle="Solid" style="z-index: 1; left: 234px; top: 59px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 38px; top: 105px; position: absolute; width: 128px" Text="Enter Msg Here"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" BorderColor="#99CCFF" BorderStyle="Solid" style="z-index: 1; left: 234px; top: 104px; position: absolute; height: 71px; width: 232px" TextMode="MultiLine"></asp:TextBox>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" style="z-index: 1; left: 817px; top: 15px; position: absolute; height: 190px; width: 642px" BorderStyle="Solid">
                <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 0px; top: 0px; position: absolute; width: 605px; text-align :center" Text="Output Tab" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 53px; top: 36px; position: absolute; width: 523px; height: 82px" BorderStyle="None" BorderWidth="1px"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 153px; top: 160px; position: absolute; width: 423px;text-align :right"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="Panel3" runat="server" style="z-index: 1; left: 225px; top: 249px; position: absolute; height: 286px; width: 985px" BorderColor="#FF3300" BorderStyle="Solid">
                <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 0px; top: 10px; position: absolute; width: 979px; text-align :center; height: 29px;" Text="Operations Tab" Font-Bold="True" Font-Italic="True" Font-Size="Large"></asp:Label>
                <br />
                <br />
                <asp:Panel ID="Panel4" runat="server" style="z-index: 1; left: 17px; top: 66px; position: absolute; height: 200px; width: 444px; right: 524px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 0px; top: 0px; position: absolute; width: 443px; text-align:center;" Text="Message" BorderStyle="Solid" BorderWidth="1px"></asp:Label>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" style="z-index: 1; left: 104px; top: 87px; position: absolute; height: 96px; width: 96px">
                        <asp:ListItem>Red</asp:ListItem>
                        <asp:ListItem>Yellow</asp:ListItem>
                        <asp:ListItem>Blue</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged" style="z-index: 1; left: 219px; top: 88px; position: absolute; height: 94px; width: 97px">
                        <asp:ListItem>Green</asp:ListItem>
                        <asp:ListItem>Black</asp:ListItem>
                        <asp:ListItem>Cyan</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <br />
                    <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 25px; top: 44px; position: absolute" Text="Bold" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox3" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox3_CheckedChanged" style="z-index: 1; left: 243px; top: 44px; position: absolute" Text="Underline" />
                    <asp:CheckBox ID="CheckBox4" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox4_CheckedChanged" style="z-index: 1; left: 136px; top: 44px; position: absolute" Text="Italic" />
                </asp:Panel>
                <asp:Panel ID="Panel5" runat="server" style="z-index: 1; left: 530px; top: 64px; position: absolute; height: 200px; width: 444px" BorderStyle="Solid" BorderWidth="1px">
                    <asp:Label ID="Label9" runat="server" BorderStyle="Solid" BorderWidth="1px" style="z-index: 1; left: 0px; top: 0px; position: absolute; width: 442px; text-align:center;" Text="From "></asp:Label>
                    <asp:RadioButtonList ID="RadioButtonList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList3_SelectedIndexChanged1" style="z-index: 1; left: 98px; top: 87px; position: absolute; height: 96px; width: 96px">
                        <asp:ListItem>Red</asp:ListItem>
                        <asp:ListItem>Yellow</asp:ListItem>
                        <asp:ListItem>Blue</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RadioButtonList ID="RadioButtonList4" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList4_SelectedIndexChanged1" style="z-index: 1; left: 227px; top: 88px; position: absolute; height: 94px; width: 97px">
                        <asp:ListItem>Green</asp:ListItem>
                        <asp:ListItem>Black</asp:ListItem>
                        <asp:ListItem>Cyan</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <br />
                    <asp:CheckBox ID="CheckBox5" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox5_CheckedChanged" style="z-index: 1; left: 25px; top: 44px; position: absolute" Text="Bold" />
                    <asp:CheckBox ID="CheckBox6" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox6_CheckedChanged" style="z-index: 1; left: 243px; top: 44px; position: absolute" Text="Underline" />
                    <asp:CheckBox ID="CheckBox7" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox7_CheckedChanged" style="z-index: 1; left: 136px; top: 44px; position: absolute" Text="Italic" />
                </asp:Panel>
            </asp:Panel>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 63px; top: 78px; position: absolute" Text="Enter Name"></asp:Label>
            <asp:Button ID="Button1" runat="server" BackColor="#006600" BorderColor="#006600" BorderStyle="Dotted" BorderWidth="2px" ForeColor="White" style="z-index: 1; left: 691px; top: 119px; position: absolute" Text="Display" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
