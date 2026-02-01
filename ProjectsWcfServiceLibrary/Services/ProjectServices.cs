using ProjectsWcfServiceLibrary.Contracts;
using ProjectsWcfServiceLibrary.Data;
using ProjectsWcfServiceLibrary.Models;
using System.Collections.Generic;

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
