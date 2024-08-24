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

        /// <summary>
        /// Der Name des Futterautomaten. Dieser wird benötigt wenn über die API ein Futterautomat abgefagt werden soll
        /// </summary>
        public string Bezeichnung { get; set; } = string.Empty;
        public bool ManuelleFuetterung { get; set; }

        // Die unterschiedlichen Fütterungen / Futterzeiten
        public virtual ICollection<Fuetterung> Fuetterungen { get; set; } = new List<Fuetterung>();
        //Futter welches im Futterautomaten eingefüllt ist
        public virtual Futter? Futter { get; set; }
        //Das Aquarium in dem der Futterautomat integriert ist
        public virtual Aquarium? Aquarium { get; set; }
        //Die Person welche den Futterautomaten erstellt hat
        public virtual Person? Person { get; set; }
    }
}
