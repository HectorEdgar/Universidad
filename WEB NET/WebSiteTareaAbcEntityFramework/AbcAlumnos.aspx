<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AbcAlumnos.aspx.cs" Inherits="AbcEscuela" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getAlumnos" TypeName="EscuelaDs">
            <SelectParameters>
                <asp:Parameter DefaultValue="0" Name="startIndex" Type="Int32" />
                <asp:Parameter DefaultValue="10" Name="maxRows" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:Panel ID="Panel3" runat="server" Height="353px" Width="598px">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="401px">
                <Columns>
                    <asp:BoundField DataField="AluId" HeaderText="Alumno Id" SortExpression="AluId" />
                    <asp:BoundField DataField="AluNombre" HeaderText="Nombre" SortExpression="AluNombre" />
                    <asp:BoundField DataField="AluApellido" HeaderText="Apellido" SortExpression="AluApellido" />
                    <asp:BoundField DataField="AluEdad" HeaderText="Edad" SortExpression="AluEdad" />
                    <asp:BoundField DataField="AluDireccion" HeaderText="Direccion" SortExpression="AluDireccion" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
        <asp:Panel ID="Panel1" runat="server" Height="277px" Width="541px">
            Agregar Alumno<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Alumno ID:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAlumnoId" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAlumnoNombre" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAlumnoApellido" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Edad:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAlumnoEdad" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Direccion:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAlumnoDireccion" runat="server"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="300px" Width="650px">
            Actualizar Alumno<br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Alumno ID:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAlumnoId0" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Nombre:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAlumnoNombre0" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Buscar" />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Apellido:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAlumnoApellido0" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Edad:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAlumnoEdad0" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Direccion:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAlumnoDireccion0" runat="server" Enabled="False"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Height="26px" OnClick="Button3_Click" Text="Eliminar" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Actualizar" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </asp:Panel>
    </form>
</body>
</html>
