<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Fundep.Gestao.Projeto.Web.Default" %>

<asp:Content ID="DefaultContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Sistema de Gestão de Projetos</h2>

    <asp:Button ID="btnCreate" runat="server" 
        Text="Criar Projeto" PostBackUrl="~/Pages/Projects/CreateProject.aspx" />

    <asp:Button ID="btnList" runat="server"
        Text="Listar Projetos" PostBackUrl="~/Pages/Projects/ListProjects.aspx" />
</asp:Content>

