using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    /// <summary>
    /// Zur Planung von Fütterungszeiten des jeweiligen Futterautomaten
    /// </summary>
    public class Fuetterung
    {
        /// <summary>
        /// Eindeutige ID der Fütterung
        /// </summary>
        public int FuetterungId { get; set; }
        /// <summary>
        /// Futtermenge die pro Fütterung an die Fische abgegeben werden soll
        /// </summary>
        [Required]
        public float Futtermenge { get; set; }
        /// <summary>
        /// Tag der Fütterung.
        /// </summary>
        [Required]
        public DateOnly Tag { get; set; }
        /// <summary>
        /// Uhrzeit der Fütterung
        /// </summary>
        [Required]
        public TimeOnly Uhrzeit { get; set; }
        /// <summary>
        /// True wenn fütterung täglich erfolgen soll
        /// </summary>
        public bool WiederholendeFuetterung { get; set; } = false;
        /// <summary>
        /// Futterautomat der die Fütterungen durchführt
        /// </summary>
        public virtual Futterautomat? Futterautomat { get; set; }
    }
}
