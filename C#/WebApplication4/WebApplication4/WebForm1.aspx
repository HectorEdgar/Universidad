<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=securityEntities" DefaultContainerName="securityEntities2" EnableFlattening="False" EntitySetName="userAutentications" Select="it.[userAutenticationID], it.[userID], it.[UserAutenticationTypeID], it.[UserName]">
        </asp:EntityDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="EntityDataSource1">
            <Columns>
                <asp:BoundField DataField="userAutenticationID" HeaderText="userAutenticationID" ReadOnly="True" SortExpression="userAutenticationID" />
                <asp:BoundField DataField="userID" HeaderText="userID" ReadOnly="True" SortExpression="userID" />
                <asp:BoundField DataField="UserAutenticationTypeID" HeaderText="UserAutenticationTypeID" ReadOnly="True" SortExpression="UserAutenticationTypeID" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" ReadOnly="True" SortExpression="UserName" />
            </Columns>
        </asp:GridView>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
