<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Controls.aspx.cs" Inherits="Aplicacion.WebForm2" %>
 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Counter" runat="server" Text="Label"></asp:Label>
    <br /><br />
    <asp:Button ID="Reset" runat="server" Text="Reset" OnClick="Reset_Click" />
    <br /><br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
     <br /><br />
    <asp:Button ID="Mail" runat="server" Text="Enviar mail" OnClick="Mail_Click" />
</asp:Content>
