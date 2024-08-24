using FutterautomatenDatenbank.Models;

namespace Futterautomatenmanager.Models.APIModels
{
    public struct FutterautomatwerteForAPI
    {
        public int FutterautomatId { get; set; }
        public string BezeichnungFutterautomat { get; set; }

        public float FutterFaktor { get; set; }
        public string futterName { get; set; }
        public string personName { get; set; }
        public string aquariumName { get; set; }
        public bool ManuelleFuetterung { get; set; }
        public List<FuetterungForAPI> fuetterungen { get; set; }

        /// <summary>
        /// erstellt ein neues objekt mit den Daten eines Futterautomaten
        /// </summary>
        /// <param name="futterautomat"></param>
        public FutterautomatwerteForAPI(Futterautomat futterautomat)
        {
            FutterautomatId = futterautomat.FutterautomatId;
            BezeichnungFutterautomat = futterautomat.Bezeichnung;
            FutterFaktor = futterautomat.FutterFaktor;
            futterName = futterautomat.Futter.FutterName;
            personName = futterautomat.Person.Name;
            aquariumName = futterautomat.Aquarium.Name;
            ManuelleFuetterung = futterautomat.ManuelleFuetterung;

            fuetterungen = new List<FuetterungForAPI>();
            foreach (var f in futterautomat.Fuetterungen)
            {
                fuetterungen.Add(new FuetterungForAPI(f));
            }
        }
    }
}
