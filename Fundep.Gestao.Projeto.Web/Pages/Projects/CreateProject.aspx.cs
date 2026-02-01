using ProjectsWcfServiceLibrary.Contracts;
using ProjectsWcfServiceLibrary.Models;
using ProjectsWcfServiceLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fundep.Gestao.Projeto.Web.Pages.Projects
{
    public partial class CreateProject : System.Web.UI.Page
    {
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string xmlPath = HostingEnvironment.MapPath("~/App_Data/projects.xml");
                IProjectService service = new ProjectServices(xmlPath);
                var project = new Project
                {
                    ProjectNum = int.Parse(txtProjectNum.Text),
                    SubProjectNum = txtSubProjectNum.Text,
                    Name = txtName.Text,
                    ManagerName = txtManagerName.Text,
                    ProjectBalance = decimal.Parse(txtProjectBalance.Text)
                };

                service.Create(project);

                lblStatus.Text = "Projeto criado com sucesso!";
                lblStatus.ForeColor = System.Drawing.Color.Green;

                ClearFields();
                
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnClean_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtProjectNum.Text = string.Empty;
            txtSubProjectNum.Text = string.Empty;
            txtName.Text = string.Empty;
            txtManagerName.Text = string.Empty;
            txtProjectBalance.Text = string.Empty;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}