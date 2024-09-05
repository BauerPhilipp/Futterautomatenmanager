using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    /// <summary>
    /// In einem Aquarium werden diverse Futterautomaten integriert
    /// </summary>
    public class Aquarium
    {
        /// <summary>
        /// Eindeutige ID des Aquariums
        /// </summary>
        public int AquariumId { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [Required]
        public string? Name { get; set; }
        /// <summary>
        /// Aufstellort
        /// </summary>
        public string Aufstellort { get; set; } = string.Empty;
        /// <summary>
        /// Größe in Textform
        /// </summary>
        public string Groeße { get; set; } = string.Empty;
        /// <summary>
        /// Im Aquarium installierte Futterautomaten
        /// </summary>
        public virtual ICollection<Futterautomat>? Futterautomaten { get; set; } = new List<Futterautomat>();
    }
}
