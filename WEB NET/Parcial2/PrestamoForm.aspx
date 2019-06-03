<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PrestamoForm.aspx.cs" Inherits="PrestamoFormn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <header><h2>Realizar préstamo</h2></header>
        <p>Fecha: 
            <asp:TextBox ID="txtPrestamoFecha" runat="server" Height="22px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Fecha Incorrecta" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d" ControlToValidate="txtPrestamoFecha">dd/mm/aaaa</asp:RegularExpressionValidator>
        </p>

        <p>Usuario: 
            <asp:DropDownList ID="dropPrestamoUsuario" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Guardar préstamo" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </div>
    <div>
        <p>Libro: 
            <asp:DropDownList ID="dropPrestamoLibro" runat="server" OnSelectedIndexChanged="dropPrestamoLibro_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p>Cantidad: 
            <asp:TextBox ID="txtCantida" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtCantida" ErrorMessage="Ingrese un numero Valido" MaximumValue="1000" MinimumValue="1" Type="Integer">1-1000</asp:RangeValidator>
        </p>
        <p>Limite de Entrega: <asp:TextBox ID="txtPrestamoFechaEntrega" runat="server" Enabled="False"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Guardar Libro" OnClick="Button3_Click" />
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" ShowHeaderWhenEmpty="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </p>
    </div>
    <div>
        <header><h2>Realizar devolución</h2></header>
        <p>Fecha: 
            <asp:TextBox ID="txtDevolucionFecha" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Fecha Incorrecta" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d" ControlToValidate="txtDevolucionFecha">dd/mm/aaaa</asp:RegularExpressionValidator>
        </p>
        <p>Usuario: 
            <asp:DropDownList ID="dropDevolucionUsuario" runat="server">
            </asp:DropDownList>
        </p>
        <p>Libro: 
            <asp:DropDownList ID="dropDevolucionLibro" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Guardar" OnClick="Button2_Click" />
        </p>
    </div>
</asp:Content>

