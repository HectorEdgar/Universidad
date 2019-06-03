<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calculadora1.aspx.cs" Inherits="Calculadora1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtNumero1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="txtNumero2" runat="server"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtResultado" runat="server" Enabled="False"></asp:TextBox>
    
    </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="+" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="-" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="/" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="*" />
    </form>
</body>
</html>
