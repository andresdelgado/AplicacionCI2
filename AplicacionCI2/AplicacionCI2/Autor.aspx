<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Autor.aspx.cs" Inherits="AplicacionCI2.Autor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gestionar Usuarios</h2>
    <br />
    <h4>Consultar Usuarios</h4>
    <asp:Button ID="B2" Text="Consultar" OnClick="B2_Click" runat="server" />
    <br />
    <br />
    <asp:GridView ID="GvLogin" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField DataField="idautor" HeaderText="ID Autor" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="usuario" HeaderText="Usuario" />
            <asp:BoundField DataField="contrasena" HeaderText="Contraseña" />
        </Columns>
    </asp:GridView>
    <br />
    <h4>Datos de usuario</h4>
    <asp:Label ID="Lb1" Text="Nombre:" runat="server" />
    <asp:TextBox ID="Tb1" runat="server" />
    <br />
    <br />
    <asp:Label ID="Lb2" Text="Usuario:" runat="server" />
    <asp:TextBox ID="Tb2" runat="server" />
    <br />
    <br />
    <asp:Label ID="Lb3" Text="Contraseña:" runat="server" />
    <asp:TextBox ID="Tb3" runat="server" />
    <br />
    <asp:Label ID="Lb4" runat="server" />
    <br />
    <h4>Crear Usuario</h4>
    <asp:Button ID="B1" Text="Crear" OnClick="B1_Click" runat="server" />
    <br />
    <br />
    <h4>Actualizar Usuario</h4>
    <asp:Label ID="Lb5" Text="Ingrese el ID a actualizar" runat="server" />
    <asp:TextBox ID="Tb4" runat="server" />
    <br />
    <asp:Label ID="Lb6" Text="Luego diligencie los campos para actualizar" runat="server" />
    <br />
    <asp:Button ID="B3" Text="Actualizar" OnClick="B3_Click" runat="server" />
    <br />
    <br />
    <h4>Eliminar Usuario</h4>
    <asp:Label ID="Lb7" Text="Ingrese el ID del usuario a eliminar" runat="server" />
    <asp:TextBox ID="Tb5" runat="server" />
    <br />
    <asp:Button ID="B4" Text="Eliminar" OnClick="B4_Click" runat="server" />
    <br />
    <asp:Label ID="Lb8" Text="Consulte los usuarios disponibles" runat="server" />
</asp:Content>