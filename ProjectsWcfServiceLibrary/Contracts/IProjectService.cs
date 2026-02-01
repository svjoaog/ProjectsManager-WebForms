using ProjectsWcfServiceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

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
