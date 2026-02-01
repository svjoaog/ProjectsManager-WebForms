using ProjectsWcfServiceLibrary.Contracts;
using ProjectsWcfServiceLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectsWcfServiceLibrary.Models;

namespace ProjectsWcfServiceLibrary.Services
{
    public class ProjectServices : IProjectService
    {
        private readonly ProjectXmlRepository _repository;

        public ProjectServices(string xmlPath)
        {
            _repository = new ProjectXmlRepository(xmlPath);
        }

        public void Create(Project project)
        {
            _repository.Save(project);
        }

        public List<Project> ListProjects()
        {
            return _repository.ListProjects();
        }
    }
}
 