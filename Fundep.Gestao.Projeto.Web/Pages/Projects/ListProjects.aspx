<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListProjects.aspx.cs" Inherits="Fundep.Gestao.Projeto.Web.Pages.Projects.ListProjects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Projentos existentes</title>
</head>
<body>
    <form id="ListPage" runat="server">
        <div>
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

            <asp:Button ID="btnBack" runat="server" Text="Voltar" PostBackUrl="../Home/Default.aspx"/>
        </div>
    </form>
</body>
</html>
