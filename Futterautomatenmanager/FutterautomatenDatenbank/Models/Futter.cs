using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    internal class Futter
    {
        public int FutterId { get; set; }

        [Required]
        public float Packungsinhalt { get; set; }
        public string FutterName { get; set; } = string.Empty;
        public string Beschreibung { get; set; } = string.Empty;
    }
}
