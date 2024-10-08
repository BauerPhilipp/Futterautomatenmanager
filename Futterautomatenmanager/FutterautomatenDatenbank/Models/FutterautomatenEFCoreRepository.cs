﻿using FutterautomatenDatenbank.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Methoden für Futterautomaten
namespace FutterautomatenDatenbank.Models
{
    public partial class FutterautomatenEFCoreRepository : IFutterautomatenEFCoreRepository
    {
        private readonly IDbContextFactory<FutterautomatenContext> contextFactory;

        public FutterautomatenEFCoreRepository(IDbContextFactory<FutterautomatenContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void AddFutterautomat(Futterautomat futterautomat)
        {
            using var db = this.contextFactory.CreateDbContext();
            db.Futterautomaten.Add(futterautomat);
            db.SaveChanges();
        }

        public void DeleteFutterautomat(int id)
        {
            using var db = this.contextFactory.CreateDbContext();

            var futterautomat = db.Futterautomaten.Find(id);
            if (futterautomat is null) return;

            //löschen der Fütterungen bevor der Futterautomat gelöscht werden kann
            var fuetterungenToRemove = db.Fuetterungen.Where(f => f.Futterautomat.FutterautomatId == id);
            foreach (var fuetterung in fuetterungenToRemove)
            {
                db.Fuetterungen.Remove(fuetterung);
            }

            db.Futterautomaten.Remove(futterautomat);

            db.SaveChanges();
        }

        public List<Futterautomat> GetFutterautomaten()
        {
            using var db = this.contextFactory.CreateDbContext();
            return db.Futterautomaten
                .Include(f => f.Person)
                .Include(f => f.Futter)
                .Include(f => f.Aquarium)
                .Include(f => f.Fuetterungen).ToList();
        }

        public List<Futterautomat> GetFutterautomatenByAquarium(int id)
        {
            using var db = this.contextFactory.CreateDbContext();
            return db.Futterautomaten.Where(a => a.Aquarium.AquariumId == id).ToList();
        }

        public void UpdateFutterautomat(int id, Futterautomat futterautomat)
        {
            if (futterautomat == null) throw new ArgumentException(nameof(futterautomat));
            if (id != futterautomat.FutterautomatId) return;

            using var db = this.contextFactory.CreateDbContext();

            var futterautomatToUpdate = db.Futterautomaten.Find(id);

            if (futterautomatToUpdate is not null)
            {
                futterautomatToUpdate.Bezeichnung = futterautomat.Bezeichnung;
                futterautomatToUpdate.FutterFaktor = futterautomat.FutterFaktor;
                futterautomatToUpdate.Futter = futterautomat.Futter;
                futterautomatToUpdate.Fuetterungen = futterautomat.Fuetterungen;
                futterautomatToUpdate.Aquarium = futterautomat.Aquarium;
                futterautomatToUpdate.Person = futterautomat.Person;
                futterautomatToUpdate.ManuelleFuetterung = futterautomat.ManuelleFuetterung;
                db.SaveChanges();
            }
        }

        public Futterautomat GetFutterautomat(int id)
        {
            using var db = this.contextFactory.CreateDbContext();
            //return db.Futterautomaten.Find(id);

            return db.Futterautomaten
                .Include(f => f.Person)
                .Include(f => f.Futter)
                .Include(f => f.Aquarium)
                .Include(f => f.Fuetterungen).Single(s => s.FutterautomatId == id);
        }
    }
}
