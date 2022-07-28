<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Lab_Session.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 362px">
            
                <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" style="z-index: 1; left: 614px; top: 61px; position: absolute" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                    <asp:ListItem>Arun</asp:ListItem>
                    <asp:ListItem>Arun1</asp:ListItem>
                    <asp:ListItem>Arun2</asp:ListItem>
                    <asp:ListItem>Arun3</asp:ListItem>
                    <asp:ListItem>Arun4</asp:ListItem>
                    <asp:ListItem>Arun5</asp:ListItem>
                    <asp:ListItem>Arun6</asp:ListItem>
                </asp:ListBox>
                <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 427px; top: 188px; position: absolute; height: 88px; width: 450px" TextMode="MultiLine"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" style="z-index: 1; left: 590px; top: 12px; position: absolute; width: 134px;" Text="Program 2"></asp:Label>
            
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
