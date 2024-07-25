using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    internal class Futterautomat
    {
        public int FutterautomatId { get; set; }
        // Zum korrekten einstellen der Futtermenge
        public float FutterFaktor { get; set; }
        // Die unterschiedlichen Fütterungen / Futterzeiten
        public List<Fuetterung> Fuetterungen { get; set; }

        public virtual Futter? FutterId { get; set; }
        public virtual Aquarium? AquariumId { get; set; }
        public virtual Person? PersonId { get; set; }
    }
}
