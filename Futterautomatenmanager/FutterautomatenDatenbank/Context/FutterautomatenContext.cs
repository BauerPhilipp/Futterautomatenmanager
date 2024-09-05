using FutterautomatenDatenbank.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Context
{
    /// <summary>
    /// Context für den Zugriff auf die Datenbanktabellen
    /// </summary>
    public class FutterautomatenContext : DbContext
    {
        public FutterautomatenContext(DbContextOptions<FutterautomatenContext> options) : base(options) { }

        //Einrichtung diverser settings
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //zum Debugging
            optionsBuilder.EnableSensitiveDataLogging();
        }
        /// <summary>
        /// Tabelle mit Aquarien
        /// </summary>
        public virtual DbSet<Aquarium> Aquarien { get; set; }
        /// <summary>
        /// Tabelle mit Fuetterungen
        /// </summary>
        public virtual DbSet<Fuetterung> Fuetterungen { get; set; }
        /// <summary>
        /// Tabelle mit Futterarten
        /// </summary>
        public virtual DbSet<Futter> FutterArt { get; set; }
        /// <summary>
        /// Tabelle mit Futterautomaten
        /// </summary>
        public virtual DbSet<Futterautomat> Futterautomaten { get; set; }
        /// <summary>
        /// Tabelle mit Personen
        /// </summary>
        public virtual DbSet<Person> Personen { get; set; }



    }
}
