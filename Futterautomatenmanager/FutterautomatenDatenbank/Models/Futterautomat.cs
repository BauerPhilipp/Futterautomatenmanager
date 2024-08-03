using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    public class Futterautomat
    {
        public int FutterautomatId { get; set; }
        // Zum korrekten einstellen der Futtermenge
        public float FutterFaktor { get; set; } = 1f;

        public string Bezeichnung { get; set; } = string.Empty;

        // Die unterschiedlichen Fütterungen / Futterzeiten
        public virtual ICollection<Fuetterung>? Fuetterungen { get; set; }
        public virtual Futter? Futter { get; set; }
        public virtual Aquarium? Aquarium { get; set; }
        public virtual Person? Person { get; set; }
    }
}
