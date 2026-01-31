using Fundep.Gestao.Projeto.Web.Domain.Model;
using Fundep.Gestao.Projeto.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fundep.Gestao.Projeto.Web.Pages.Projects
{
    public partial class CreateProject : System.Web.UI.Page
    {
        private readonly IProjectService _projectService = new ProjectServiceMock();

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var project = new Project
                {
                    ProjectNum = int.Parse(txtProjectNum.Text),
                    SubProjectNum = txtSubProjectNum.Text,
                    Name = txtName.Text,
                    ManagerName = txtManagerName.Text,
                    ProjectBalance = decimal.Parse(txtProjectBalance.Text)
                };

                _projectService.CreateProject(project);

                lblStatus.Text = "Projeto criado com sucesso!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnClean_Click(object sender, EventArgs e)
        {
            txtProjectNum.Text = "";
            txtSubProjectNum.Text = "";
            txtName.Text = "";
            txtManagerName.Text = "";
            txtProjectBalance.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}