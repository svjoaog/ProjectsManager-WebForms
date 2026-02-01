using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fundep.Gestao.Projeto.Web.Domain.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}