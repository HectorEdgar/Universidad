<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Ingrese edad (18 y 35)&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RangeValidator" MaximumValue="35" MinimumValue="18" Type="Integer">El postulante debe tener una edad entre 18 y 35 años</asp:RangeValidator>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirmar" />
    </form>
</body>
</html>
