using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginB
{
    public class User
    {
        public UInt64 Id { get; set; }
        public String? Name { get; set; }
        public Credential? Credential { get; set; }
    }
}
