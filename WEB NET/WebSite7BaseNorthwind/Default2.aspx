<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvCustomers" CssClass="Grid" runat="server" AutoGenerateColumns="false"
                PageSize="10" AllowPaging="true" DataSourceID="dsCustomers">
                <Columns>
                    <asp:BoundField DataField="CustomerId" HeaderText="Customer Id" />
                    <asp:BoundField DataField="ContactName" HeaderText="Contact Name" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                    <asp:BoundField DataField="Country" HeaderText="Country" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="dsCustomers" runat="server" EnablePaging="true" SelectMethod="getCustomers"
                SelectCountMethod="getCustomersCount" TypeName="CustomerDS" MaximumRowsParameterName="maxRows"
                StartRowIndexParameterName="startIndex"></asp:ObjectDataSource>
        </div>




    </form>
</body>
</html>
