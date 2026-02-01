using ProjectsWcfServiceLibrary.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace ProjectsWcfServiceLibrary.Contracts
{
    [ServiceContract]
    public interface IProjectService
    {
        [OperationContract]
        void Create(Project project);

        [OperationContract]
        List<Project> ListProjects();
    }
}
