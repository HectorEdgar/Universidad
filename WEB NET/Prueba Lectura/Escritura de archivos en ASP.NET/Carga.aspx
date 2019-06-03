<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Carga.aspx.cs" Inherits="Carga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Nombre:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Pais:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Comentarios:<br />
        <asp:TextBox ID="TextBox3" runat="server" Height="101px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirmar" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Retornar</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
