<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListProjects.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Fundep.Gestao.Projeto.Web.Pages.Projects.ListProjects" %>
<asp:Content ID="ListProjectsContent" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Projetos cadastrados</h2>
    
        <asp:Label runat="server" Text="Busque por Numero do Projeto:"></asp:Label><br />
        <asp:TextBox runat="server" Width="300px" ID="txtSearch"></asp:TextBox> 
            &nbsp; 
        <asp:Button runat="server" ID="btnSearch" Text="Buscar" OnClick="btnSearch_Click"/> <asp:Button runat="server" ID="btnClearFilter" Text="Limpar" OnClick="btnClearFilter_Click"/>
        <br /><br />
        <asp:GridView ID="gvProjects" runat="server" AutoGenerateColumns="false"
            BorderWidth="1" CellPadding="5">

            <Columns>
                <asp:BoundField DataField="ProjectNum" HeaderText="Projeto"/>
                <asp:BoundField DataField="SubProjectNum" HeaderText="SubProjeto" />
                <asp:BoundField DataField="Name" HeaderText="Nome" />
                <asp:BoundField DataField="ManagerName" HeaderText="Coordenador" />
                <asp:BoundField DataField="ProjectBalance" HeaderText="Saldo" />
            </Columns>

        </asp:GridView>

        <br />

        <asp:Button ID="btnBack" runat="server" Text="Voltar" PostBackUrl="~/Default.aspx"/>
</asp:Content>