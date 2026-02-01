using ProjectsWcfServiceLibrary.Contracts;
using ProjectsWcfServiceLibrary.Services;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fundep.Gestao.Projeto.Web.Pages.Projects
{
    public partial class ListProjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProjects();
            }
        }

        private void LoadProjects()
        {
            string xmlPath = HostingEnvironment.MapPath("~/App_Data/projects.xml");
            IProjectService service = new ProjectServices(xmlPath);
            gvProjects.DataSource = service.ListProjects();
            gvProjects.DataBind();
        }
    }
}