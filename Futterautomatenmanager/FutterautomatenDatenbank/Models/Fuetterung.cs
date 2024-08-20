﻿using System;
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
        public int FuetterungId { get; set; }

        [Required]
        public float Futtermenge { get; set; }

        [Required]
        public DateOnly Tag { get; set; }

        [Required]
        public TimeOnly Uhrzeit { get; set; }
        public bool WiederholendeFuetterung { get; set; } = false;

        public virtual Futterautomat? Futterautomat { get; set; }
    }
}
