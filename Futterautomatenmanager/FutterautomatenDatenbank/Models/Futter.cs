using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    /// <summary>
    /// Futter mit Packungsinhalt.
    /// Der Packungsinhalt kann für die Berechnung der Restmenge an Futter im Futterautomaten verwendet werden.
    /// </summary>
    public class Futter
    {
        public int FutterId { get; set; }

        /// <summary>
        /// Angabe des verfügbaren Futters in mm
        /// </summary>
        [Required]
        public float Packungsinhalt { get; set; }
        /// <summary>
        /// Bezeichnung des Futters
        /// </summary>
        public string FutterName { get; set; } = string.Empty;
        /// <summary>
        /// Informationen zum Futter
        /// </summary>
        public string Beschreibung { get; set; } = string.Empty;
        /// <summary>
        /// Futterautomaten in denen das Futter verwendet wird
        /// </summary>
        public virtual ICollection<Futterautomat>? Futterautomaten { get; set; } = new List<Futterautomat>();
    }
}
