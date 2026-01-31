using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fundep.Gestao.Projeto.Web.Domain.Model
{
    public class Project
    {
        public int ProjectNum { get; set; }
        public String SubProjectNum { get; set; }
        public string Name { get; set; }
        public string ManagerName { get; set; }
        public decimal ProjectBalance { get; set; }
    }
}