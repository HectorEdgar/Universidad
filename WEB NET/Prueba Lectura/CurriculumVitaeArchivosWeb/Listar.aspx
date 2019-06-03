<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Listar.aspx.cs" Inherits="Listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:Label ID="Label2" runat="server" CssClass="Total" Text="Total de Registros: "></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="Total" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" CssClass="RegistrosFecha" Text="Registros de la Fecha: "></asp:Label>
        <asp:Label ID="Label5" runat="server" CssClass="RegistrosFecha" Text="Label"></asp:Label>
        <asp:Label ID="Label6" runat="server" CssClass="RegistrosFecha" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="Label" CssClass="Datos"></asp:Label>
    
    </div>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx">Regresar</asp:LinkButton>
    </form>
</body>
</html>
