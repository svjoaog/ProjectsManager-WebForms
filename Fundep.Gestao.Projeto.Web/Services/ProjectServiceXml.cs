using Fundep.Gestao.Projeto.Web.Domain.Model;
using Fundep.Gestao.Projeto.Web.Domain.Exceptions;
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

            bool exists = document.Root.Elements("Project")
                .Any(p =>(int)p.Element("ProjectNumber") == project.ProjectNum);

            if (exists)
            {
                throw new CustomException("Projeto já existente no banco de dados.");
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

        public List<Project> GetAll()
        {
            List<Project> projects = new List<Project>();

            if(!File.Exists(XmlPath))
                return projects;

            XDocument document = XDocument.Load(XmlPath);

            projects = document.Root
                .Elements("Project")
                .Select(p => new Project
                {
                    ProjectNum = (int)p.Element("ProjectNumber"),
                    SubProjectNum = (string)p.Element("SubProjectNumber"),
                    Name = (string)p.Element("Name"),
                    ManagerName = (string)p.Element("Manager"),
                    ProjectBalance = (decimal)p.Element("Balance")
                })
                .ToList();

            return projects;
        }
    }
}