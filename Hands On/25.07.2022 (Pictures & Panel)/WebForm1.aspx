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
        <div style="height: 1423px">
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
            <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 25px; top: 168px; position: absolute; height: 841px; width: 781px">
                <asp:Label ID="Name" runat="server" Font-Size="Large" style="z-index: 1; left: 37px; top: 42px; position: absolute; height: 29px; width: 161px" Text="Student's Name"></asp:Label>
                <asp:TextBox ID="NameTextBox" runat="server" style="z-index: 1; left: 324px; top: 46px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Font-Size="Large" style="z-index: 1; left: 35px; top: 86px; position: absolute" Text="Date of Birth"></asp:Label>
                <asp:TextBox ID="DOBTextBox" runat="server" style="z-index: 1; left: 321px; top: 86px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Font-Size="Large" style="z-index: 1; left: 36px; top: 129px; position: absolute" Text="Email ID"></asp:Label>
                <asp:CheckBox ID="CheckBox3" runat="server" style="z-index: 1; left: 534px; top: 407px; position: absolute" Text="Netflix" />
                <asp:TextBox ID="EmailTextBox" runat="server" style="z-index: 1; left: 321px; top: 126px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label4" runat="server" Font-Size="Large" style="z-index: 1; left: 35px; top: 171px; position: absolute" Text="Mobile No"></asp:Label>
                <asp:TextBox ID="MobileTextBox" runat="server" style="z-index: 1; left: 320px; top: 170px; position: absolute"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Font-Size="Large" style="z-index: 1; left: 36px; top: 210px; position: absolute" Text="Gender"></asp:Label>
                <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="Gender" OnCheckedChanged="RadioButton1_CheckedChanged" style="z-index: 1; left: 313px; top: 213px; position: absolute" Text="Male" />
                <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="Gender" style="z-index: 1; left: 392px; top: 214px; position: absolute" Text="Female" />
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
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="E:\.NET\ASP Dotnet\ArunWebsiteTest\ArunWebsiteTest\Image\353-3531325_submit-now-png-transparent-images-submit-button-png.png" OnClick="ImageButton1_Click" style="z-index: 1; left: 273px; top: 470px; position: absolute; width: 161px; height: 60px" />
                <asp:Label ID="Label9" runat="server" Font-Size="Large" style="z-index: 1; left: 37px; top: 404px; position: absolute" Text="Hobbies"></asp:Label>
                <asp:CheckBox ID="eGames" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="z-index: 1; left: 264px; top: 408px; position: absolute" Text="eGames" />
                <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 364px; top: 408px; position: absolute" Text="Sports" />
                <asp:CheckBox ID="CheckBox2" runat="server" style="z-index: 1; left: 450px; top: 408px; position: absolute" Text="Songs" />
                <asp:Panel ID="Panel2" runat="server" BorderColor="Black" style="z-index: 1; left: 814px; top: 0px; position: absolute; height: 841px; width: 606px">
                    <asp:Label ID="Label11" runat="server" Font-Size="Large" style="z-index: 1; left: 35px; top: 86px; position: absolute" Text="Date of Birth"></asp:Label>
                    <asp:Label ID="Name0" runat="server" Font-Size="Large" style="z-index: 1; left: 37px; top: 42px; position: absolute; height: 29px; width: 161px" Text="Student's Name"></asp:Label>
                    <asp:Label ID="Label12" runat="server" Font-Size="Large" style="z-index: 1; left: 36px; top: 129px; position: absolute" Text="Email ID"></asp:Label>
                    <asp:Label ID="Label13" runat="server" Font-Size="Large" style="z-index: 1; left: 35px; top: 171px; position: absolute" Text="Mobile No"></asp:Label>
                    <asp:Label ID="Label14" runat="server" Font-Size="Large" style="z-index: 1; left: 36px; top: 210px; position: absolute" Text="Gender"></asp:Label>
                    <asp:Label ID="Label15" runat="server" Font-Size="Large" style="z-index: 1; left: 36px; top: 251px; position: absolute" Text="Address"></asp:Label>
                    <asp:Label ID="Label16" runat="server" Font-Size="Large" style="z-index: 1; left: 37px; top: 317px; position: absolute" Text="State"></asp:Label>
                    <asp:Label ID="Label17" runat="server" Font-Size="Large" style="z-index: 1; left: 37px; top: 360px; position: absolute; right: 443px" Text="Pin Code"></asp:Label>
                    <asp:Label ID="Label18" runat="server" Font-Size="Large" style="z-index: 1; left: 37px; top: 404px; position: absolute" Text="Hobbies"></asp:Label>
                    <asp:Label ID="NameOut" runat="server" style="z-index: 1; left: 283px; top: 46px; position: absolute"></asp:Label>
                    <asp:Label ID="DobOut" runat="server" style="z-index: 1; left: 283px; top: 86px; position: absolute"></asp:Label>
                    <asp:Label ID="EmailOut" runat="server" style="z-index: 1; left: 283px; top: 128px; position: absolute"></asp:Label>
                    <asp:Label ID="GenderOut" runat="server" style="z-index: 1; left: 283px; top: 213px; position: absolute"></asp:Label>
                    <asp:Label ID="MobileNoOut" runat="server" style="z-index: 1; left: 284px; top: 167px; position: absolute; height: 21px"></asp:Label>
                    <asp:Label ID="StateOut" runat="server" style="z-index: 1; left: 283px; top: 316px; position: absolute"></asp:Label>
                    <asp:Label ID="AddressOut" runat="server" style="z-index: 1; left: 283px; top: 249px; position: absolute; height: 50px; width: 146px"></asp:Label>
                    <asp:Label ID="Pinout" runat="server" style="z-index: 1; left: 283px; top: 357px; position: absolute"></asp:Label>
                    <asp:Label ID="HobbiesOut" runat="server" style="z-index: 1; left: 283px; top: 402px; position: absolute"></asp:Label>
                    <asp:Image ID="Image1" runat="server" ImageUrl="E:\.NET\ASP Dotnet\ArunWebsiteTest\ArunWebsiteTest\Image\the_batman_robert_pattinson_bat_symbol_by_cosmicthunder_ddtmeea-fullview.jpg" style="z-index: 1; left: 165px; top: 467px; position: absolute; height: 122px; width: 280px; margin-top: 0px" />
                    <br />
                </asp:Panel>
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
