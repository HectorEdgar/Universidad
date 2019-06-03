    <%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageLoginmaster.master" AutoEventWireup="true" CodeFile="PaginaLoggin.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder3" runat="Server">

    <div>
        <p>Usuario</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>Contraseña</p>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <div>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Ingresar" OnClick="Button1_Click" />
            <br />
            <br />
        </div>

    </div>
      
</asp:Content>

