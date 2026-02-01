<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateProject.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Fundep.Gestao.Projeto.Web.Pages.Projects.CreateProject" %>

<asp:Content ID="CreateProjectContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Cadastre um novo projeto</h2>
    <div>
        <asp:Label Text="Número do Projeto:" runat="server"/><br />
        <asp:TextBox ID="txtProjectNum" runat="server" style="margin-top: 2px" Width="289px" /> 
        &nbsp;&nbsp;&nbsp; 
        <asp:RequiredFieldValidator ControlToValidate="txtProjectNum" 
            ErrorMessage="Campo obrigatório!" ForeColor="Red" runat="server"/>
        <br /><br />

        <asp:Label Text="Número do SubProjeto:" runat="server"/><br />
        <asp:TextBox ID="txtSubProjectNum" runat="server" style="margin-top: 2px" Width="289px" /> 
        &nbsp;&nbsp;&nbsp; 
        <asp:RequiredFieldValidator ControlToValidate="txtSubProjectNum" 
            ErrorMessage="Campo obrigatório!" ForeColor="Red" runat="server"/>
        <br /><br />

        <asp:Label Text="Nome do Projeto:" runat="server" /><br />
        <asp:TextBox ID="txtName" runat="server" style="margin-top: 2px" Width="289px" />
        &nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ControlToValidate="txtName" 
            ErrorMessage="Campo obrigatório!" ForeColor="Red" runat="server"/>
        <br /><br />

        <asp:Label Text="Nome do Coordenador do Projeto:" runat="server" /><br />
        <asp:TextBox ID="txtManagerName" runat="server" style="margin-top: 2px" Width="289px" />
        &nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ControlToValidate="txtManagerName" 
            ErrorMessage="Campo obrigatório!" ForeColor="Red" runat="server"/>
        <br /><br />

        <asp:Label Text="Valor do Projeto:" runat="server" /><br />
        <asp:TextBox ID="txtProjectBalance" runat="server" style="margin-top: 2px" Width="289px" />
        &nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ControlToValidate="txtProjectBalance" 
            ErrorMessage="Campo obrigatório!" ForeColor="Red" runat="server"/>
        <br /><br />

        <asp:Button ID="btnSave" text="Salvar" runat="server" OnClick="btnSave_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnClean" text="Limpar" runat="server" OnClick="btnClean_Click" style="margin-left: 0px" />

        <br /><br />

        <asp:Label ID="lblStatus" runat="server"/>
    </div>
</asp:Content>

