using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    /// <summary>
    /// Der Futterautomat kümmert sich um die Fütterung der Fische
    /// </summary>
    public class Futterautomat
    {
        public int FutterautomatId { get; set; }
        /// <summary>
        /// Der Futterfaktor dient zur empirischen Einstellung der Futtermenge bei jeder Fütterung
        /// </summary>
        public float FutterFaktor { get; set; } = 1f;

        public string Bezeichnung { get; set; } = string.Empty;

        // Die unterschiedlichen Fütterungen / Futterzeiten
        public virtual ICollection<Fuetterung> Fuetterungen { get; set; } = new List<Fuetterung>();
        public virtual Futter? Futter { get; set; }
        public virtual Aquarium? Aquarium { get; set; }
        public virtual Person? Person { get; set; }
    }
}
