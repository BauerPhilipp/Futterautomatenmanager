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
        /// <summary>
        /// Fügt eine Person der Datenbank hinzu
        /// </summary>
        /// <param name="person">Die hinzuzufügende Person</param>
        public void AddPerson(Person person)
        {
            using var db = this.contextFactory.CreateDbContext();
            db.Personen.Add(person);
            db.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">Id der gewünschten Person</param>
        /// <returns></returns>
        public Person GetPerson(int id)
        {
            using var db = this.contextFactory.CreateDbContext();
            return db.Personen.Find(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Liste mit verfügbaren Personen</returns>
        public List<Person> GetPersonen()
        {
            using var db = this.contextFactory.CreateDbContext();
            return db.Personen.ToList();
        }

        /// <summary>
        /// Aktualisiert eine Person
        /// </summary>
        /// <param name="id">Die Id der zu Aktualisierenden Person</param>
        /// <param name="person">Die Daten mit welchen die Person aktualisiert wird</param>
        /// <exception cref="ArgumentException"></exception>
        public void UpdatePerson(int id, Person person)
        {
            if (person == null) throw new ArgumentException(nameof(person));
            if (id != person.PersonId) return;

            using var db = this.contextFactory.CreateDbContext();

            var personToUpdate = db.Personen.Find(id);

            if (personToUpdate is not null)
            {
                personToUpdate.Name = person.Name;
                personToUpdate.Futterautomaten = person.Futterautomaten;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Entfernt eine Person aus der Datenbank
        /// </summary>
        /// <param name="id"></param>
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



