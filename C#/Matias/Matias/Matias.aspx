<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Matias.aspx.cs" Inherits="Matias.Matias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="Color 1" OnClick="Button1_Click" />
    
    </div>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Color 2" OnClick="Button3_Click" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Cambiar Pagina" OnClick="Button2_Click" />
        </p>
    </form>
</body>
</html>
