<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="EntityAccessDB.Show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 450px">
            <asp:GridView ID="GridView1" runat="server" DataSourceID="EntityDataSource1" style="z-index: 1; left: 344px; top: 136px; position: absolute; height: 152px; width: 232px">
            </asp:GridView>
            <asp:EntityDataSource ID="EntityDataSource1" runat="server">
            </asp:EntityDataSource>
        </div>
    </form>
</body>
</html>
