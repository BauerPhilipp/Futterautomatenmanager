using FutterautomatenDatenbank.Migrations;
using FutterautomatenDatenbank.Models;

namespace Futterautomatenmanager.Models.APIModels
{
    public struct FuetterungForAPI
    {
        public string Datum { get; set; }
        public string Uhrzeit { get; set; }
        public float futterMenge {  get; set; }

        public bool WiederholendeFuetterung { get; set; }
        /// <summary>
        /// Erstellt ein neues Objekt mit den Daten einer Fütterung
        /// </summary>
        /// <param name="fuetterung"></param>
        public FuetterungForAPI(Fuetterung fuetterung)
        {
            Datum = fuetterung.Tag.ToString();
            Uhrzeit = fuetterung.Uhrzeit.ToString();
            futterMenge = fuetterung.Futtermenge;
            WiederholendeFuetterung = fuetterung.WiederholendeFuetterung;
        }
    }
}
