<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SancionesForm.aspx.cs" Inherits="SancionesForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div><header><h2>Sanciones</h2></header></div>
    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=bibliotecaEntities" DefaultContainerName="bibliotecaEntities" EnableDelete="True" EnableFlattening="False" EnableUpdate="True" EntitySetName="Sanciones" EntityTypeFilter="Sancione">
    </asp:EntityDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="sanCodigo" DataSourceID="EntityDataSource1" ShowFooter="True" ShowHeaderWhenEmpty="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="sanCodigo" HeaderText="sanCodigo" ReadOnly="True" SortExpression="sanCodigo" />
            <asp:BoundField DataField="sanDiasSancion" HeaderText="sanDiasSancion" SortExpression="sanDiasSancion" />
            <asp:BoundField DataField="sanFechaInicio" HeaderText="sanFechaInicio" SortExpression="sanFechaInicio" />
            <asp:BoundField DataField="sanFechaFin" HeaderText="sanFechaFin" SortExpression="sanFechaFin" />
            <asp:BoundField DataField="preCodigo" HeaderText="preCodigo" SortExpression="preCodigo" />
        </Columns>
    </asp:GridView>
    <p>
    </p>
</asp:Content>

