using Fundep.Gestao.Projeto.Web.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fundep.Gestao.Projeto.Web.Services
{
    public interface IProjectService
    {
        void CreateProject(Project project);
    }
}