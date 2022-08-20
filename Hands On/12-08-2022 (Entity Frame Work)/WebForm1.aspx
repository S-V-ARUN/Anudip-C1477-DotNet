<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BankingHandson1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 706px">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/90235.jpg" style="z-index: 1; left: 747px; top: 11px; position: absolute; height: 209px; width: 228px" />
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 683px; top: 304px; position: absolute" Text="Click View to View the Account Holder Datas"></asp:Label>
            <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=BankingEntities" DefaultContainerName="BankingEntities" EnableFlattening="False" EntitySetName="Bankings">
            </asp:EntityDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="AccountNo,Name,AccountType,Balance" DataSourceID="EntityDataSource1" style="z-index: 1; left: 457px; top: 348px; position: absolute; height: 212px; width: 792px; margin-top: 0px">
                <Columns>
                    <asp:BoundField DataField="AccountNo" HeaderText="AccountNo" ReadOnly="True" SortExpression="AccountNo" />
                    <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" SortExpression="Name" />
                    <asp:BoundField DataField="AccountType" HeaderText="AccountType" ReadOnly="True" SortExpression="AccountType" />
                    <asp:BoundField DataField="Balance" HeaderText="Balance" ReadOnly="True" SortExpression="Balance" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 826px; top: 349px; position: absolute" Text="View" />
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 767px; top: 302px; position: absolute" Text="Account Holder Details"></asp:Label>
        </div>
    </form>
</body>
</html>
