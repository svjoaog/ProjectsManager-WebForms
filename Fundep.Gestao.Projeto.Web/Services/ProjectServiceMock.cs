using Fundep.Gestao.Projeto.Web.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fundep.Gestao.Projeto.Web.Services
{
    public class ProjectServiceMock : IProjectService
    {
        public void CreateProject(Project project)
        {
            if (project.ProjectNum <= 0)
            {
                throw new ArgumentException("Número do projeto não pode ser zero ou negativo.");
            }
            if (string.IsNullOrWhiteSpace(project.SubProjectNum))
            {
                throw new ArgumentException("Número do subprojeto não pode estar vazio.");
            }
            if (string.IsNullOrWhiteSpace(project.Name))
            {
                throw new ArgumentException("Nome não pode estar vazio");
            }
            if (string.IsNullOrWhiteSpace(project.ManagerName))
            {
                throw new ArgumentException("Nome do coordenador do projeto não pode estar vazio");
            }
            if (project.ProjectBalance <= 0)
            {
                throw new ArgumentException("Valor do projeto não pode ser menor ou igual a zero");
            }
        }
    }
}