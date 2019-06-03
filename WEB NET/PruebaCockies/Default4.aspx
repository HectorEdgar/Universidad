<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Usuario:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Contraseña:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
    </div>
        <div style="margin-left: 40px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirmar" />
        </div>
    </form>
</body>
</html>
