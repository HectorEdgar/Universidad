﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Carga.aspx">Cargar comentarios en el libro de visitas</asp:HyperLink>
    
    </div>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Listado.aspx">Listado del libro</asp:HyperLink>
    </form>
</body>
</html>