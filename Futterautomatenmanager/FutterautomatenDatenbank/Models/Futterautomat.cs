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
        /// <summary>
        /// Wenn eine manuelle Fütterung erfolgen soll. Ist für die API von Bedeutung.
        /// </summary>
        public bool ManuelleFuetterung { get; set; }

        /// <summary>
        /// Die geplanten Fütterungen
        /// </summary>
        public virtual ICollection<Fuetterung> Fuetterungen { get; set; } = new List<Fuetterung>();
        /// <summary>
        /// Futter welches im Futterautomaten eingefüllt ist
        /// </summary>
        public virtual Futter? Futter { get; set; }
        /// <summary>
        /// Das Aquarium in dem der Futterautomat integriert ist
        /// </summary>
        public virtual Aquarium? Aquarium { get; set; }
        /// <summary>
        /// Die Person die den Futterautomaten erstellt hat
        /// </summary>
        public virtual Person? Person { get; set; }
    }
}
