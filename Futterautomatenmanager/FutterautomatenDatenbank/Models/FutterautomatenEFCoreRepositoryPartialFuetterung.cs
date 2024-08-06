using FutterautomatenDatenbank.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Methoden für Fütterungen
namespace FutterautomatenDatenbank.Models
{
    public partial class FutterautomatenEFCoreRepository
    {

        public void AddFuetterung(Fuetterung fuetterung)
        {
            using var db = contextFactory.CreateDbContext();
            db.Fuetterungen.Add(fuetterung);
            db.SaveChanges();
        }

        public Fuetterung GetFuetterung(int id)
        {
            using var db = contextFactory.CreateDbContext();
            return db.Fuetterungen.Find(id);
        }

        public List<Fuetterung> GetFuetterungen()
        {
            using var db = contextFactory.CreateDbContext();
            return db.Fuetterungen.ToList();
        }

        public void UpdateFuetterung(Fuetterung fuetterung)
        {
            if (fuetterung == null) throw new ArgumentException(nameof(fuetterung));

            using var db = this.contextFactory.CreateDbContext();

            var fuetterungToUpdate = db.Fuetterungen.Find(fuetterung.FuetterungId);

            if (fuetterungToUpdate is not null)
            {
                fuetterungToUpdate.Futtermenge = fuetterung.Futtermenge;
                fuetterungToUpdate.Futterautomat = fuetterung.Futterautomat;
                fuetterungToUpdate.Tag = fuetterung.Tag;
                fuetterungToUpdate.Uhrzeit = fuetterung.Uhrzeit;
                db.SaveChanges();
            }
        }

        public void DeleteFuetterung(int id)
        {
            using var db = contextFactory.CreateDbContext();

            var fuetterung = db.Fuetterungen.Find(id);
            if (fuetterung is null) return;

            db.Fuetterungen.Remove(fuetterung);

            db.SaveChanges();
        }
    }
}
