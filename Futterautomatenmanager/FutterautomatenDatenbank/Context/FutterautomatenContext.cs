using FutterautomatenDatenbank.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutterautomatenDatenbank.Context
{
    internal class FutterautomatenContext : DbContext
    {
        public FutterautomatenContext(DbContextOptions<FutterautomatenContext> options) : base(options) { }

        public virtual DbSet<Aquarium> Aquarien { get; set; }
        public virtual DbSet<Fuetterung> Fuetterungen { get; set; }
        public virtual DbSet<Futter> FutterArt { get; set; }
        public virtual DbSet<Futterautomat> Futterautomaten { get; set; }
        public virtual DbSet<Person> Personen { get; set; }



    }
}
