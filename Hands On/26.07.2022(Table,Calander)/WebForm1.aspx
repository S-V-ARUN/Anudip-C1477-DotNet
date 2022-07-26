<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ArunWebsiteTest.WebForm1" %>

<!DOCTYPE html>
<script runat="server"> 
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 1423px; width: 1450px;">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" style="z-index: 1; left: 574px; top: 48px; position: absolute; width: 369px; height: 58px" Text="Students Registration"></asp:Label>
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
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 320px; top: 154px; position: absolute; height: 841px; width: 825px">
                <asp:Label ID="Name" runat="server" Font-Size="Large" style="z-index: 1; left: 37px; top: 42px; position: absolute; height: 29px; width: 161px" Text="Student's Name"></asp:Label>
                <asp:TextBox ID="NameTextBox" runat="server" style="z-index: 1; left: 321px; top: 46px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Font-Size="Large" style="z-index: 1; left: 35px; top: 86px; position: absolute" Text="Date of Birth"></asp:Label>
                <asp:TextBox ID="DOBTextBox" runat="server" style="z-index: 1; left: 321px; top: 86px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Font-Size="Large" style="z-index: 1; left: 36px; top: 129px; position: absolute" Text="Email ID"></asp:Label>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" style="z-index: 1; left: 305px; top: 403px; position: absolute; height: 28px; width: 370px">
                    <asp:ListItem>Netflix</asp:ListItem>
                    <asp:ListItem>eGames</asp:ListItem>
                    <asp:ListItem>Sports</asp:ListItem>
                    <asp:ListItem>Songs</asp:ListItem>
                </asp:CheckBoxList>
                <asp:TextBox ID="EmailTextBox" runat="server" style="z-index: 1; left: 321px; top: 126px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Font-Size="Large" style="z-index: 1; left: 35px; top: 171px; position: absolute" Text="Mobile No"></asp:Label>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" style="z-index: 1; left: 320px; top: 202px; position: absolute; height: 42px; width: 207px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
                <asp:TextBox ID="MobileTextBox" runat="server" style="z-index: 1; left: 320px; top: 170px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Font-Size="Large" style="z-index: 1; left: 36px; top: 210px; position: absolute" Text="Gender"></asp:Label>
                <asp:Label ID="Label6" runat="server" Font-Size="Large" style="z-index: 1; left: 36px; top: 251px; position: absolute" Text="Address"></asp:Label>
                <asp:TextBox ID="AddressTextBox" runat="server" style="z-index: 1; left: 315px; top: 249px; position: absolute; width: 195px" TextMode="MultiLine"></asp:TextBox>
                <asp:Label ID="Label7" runat="server" Font-Size="Large" style="z-index: 1; left: 37px; top: 317px; position: absolute" Text="State"></asp:Label>
                <asp:Label ID="Label8" runat="server" Font-Size="Large" style="z-index: 1; left: 37px; top: 360px; position: absolute; right: 658px" Text="Pin Code"></asp:Label>
                <asp:DropDownList ID="State" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="z-index: 1; left: 315px; top: 317px; position: absolute; width: 127px">
                    <asp:ListItem>TamilNadu</asp:ListItem>
                    <asp:ListItem>Karnataka</asp:ListItem>
                    <asp:ListItem>Andhra</asp:ListItem>
                    <asp:ListItem>Delhi</asp:ListItem>
                    <asp:ListItem>Bengal</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="Pincode" runat="server" style="z-index: 1; left: 315px; top: 360px; position: absolute"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/353-3531325_submit-now-png-transparent-images-submit-button-png.png" OnClick="ImageButton1_Click" style="z-index: 1; left: 273px; top: 470px; position: absolute; width: 161px; height: 60px" />
                <asp:Label ID="Label9" runat="server" Font-Size="Large" style="z-index: 1; left: 37px; top: 404px; position: absolute" Text="Hobbies"></asp:Label>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" style="z-index: 1; left: 551px; top: 87px; position: absolute; height: 167px; width: 213px" OnSelectionChanged="Calendar1_SelectionChanged">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/calendar-clipart-logo-design-template-9a3d7bbcf620587d4b74313072040475_screen.jpg" OnClick="ImageButton2_Click" style="z-index: 1; left: 508px; top: 85px; position: absolute; height: 26px; width: 25px" />
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" style="z-index: 1; left: 99px; top: 1028px; position: absolute; height: 525px; width: 1291px">
                <asp:Table ID="Table1" runat="server" style="z-index: 1; left: 79px; top: 133px; position: absolute; height: 42px; width: 1132px" BorderStyle="Solid" GridLines="Both">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Student Name</asp:TableHeaderCell>
                    <asp:TableHeaderCell>DOB</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Email</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Mobile</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Gender</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Address</asp:TableHeaderCell>
                    <asp:TableHeaderCell>State</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Pincode</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Hobbies</asp:TableHeaderCell>
                </asp:TableHeaderRow>
                </asp:Table>
                <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" style="z-index: 1; left: 570px; top: 22px; position: absolute; height: 40px; width: 194px" Text="Student Details"></asp:Label>
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
            <br />
            <br />
        </div>
    </form>
</body>
</html>
