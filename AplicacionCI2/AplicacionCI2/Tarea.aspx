<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Tarea.aspx.cs" Inherits="AplicacionCI2.Tarea" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 >Gestionar Tarea</h2>
    <br />
    <h4>Consultar tareas</h4>
    <asp:Button ID="Bta2" Text="Todas las tareas" OnClick="Bta2_Click" runat="server" />
    <br />
    <br />
    <asp:Button ID="Bta4" Text="Estado" OnClick="Bta4_Click" runat="server" />
    <asp:Label ID="Lbta9" Text="Finalizado: (si/no)" runat="server" />
    <asp:TextBox ID="Tbta7" runat="server" />
    <br />
    <br />
    <asp:Label ID="Lbta10" Text="Ordenar la fecha de vencimiento de forma: " runat="server" />
    <br />
    <asp:Button ID="Bta5" Text="Ascendente" OnClick="Bta5_Click" runat="server" />
    <asp:Button ID="Bta6" Text="Descendente" OnClick="Bta6_Click" runat="server" />
    <br />
    <br />
    <asp:GridView ID="GvTarea" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField DataField="idtarea" HeaderText="ID Tarea" />
            <asp:BoundField DataField="fcreacion" HeaderText="Fecha de Creacion" />
            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
            <asp:BoundField DataField="estado" HeaderText="Estado" />
            <asp:BoundField DataField="fvencimiento" HeaderText="Fecha de Vencimiento" />
            <asp:BoundField DataField="Autor" HeaderText="Autor" />
        </Columns>
    </asp:GridView>
    <br />
    <h4>Informacion de la tarea</h4>
    <asp:Label ID="Lbta1" Text="Fecha de creacion:" runat="server" />
    <asp:TextBox ID="Tbta1" TextMode="Date" runat="server" />
    <br />
    <br />
    <asp:Label ID="Lbta2" Text="Descripcion:" runat="server" />
    <asp:TextBox ID="Tbta2" runat="server" />
    <br />
    <br />
    <asp:Label ID="Lbta3" Text="Estado:" runat="server" />
    <br />
    <asp:Label ID="Lbta7" Text="Finalizada (si/no)" runat="server" />
    <asp:TextBox ID="Tbta3" MaxLength="2" runat="server" />
    <br />
    <br />
    <asp:Label ID="Lbta4" Text="Fecha de vencimiento:" runat="server" />
    <asp:TextBox ID="Tbta4" TextMode="Date" runat="server" />
    <br />
    <br />
    <asp:Label ID="Lbta5" Text="Autor:" runat="server" />
    <asp:TextBox ID="Tbta5" runat="server" />
    <br />
    <br />
    <asp:Label ID="Lbta6" runat="server" />
    <br />
    <br />
    <h4>Crear tarea</h4>
    <asp:Button ID="Bta1" Text="Crear tarea" OnClick="Bta1_Click" runat="server" />
    <br />
    <br />
    <h4>Actualizar tarea</h4>
    <asp:Label ID="Lbta8" Text="Ingrese el ID de la tarea" runat="server" />
    <asp:TextBox ID="Tbta6" runat="server" />
    <br />
    <asp:Button ID="Bta3" Text="Actualizar" OnClick="Bta3_Click" runat="server" />
    <br />
</asp:Content>