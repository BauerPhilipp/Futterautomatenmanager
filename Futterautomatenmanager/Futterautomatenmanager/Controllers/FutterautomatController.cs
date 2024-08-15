using FutterautomatenDatenbank.Migrations;
using FutterautomatenDatenbank.Models;
using Futterautomatenmanager.Models.APIModels;
using Microsoft.AspNetCore.Mvc;

namespace Futterautomatenmanager.Controllers
{
    /// <summary>
    /// API für die abfrage von Futterautomaten.
    /// </summary>
    [ApiController]
    [Route("/api/[controller]")]
    public class FutterautomatController : ControllerBase
    {
        public IFutterautomatenEFCoreRepository FutterautomatenEFCoreRepository { get; }

        public FutterautomatController(IFutterautomatenEFCoreRepository FutterautomatenEFCoreRepository)
        {
            this.FutterautomatenEFCoreRepository = FutterautomatenEFCoreRepository;
        }
        /// <summary>
        /// Gibt alle verfügbaren Futterautomaten als Json aus.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllFutterautomaten()
        {
            var dbFutterautomaten = FutterautomatenEFCoreRepository.GetFutterautomaten();
            ////Fehlerhaft da die Objekte sich immer gegenseitig referenzieren!
            //var output = new Futterautomat()
            //{
            //    FutterautomatId = futterautomat.FutterautomatId,
            //    Aquarium = futterautomat.Aquarium,
            //    Bezeichnung = futterautomat.Bezeichnung,
            //    Fuetterungen = futterautomat.Fuetterungen,
            //    Futter = futterautomat.Futter,
            //    FutterFaktor = futterautomat.FutterFaktor,
            //    Person = futterautomat.Person,
            //};

            List<FutterautomatwerteForAPI> futterautomaten = new List<FutterautomatwerteForAPI>();
            if (dbFutterautomaten is null)
            {
                return BadRequest("Keine Futterautomaten vorhanden");
            }
            foreach (var automat in dbFutterautomaten)
            {
                var output = new FutterautomatwerteForAPI(automat);
                futterautomaten.Add(output);
            }

            return Ok(futterautomaten);
        }

        /// <summary>
        /// Ausgabe eines ausgewählten Futterautomaten
        /// </summary>
        /// <param name="bezeichnungFutterautomat">Der Name des Futterautomaten welcher in der App festgelegt wurde</param>
        /// <returns></returns>
        [HttpGet("{bezeichnungFutterautomat}")]
        public IActionResult GetFutterautomaten(string bezeichnungFutterautomat)
        {

            var futterautomat = FutterautomatenEFCoreRepository.GetFutterautomaten()
                .Where(f => f.Bezeichnung == bezeichnungFutterautomat).FirstOrDefault();
            var output = new FutterautomatwerteForAPI(futterautomat);

            return Ok(output);
        }
    }
}
