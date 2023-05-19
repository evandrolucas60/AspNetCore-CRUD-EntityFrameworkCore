using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCrudMvc.Models
{
    public class Institution
    {
        public long? InstitutionID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
