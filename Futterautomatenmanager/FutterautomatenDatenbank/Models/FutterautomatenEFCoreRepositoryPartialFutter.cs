﻿using FutterautomatenDatenbank.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Methoden für Futter
namespace FutterautomatenDatenbank.Models
{
    public partial class FutterautomatenEFCoreRepository
    {
        public void AddFutter(Futter futter)
        {
            using var db = this.contextFactory.CreateDbContext();
            db.FutterArt.Add(futter);
            db.SaveChanges();
        }

        public Futter GetFutter(int id)
        {
            using var db = this.contextFactory.CreateDbContext();
            return db.FutterArt.Find(id);
        }

        public List<Futter> GetFutter()
        {
            using var db = this.contextFactory.CreateDbContext();
            return db.FutterArt.ToList();
        }

        public void UpdateFutter(int id, Futter futter)
        {
            throw new NotImplementedException();
        }

        public void DeleteFutter(int id)
        {
            using var db = this.contextFactory.CreateDbContext();

            var futter = db.FutterArt.Find(id);
            if (futter is null) return;

            db.FutterArt.Remove(futter);

            db.SaveChanges();
        }
    }
}
