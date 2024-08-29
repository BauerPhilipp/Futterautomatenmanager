﻿
namespace FutterautomatenDatenbank.Models
{
    /// <summary>
    /// Stellt diverse Methoden zum abfragen, updaten und hinzufügen von Elementen in die Datenbank
    /// zur ferfügung
    /// </summary>
    public interface IFutterautomatenEFCoreRepository
    {
        //Futterautomaten
        void AddFutterautomat(Futterautomat futterautomat);
        List<Futterautomat> GetFutterautomatenByAquarium(int id);
        List<Futterautomat> GetFutterautomaten();
        Futterautomat GetFutterautomat(int id);
        void UpdateFutterautomat(int id, Futterautomat futterautomat);
        void DeleteFutterautomat(int id);

        //Aquarien
        void AddAquarium(Aquarium aquarium);
        Aquarium GetAquarium(int id);
        List<Aquarium> GetAquarien();
        void UpdateAquarium(Aquarium aquarium);
        void DeleteAquarium(int id);

        //Personen
        void AddPerson(Person person);
        Person GetPerson(int id);
        List<Person> GetPersonen();
        void UpdatePerson(Person person);
        void DeletePerson(int id);

        //Fütterungen
        void AddFuetterung(Fuetterung fuetterung);
        Fuetterung GetFuetterung(int id);
        List<Fuetterung> GetFuetterungen();
        void UpdateFuetterung(Fuetterung fuetterung);
        void DeleteFuetterung(int id);

        //Futterart
        void AddFutter(Futter futter);
        Futter GetFutter(int id);
        List<Futter> GetFutter();
        void UpdateFutter(Futter futter);
        void DeleteFutter(int id);

    }
}