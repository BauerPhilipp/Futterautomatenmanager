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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        public virtual DbSet<Aquarium> Aquarien { get; set; }
        public virtual DbSet<Fuetterung> Fuetterungen { get; set; }
        public virtual DbSet<Futter> FutterArt { get; set; }
        public virtual DbSet<Futterautomat> Futterautomaten { get; set; }
        public virtual DbSet<Person> Personen { get; set; }



    }
}
