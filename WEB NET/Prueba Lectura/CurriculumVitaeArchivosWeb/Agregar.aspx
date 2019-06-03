<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Agregar.aspx.cs" Inherits="Agregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <header>
        <h1>Curriculum VITAE</h1>
    </header>
    <form id="form1" runat="server">
        <h2>Datos básicos</h2>
        <h2>
            <asp:Label ID="Label3" runat="server" Text="Numero de registros: "></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </h2>
        <div>
            Nombre:<asp:TextBox ID="TextBox1" runat="server" CssClass="caja" Width="220px" Height="15px"></asp:TextBox>
            
            Direccion:<asp:TextBox ID="TextBox2" runat="server" CssClass="caja" Width="220px" Height="15px"></asp:TextBox>
            
            Telefono<asp:TextBox ID="TextBox3" runat="server" CssClass="caja" Height="15px" Width="220px"></asp:TextBox>
            
            E-mail:<asp:TextBox ID="TextBox4" runat="server" CssClass="caja" style="top: 172px; " Height="15px" Width="220px"></asp:TextBox>
           
            Lugar y Fecha de Nacimiento:<asp:TextBox ID="TextBox5" runat="server" CssClass="caja" Width="220px" Height="15px"></asp:TextBox>
            
            Estado Civil:<asp:TextBox ID="TextBox6" runat="server" CssClass="caja" Width="220px" Height="15px"></asp:TextBox>
          
            Nacionalidad:<asp:TextBox ID="TextBox7" runat="server" CssClass="caja" Width="220px" Height="15px"></asp:TextBox>
            
            Edad:<asp:TextBox ID="TextBox8" runat="server" CssClass="caja" Width="220px" Height="15px"></asp:TextBox>
            
            Peso:<asp:TextBox ID="TextBox9" runat="server" CssClass="caja" Width="220px" Height="15px"></asp:TextBox>


        </div>

        <h2>Estudios:</h2>

        <div>
            Primaria:<asp:TextBox ID="TextBox10" runat="server" CssClass="caja" Height="15px" Width="200px"></asp:TextBox>
            
            Secundaria:<asp:TextBox ID="TextBox11" runat="server" CssClass="caja" Height="15px" Width="200px"></asp:TextBox>
            
            Peparatoria:<asp:TextBox ID="TextBox12" runat="server" CssClass="caja" Height="15px" Width="200px"></asp:TextBox>
            
            Licenciatura:<asp:TextBox ID="TextBox13" runat="server" CssClass="caja" style="top: 555px; " Height="15px" Width="200px"></asp:TextBox>
            
            Postgrado:<asp:TextBox ID="TextBox14" runat="server" CssClass="caja" Height="15px" Width="200px"></asp:TextBox>
            
            Maestria:<asp:TextBox ID="TextBox15" runat="server" CssClass="caja" Height="15px" Width="200px"></asp:TextBox>
            
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx">Regresar</asp:LinkButton>
    </form>
</body>
</html>
