<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="AplicacionCI2.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Login usuarios</h2>
    <br />
    <asp:Label ID="Lbu1" Text="Usuario:" runat="server" />
    <asp:TextBox ID="Tbu1" runat="server" />
    <br />
    <br />
    <asp:Label ID="Lbu2" Text="Contraseña:" runat="server" />
    <asp:TextBox ID="Tbu2" runat="server" />
    <br />
    <br />
    <asp:Button ID="Btu1" Text="Ingresar" OnClick="Btu1_Click" runat="server" />
    <br />
    <br />
    <asp:Label ID="Lbu3" runat="server" />
</asp:Content>
