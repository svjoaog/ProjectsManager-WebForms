<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListProjects.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Fundep.Gestao.Projeto.Web.Pages.Projects.ListProjects" %>
<asp:Content ID="ListProjectsContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Projetos cadastrados</h2>

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