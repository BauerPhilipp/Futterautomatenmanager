using FutterautomatenDatenbank.Models;

namespace Futterautomatenmanager.Models.APIModels
{
    public struct FuetterungForAPI
    {
        public string Datum { get; set; }
        public string Uhrzeit { get; set; }
        public FuetterungForAPI(Fuetterung fuetterung)
        {
            Datum = fuetterung.Tag.ToString();
            Uhrzeit = fuetterung.Uhrzeit.ToString();
        }
    }
}
