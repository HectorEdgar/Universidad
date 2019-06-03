<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=DirectorioEntities" DefaultContainerName="DirectorioEntities" EnableDelete="True" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="Alumnoes" EntityTypeFilter="Alumno">
    </asp:EntityDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="EntityDataSource1" AutoGenerateColumns="False" DataKeyNames="nombre">
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="nombre" ReadOnly="True" SortExpression="nombre" />
            <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
            <asp:BoundField DataField="edad" HeaderText="edad" SortExpression="edad" />
            <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
        </Columns>

    </asp:GridView>
</asp:Content>

