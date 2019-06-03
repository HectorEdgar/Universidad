<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="idAlumno" DataSourceID="EntityDataSource1">
        <Columns>
            <asp:BoundField DataField="idAlumno" HeaderText="idAlumno" ReadOnly="True" SortExpression="idAlumno" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
            <asp:BoundField DataField="apellido" HeaderText="apellido" SortExpression="apellido" />
            <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
            <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            <asp:BoundField DataField="nickname" HeaderText="nickname" SortExpression="nickname" />
            <asp:BoundField DataField="nivelJuego" HeaderText="nivelJuego" SortExpression="nivelJuego" />
        </Columns>
    </asp:GridView>
    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=DirectorioEntities1" DefaultContainerName="DirectorioEntities1" EnableFlattening="False" EntitySetName="Alumnoes" EntityTypeFilter="Alumno">
    </asp:EntityDataSource>
</asp:Content>

