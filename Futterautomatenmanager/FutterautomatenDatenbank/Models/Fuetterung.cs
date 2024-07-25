using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    internal class Fuetterung
    {
        public int FuetterungId { get; set; }
        public float Futtermenge { get; set; }
        public DateOnly Tag { get; set; }
        public TimeOnly Uhrzeit { get; set; }
        public virtual Futterautomat? FutterautomatId { get; set; }
    }
}
