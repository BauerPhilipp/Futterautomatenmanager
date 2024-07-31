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

        public void UpdateAquarium(int id, Aquarium aquarium)
        {
            throw new NotImplementedException();
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
