using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    /// <summary>
    /// Stellt den Benutzer des Futterautomaten dar
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Eindeutige ID
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// Bezeichnung des Benutzers
        /// </summary>
        public string Name { get; set; } = string.Empty;   
        /// <summary>
        /// Futterautomaten die diese Person erstellt hat
        /// </summary>
        public virtual ICollection<Futterautomat>? Futterautomaten { get; set; }
    }
}
