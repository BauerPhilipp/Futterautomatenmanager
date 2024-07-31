using FutterautomatenDatenbank.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Methoden für Personen
namespace FutterautomatenDatenbank.Models
{
    public partial class FutterautomatenEFCoreRepository
    {

        public void AddPerson(Person person)
        {
            using var db = this.contextFactory.CreateDbContext();
            db.Personen.Add(person);
            db.SaveChanges();
        }

        public Person GetPerson(int id)
        {
            using var db = this.contextFactory.CreateDbContext();
            return db.Personen.Find(id);
        }

        public List<Person> GetPersonen()
        {
            using var db = this.contextFactory.CreateDbContext();
            return db.Personen.ToList();
        }

        public void UpdatePerson(int id, Person person)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            using var db = this.contextFactory.CreateDbContext();

            var person = db.Personen.Find(id);
            if (person is null) return;

            db.Personen.Remove(person);

            db.SaveChanges();
        }
    }
}
