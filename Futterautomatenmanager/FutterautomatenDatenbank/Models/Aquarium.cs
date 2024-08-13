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
        public int AquariumId { get; set; }
        [Required]
        public string? Name { get; set; }
        public string Aufstellort { get; set; } = string.Empty;
        public string Groeße { get; set; } = string.Empty;

        public virtual ICollection<Futterautomat>? Futterautomaten { get; set; } = new List<Futterautomat>();
    }
}
