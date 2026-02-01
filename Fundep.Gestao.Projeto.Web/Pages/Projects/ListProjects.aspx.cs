using ProjectsWcfServiceLibrary.Contracts;
using ProjectsWcfServiceLibrary.Services;
using System;
using System.Linq;
using System.Web.Hosting;

namespace Fundep.Gestao.Projeto.Web.Pages.Projects
{
    public partial class ListProjects : System.Web.UI.Page
    {
        private readonly string xmlPath = HostingEnvironment.MapPath("~/App_Data/projects.xml");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProjects();
            }
        }

        private void LoadProjects()
        {
            
            IProjectService service = new ProjectServices(xmlPath);
            gvProjects.DataSource = service.ListProjects();
            gvProjects.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            IProjectService service = new ProjectServices(xmlPath);
            string search = txtSearch.Text.Trim().ToLower();

            var projects = service.ListProjects();
           
            if (!string.IsNullOrEmpty(search))
            {
                projects = projects.Where(p =>
                p.ProjectNum.ToString().Contains(search)).ToList();
            }

            gvProjects.DataSource = projects;
            gvProjects.DataBind();
        }

        protected void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            LoadProjects();
        }
    }
}