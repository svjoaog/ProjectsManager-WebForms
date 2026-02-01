<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Fundep.Gestao.Projeto.Web.Pages.Home.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="PageHome" runat="server">
        <div>
            <h2>Sistema de Gestão de Projetos</h2>

            <asp:Button ID="btnCreate" runat="server" 
                Text="Criar Projeto" PostBackUrl="~/Pages/Projects/CreateProject.aspx" />

            <asp:Button ID="btnList" runat="server"
                Text="Listar Projetos" PostBackUrl="~/Pages/Projects/ListProjects.aspx" />

        </div>
    </form>
</body>
</html>
