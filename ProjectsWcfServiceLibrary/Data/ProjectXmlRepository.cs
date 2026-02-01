using ProjectsWcfServiceLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectsWcfServiceLibrary.Data
{
    public class ProjectXmlRepository
    {
        private readonly string _xmlPath;

        public ProjectXmlRepository(string xmlPath)
        {
            _xmlPath = xmlPath;
        }

        public void Save(Project project)
        {
            XDocument document;

            if (File.Exists(_xmlPath))
            {
                document = XDocument.Load(_xmlPath);
            }
            else
            {
                document = new XDocument(new XElement("Projects"));
            }

            bool exists = document.Root.Elements("Project")
                .Any(p => (int)p.Element("ProjectNumber") == project.ProjectNum);

            if (exists)
            {
                throw new FaultException("Projeto já existente no banco de dados.");
            }

            document.Root.Add(new XElement("Project",
                new XElement("ProjectNumber", project.ProjectNum),
                new XElement("SubProjectNumber", project.SubProjectNum),
                new XElement("Name", project.Name),
                new XElement("Manager", project.ManagerName),
                new XElement("Balance", project.ProjectBalance)));

            document.Save(_xmlPath);
        }

        public List<Project> ListProjects()
        {
            List<Project> projects = new List<Project>();

            if (!File.Exists(_xmlPath))
                return projects;

            XDocument document = XDocument.Load(_xmlPath);

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
