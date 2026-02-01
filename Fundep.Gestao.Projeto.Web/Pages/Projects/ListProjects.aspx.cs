using Fundep.Gestao.Projeto.Web.Services;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
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
            ProjectServiceXml service = new ProjectServiceXml();
            gvProjects.DataSource = service.GetAll();
            gvProjects.DataBind();
        }
    }
}