using FutterautomatenDatenbank.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Methoden für Aquarien
namespace FutterautomatenDatenbank.Models
{
    public partial class FutterautomatenEFCoreRepository
    {
        public void AddAquarium(Aquarium aquarium)
        {
            using var db = contextFactory.CreateDbContext();
            db.Aquarien.Add(aquarium);
            db.SaveChanges();
        }

        public Aquarium GetAquarium(int id)
        {
            using var db = contextFactory.CreateDbContext();
            return db.Aquarien.Find(id);
        }

        public List<Aquarium> GetAquarien()
        {
            using var db = contextFactory.CreateDbContext();
            return db.Aquarien.ToList();
        }

        public void UpdateAquarium(Aquarium aquarium)
        {

            if (aquarium == null) throw new ArgumentException(nameof(aquarium));

            using var db = this.contextFactory.CreateDbContext();

            var aquariumToUpdate = db.Aquarien.Find(aquarium.AquariumId);

            if (aquariumToUpdate is not null)
            {
                aquariumToUpdate.Name = aquarium.Name;
                aquariumToUpdate.Futterautomaten = aquarium.Futterautomaten;
                aquariumToUpdate.Aufstellort = aquarium.Aufstellort;
                db.SaveChanges();
            }
        }

        public void DeleteAquarium(int id)
        {
            using var db = contextFactory.CreateDbContext();

            var aquarium = db.Aquarien.Find(id);
            if (aquarium is null) return;

            db.Aquarien.Remove(aquarium);

            db.SaveChanges();
        }
    }
}
