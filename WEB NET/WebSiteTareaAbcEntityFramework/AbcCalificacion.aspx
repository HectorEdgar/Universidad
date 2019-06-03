<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AbcCalificacion.aspx.cs" Inherits="AbcCalificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getCalificaciones" TypeName="EscuelaDs">
                <SelectParameters>
                    <asp:Parameter DefaultValue="0" Name="startIndex" Type="Int32" />
                    <asp:Parameter DefaultValue="10" Name="maxRows" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="getAlumnos" TypeName="EscuelaDs">
                <SelectParameters>
                    <asp:Parameter DefaultValue="0" Name="startIndex" Type="Int32" />
                    <asp:Parameter DefaultValue="100" Name="maxRows" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="getMaterias" TypeName="EscuelaDs">
                <SelectParameters>
                    <asp:Parameter DefaultValue="0" Name="startIndex" Type="Int32" />
                    <asp:Parameter DefaultValue="100" Name="maxRows" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="NotId" HeaderText="NotId" SortExpression="NotId" />
                    <asp:BoundField DataField="NotNota" HeaderText="NotNota" SortExpression="NotNota" />
                    <asp:BoundField DataField="MatId" HeaderText="MatId" SortExpression="MatId" />
                    <asp:BoundField DataField="AluId" HeaderText="AluId" SortExpression="AluId" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
    <div>
    
        <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Alta Calificacion"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Calificacion Id"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAltaCalificacionID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Calificacion"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAltaCalificacionCalificacion" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Alumno"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="txtAltaCalificacionListBox" runat="server" DataSourceID="ObjectDataSource2" DataTextField="AluNombre" DataValueField="AluNombre" Height="36px" Width="204px"></asp:ListBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Materia"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="txtAltaCalificacionListbox2" runat="server" DataSourceID="ObjectDataSource3" DataTextField="MatNombre" DataValueField="MatNombre" Height="37px" Width="198px">
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click" Text="Agregar" Width="67px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Panel3" runat="server">
            <asp:Label ID="Label6" runat="server" Text="Alta Calificacion"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Calificacion Id"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtActualizacionCalificacionID" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Calificacion"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtActualizacionCalificacionCalificacion" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Alumno"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="txtActualizacionCalificacionListBox1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="AluNombre" DataValueField="AluNombre" Height="43px" Width="204px"></asp:ListBox>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Materia"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="txtActualizacionCalificacionListBox2" runat="server" DataSourceID="ObjectDataSource3" DataTextField="MatNombre" DataValueField="MatNombre" Height="43px" Width="198px">
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Height="26px" OnClick="Button3_Click" Text="Buscar por alumno y materia" Width="199px" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Height="26px" OnClick="Button4_Click" Text="Eliminar" Width="67px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="26px" OnClick="Button2_Click" Text="Actualizar" Width="67px" />
        </asp:Panel>
    </form>
</body>
</html>
