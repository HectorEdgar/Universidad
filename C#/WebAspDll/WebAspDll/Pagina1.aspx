<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina1.aspx.cs" Inherits="WebAspDll.Pagina1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="EntityDataSource1">
                <Columns>
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                    <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" ReadOnly="True" SortExpression="CompanyName" />
                    <asp:BoundField DataField="ContactTitle" HeaderText="ContactTitle" ReadOnly="True" SortExpression="ContactTitle" />
                    <asp:BoundField DataField="Address" HeaderText="Address" ReadOnly="True" SortExpression="Address" />
                    <asp:BoundField DataField="City" HeaderText="City" ReadOnly="True" SortExpression="City" />
                </Columns>
            </asp:GridView>
            <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=NorthwindEntities" DefaultContainerName="NorthwindEntities" EnableFlattening="False" EntitySetName="Customers" EntityTypeFilter="Customer" Select="it.[CustomerID], it.[CompanyName], it.[ContactTitle], it.[Address], it.[City]"
                AutoGenerateOrderByClause="true">
                <OrderByParameters>
                    <asp:Parameter DefaultValue="CustomerId"/>
                </OrderByParameters>
            </asp:EntityDataSource>

        </div>
    </form>
</body>
</html>
