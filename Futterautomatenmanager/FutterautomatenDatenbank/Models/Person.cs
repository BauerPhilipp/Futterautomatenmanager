using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; } = string.Empty;    
        public virtual ICollection<Futterautomat> Futterautomaten { get; set; }
    }
}
