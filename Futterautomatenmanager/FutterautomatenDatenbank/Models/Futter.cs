﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Models
{
    public class Futter
    {
        public int FutterId { get; set; }

        [Required]
        public float Packungsinhalt { get; set; }
        public string FutterName { get; set; } = string.Empty;
        public string Beschreibung { get; set; } = string.Empty;

        public virtual ICollection<Futterautomat>? Futterautomaten { get; set; } = new List<Futterautomat>();
    }
}
