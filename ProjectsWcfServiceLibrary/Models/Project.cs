using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsWcfServiceLibrary.Models
{
    [DataContract]
    public class Project
    {
        [DataMember]
        public int ProjectNum { get; set; }

        [DataMember]
        public String SubProjectNum { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string ManagerName { get; set; }

        [DataMember]
        public decimal ProjectBalance { get; set; }
    }
}
