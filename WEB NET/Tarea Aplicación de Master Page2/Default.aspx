<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPagePaginas.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content3" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="EntityDataSource1">
        <Columns>
            <asp:BoundField DataField="usuario1" HeaderText="usuario1" ReadOnly="True" SortExpression="usuario1" />
            <asp:BoundField DataField="apellido" HeaderText="apellido" ReadOnly="True" SortExpression="apellido" />
            <asp:BoundField DataField="nombre" HeaderText="nombre" ReadOnly="True" SortExpression="nombre" />
            <asp:BoundField DataField="pais" HeaderText="pais" ReadOnly="True" SortExpression="pais" />
            <asp:BoundField DataField="sexo" HeaderText="sexo" ReadOnly="True" SortExpression="sexo" />
            <asp:BoundField DataField="correo" HeaderText="correo" ReadOnly="True" SortExpression="correo" />
            <asp:BoundField DataField="telefono" HeaderText="telefono" ReadOnly="True" SortExpression="telefono" />
        </Columns>
    </asp:GridView>
    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=ComentariosEntities" DefaultContainerName="ComentariosEntities" EnableFlattening="False" EntitySetName="Usuarios" EntityTypeFilter="Usuario" Select="it.[usuario1], it.[apellido], it.[nombre], it.[pais], it.[sexo], it.[correo], it.[telefono]"
        AutoGenerateOrderByClause="true" >
        <OrderByParameters>
            <asp:Parameter DefaultValue="usuario1"/>
        </OrderByParameters>
    </asp:EntityDataSource>
    
</asp:Content>

