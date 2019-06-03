<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePaginas.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content3" Runat="Server">
    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=ComentariosEntities" DefaultContainerName="ComentariosEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="Usuarios" EntityTypeFilter="Usuario">
    </asp:EntityDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="usuario1" DataSourceID="EntityDataSource1" ForeColor="Black" GridLines="Horizontal"  >
        <Columns>
            
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            
            <asp:BoundField DataField="usuario1" HeaderText="usuario1" ReadOnly="True" SortExpression="usuario1" />
            <asp:BoundField DataField="password" HeaderText="password" SortExpression="password" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
            <asp:BoundField DataField="pais" HeaderText="pais" SortExpression="pais" />
            <asp:BoundField DataField="sexo" HeaderText="sexo" SortExpression="sexo" />
            <asp:BoundField DataField="correo" HeaderText="correo" SortExpression="correo" />
            <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
        
    </asp:GridView>
    
    
    <br />
    
    
    <asp:Label ID="Label9" runat="server" Text="Agregar Usuario" CssClass="Label"></asp:Label>
    <br />
    <br />
    
    
    <asp:Label ID="Label1" runat="server" Text="Usuario" CssClass="Label"></asp:Label>
    <asp:TextBox ID="txtUsuario" runat="server" CssClass="Caja"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Contraseña" CssClass="Label"></asp:Label>
    <asp:TextBox ID="txtContrasena" runat="server" CssClass="Caja" Height="22px"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Nombre" CssClass="Label"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server" CssClass="Caja"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Apellido" CssClass="Label"></asp:Label>
    <asp:TextBox ID="txtApellido" runat="server" CssClass="Caja"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Pais" CssClass="Label"></asp:Label>
    <asp:TextBox ID="txtPais" runat="server" CssClass="Caja"></asp:TextBox>
    <br />
    <asp:Label ID="Label6" runat="server" Text="Sexo" CssClass="Label"></asp:Label>
    <asp:TextBox ID="txtSexo" runat="server" CssClass="Caja"></asp:TextBox>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Correo" CssClass="Label"></asp:Label>
    <asp:TextBox ID="txtCorreo" runat="server" CssClass="Caja"></asp:TextBox>
    <br />
    <asp:Label ID="Label8" runat="server" Text="Telefono" CssClass="Label"></asp:Label>
    <asp:TextBox ID="txtTelefono" runat="server" CssClass="Caja"></asp:TextBox>
    <br />
    <br />
    <br />
    
    
    <asp:Button ID="Button1" runat="server" CssClass="Boton" Text="Agregar" OnClick="Button1_Click" />
    
    
    <br />
    
    <style>
        .Label
        {
            margin-left : 60px;
            font-size:24px;
            
        }
        .Caja 
        {
            position : absolute;
            left:220px;
            font-size:24px;
            
        }
        .Boton
        {
            position : absolute;
            left:422px;
            top: 831px;
        }
        
    </style>
</asp:Content>

