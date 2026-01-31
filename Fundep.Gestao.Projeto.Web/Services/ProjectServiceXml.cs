using Fundep.Gestao.Projeto.Web.Domain.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Fundep.Gestao.Projeto.Web.Services
{
    public class ProjectServiceXml
    {
        private string XmlPath => HttpContext.Current.Server.MapPath("../../App_Data/projects.xml");

        public void save(Project project)
        {
            XDocument document;

            if (File.Exists(XmlPath))
            {
                document = XDocument.Load(XmlPath);
            }
            else
            {
                document = new XDocument(new XElement("Projects"));
            }

            XElement newProject = new XElement("Project",
                new XElement("ProjectNumber", project.ProjectNum),
                new XElement("SubProjectNumber", project.SubProjectNum),
                new XElement("Name", project.Name),
                new XElement("Manager", project.ManagerName),
                new XElement("Balance", project.ProjectBalance)
                );

            document.Root.Add(newProject);
            document.Save(XmlPath); 

        }
    }
}