<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calculadora2.aspx.cs" Inherits="Calculadora2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
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
        <br />
    
    </div>
    <div>
    
    </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Selected="True">+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="=" />
    </form>
</body>
</html>
