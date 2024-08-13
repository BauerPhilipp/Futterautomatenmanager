using FutterautomatenDatenbank.Models;

namespace Futterautomatenmanager.Models.APIModels
{
    public struct FuetterungForAPI
    {
        public string Datum { get; set; }
        public string Uhrzeit { get; set; }
        /// <summary>
        /// Erstellt ein neues Objekt mit den Daten einer Fütterung
        /// </summary>
        /// <param name="fuetterung"></param>
        public FuetterungForAPI(Fuetterung fuetterung)
        {
            Datum = fuetterung.Tag.ToString();
            Uhrzeit = fuetterung.Uhrzeit.ToString();
        }
    }
}
