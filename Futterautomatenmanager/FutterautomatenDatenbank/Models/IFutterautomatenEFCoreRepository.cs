
namespace FutterautomatenDatenbank.Models
{
    /// <summary>
    /// Stellt diverse Methoden zum abfragen, updaten und hinzufügen von Elementen in die Datenbank
    /// zur ferfügung
    /// </summary>
    public interface IFutterautomatenEFCoreRepository
    {
        /// <summary>
        /// Einen Futterautomaten zur Datenbank hinzufügen
        /// </summary>
        /// <param name="futterautomat"></param>
        void AddFutterautomat(Futterautomat futterautomat);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">ID des Aquariums</param>
        /// <returns>Eine Liste mit den im Aquarium eingebauten Futterautomaten</returns>
        List<Futterautomat> GetFutterautomatenByAquarium(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Eine Liste mit allen Futterautomaten</returns>
        List<Futterautomat> GetFutterautomaten();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">ID des gesuchten Futterautomaten</param>
        /// <returns>Gibt einen einzelnen Futterautomaten zurück</returns>
        Futterautomat GetFutterautomat(int id);
        /// <summary>
        /// Aktualisiert den angegebenen Futterautomaten
        /// </summary>
        /// <param name="id"></param>
        /// <param name="futterautomat"></param>
        void UpdateFutterautomat(int id, Futterautomat futterautomat);
        /// <summary>
        /// Löscht den Futterautomaten entsprechend der ID
        /// </summary>
        /// <param name="id"></param>
        void DeleteFutterautomat(int id);

        /// <summary>
        /// Ein Aquarium der Datenbank hinzufügen
        /// </summary>
        /// <param name="aquarium"></param>
        void AddAquarium(Aquarium aquarium);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Ein der ID entsprechendes Aquarium</returns>
        Aquarium GetAquarium(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Eine Liste aller verfügbaren Aquarien</returns>
        List<Aquarium> GetAquarien();
        /// <summary>
        /// Aktualisiert das übergebene Aquarium in der Datenbank
        /// </summary>
        /// <param name="aquarium"></param>
        void UpdateAquarium(Aquarium aquarium);
        /// <summary>
        /// Löscht ein Aquarium mit der entsprechenden ID aus der Datenbank
        /// </summary>
        /// <param name="id"></param>
        void DeleteAquarium(int id);

        /// <summary>
        /// Fügt eine Person der Datenbank hinzu
        /// </summary>
        /// <param name="person"></param>
        void AddPerson(Person person);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Die Person mit der entsprechenden ID</returns>
        Person GetPerson(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Eine Liste mit allen verfügbaren Personen</returns>
        List<Person> GetPersonen();
        /// <summary>
        /// Aktualisiert die übergebene Person
        /// </summary>
        /// <param name="person"></param>
        void UpdatePerson(Person person);
        /// <summary>
        /// Löscht eine der ID entsprechende Person aus der Datenbank
        /// </summary>
        /// <param name="id"></param>
        void DeletePerson(int id);

        /// <summary>
        /// Fügt der Datenbank eine Fütterung hinzu
        /// </summary>
        /// <param name="fuetterung"></param>
        void AddFuetterung(Fuetterung fuetterung);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Die Fütterung mit entsprechender ID</returns>
        Fuetterung GetFuetterung(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Eine Liste mit allen Fütterungen</returns>
        List<Fuetterung> GetFuetterungen();
        /// <summary>
        /// Aktualisiert die übergebene Fütterung
        /// </summary>
        /// <param name="fuetterung"></param>
        void UpdateFuetterung(Fuetterung fuetterung);
        /// <summary>
        /// Löscht die Fütterung mit der passenden ID
        /// </summary>
        /// <param name="id"></param>
        void DeleteFuetterung(int id);

        /// <summary>
        /// Fügt der Datenbank ein Futter hinzu
        /// </summary>
        /// <param name="futter"></param>
        void AddFutter(Futter futter);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Das Futter mit der entsprechenden ID</returns>
        Futter GetFutter(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Liste mit allen Futterarten</returns>
        List<Futter> GetFutter();
        /// <summary>
        /// Aktualisiert ein Futter
        /// </summary>
        /// <param name="futter"></param>
        void UpdateFutter(Futter futter);
        /// <summary>
        /// Löscht das Futter mit der entsprechenden ID
        /// </summary>
        /// <param name="id"></param>
        void DeleteFutter(int id);

    }
}