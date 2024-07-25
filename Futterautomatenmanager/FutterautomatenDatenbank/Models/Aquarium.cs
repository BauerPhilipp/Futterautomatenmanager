using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    internal class Aquarium
    {
        public int AquariumId { get; set; }
        public string Name { get; set; }
        public string Aufstellort { get; set; }
        public string Groeße { get; set; }
    }
}
