<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=DirectorioEntities1" DefaultContainerName="DirectorioEntities1" EnableDelete="True" EnableFlattening="False" EnableUpdate="True" EntitySetName="Alumnoes" EntityTypeFilter="Alumno">
</asp:EntityDataSource>
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="idAlumno" DataSourceID="EntityDataSource1">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
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
</asp:Content>

