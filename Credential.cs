using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoginB
{
    public class Credential
    {
        public UInt64? Id { get; set; }
        public User? User { get; set; }
        public String? Username { get; set; }
        public String? Password { get; set; }
        public Boolean IsAdmin { get; set; } = false;
    }
}
