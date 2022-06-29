<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Plants.aspx.cs" Inherits="Aplicacion.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <asp:Button ID="Conectado" runat="server" Text="Leer Conectado" OnClick="Conectado_Click" />
        <asp:Button ID="Desconectado" runat="server" Text="Leer Desconectado" OnClick="Desconectado_Click" />
        <br /> <br /> <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:miConexion %>" DeleteCommand="DELETE FROM [Plantas] WHERE [Nombre] = @original_Nombre AND (([Regada] = @original_Regada) OR ([Regada] IS NULL AND @original_Regada IS NULL))" InsertCommand="INSERT INTO [Plantas] ([Nombre], [Regada]) VALUES (@Nombre, @Regada)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Plantas]" UpdateCommand="UPDATE [Plantas] SET [Regada] = @Regada WHERE [Nombre] = @original_Nombre AND (([Regada] = @original_Regada) OR ([Regada] IS NULL AND @original_Regada IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_Nombre" Type="String" />
                <asp:Parameter Name="original_Regada" Type="Boolean" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Nombre" Type="String" />
                <asp:Parameter Name="Regada" Type="Boolean" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Regada" Type="Boolean" />
                <asp:Parameter Name="original_Nombre" Type="String" />
                <asp:Parameter Name="original_Regada" Type="Boolean" />
            </UpdateParameters>
        </asp:SqlDataSource>

        <br /> <br />
        <asp:TextBox ID="Nombre" runat="server" ></asp:TextBox>
        <asp:TextBox ID="Regado" runat="server"></asp:TextBox>
        <br /> <br />
        <asp:Button ID="InsertarConectado" runat="server" Text="Insertar Conectado" OnClick="InsertarConectado_Click" />
        <asp:Button ID="InsertarDesconectado" runat="server" Text="Insertar Desconectado" OnClick="InsertarDesconectado_Click" /> <br /> <br />
        <asp:Button ID="BorrarConectado" runat="server" Text="Borrar Conectado" OnClick="BorrarConectado_Click" />
        <asp:Button ID="BorrarDesconectado" runat="server" Text="Borrar Desconectado" OnClick="BorrarDesconectado_Click" /><br /> <br />
        <asp:Button ID="ActualizarConectado" runat="server" Text="Actualizar Conectado" OnClick="ActualizarConectado_Click" />
        <asp:Button ID="ActualizarDesconectado" runat="server" Text="Actualizar Desconectado" OnClick="ActualizarDesconectado_Click" />
</asp:Content>
