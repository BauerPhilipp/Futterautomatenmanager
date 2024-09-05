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

            List<FutterautomatwerteForAPI> futterautomaten = new List<FutterautomatwerteForAPI>();
            if (dbFutterautomaten is null)
            {
                return BadRequest("Keine Futterautomaten vorhanden");
            }

            foreach (var automat in dbFutterautomaten)
            {
                FutterautomatwerteForAPI output;
                try
                {
                    output = new FutterautomatwerteForAPI(automat);
                }
                catch (Exception ex)
                {
                    return BadRequest($"Fehler beim Einlesen der Futterautomaten. Ein benötiger Wert wurde nicht gesetzt! Fehler: {ex.Message}.\nHaben alle Futterautomaten eine Bezeichung?");
                }
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
                .FirstOrDefault(f => f.Bezeichnung.ToLower() == bezeichnungFutterautomat.ToLower());
            if (futterautomat is null) return BadRequest("Kein Futterautomat mit diesem Namen vorhanden!");
            FutterautomatwerteForAPI output;
            try
            {
                output = new FutterautomatwerteForAPI(futterautomat);
            }
            catch (Exception ex)
            {
                return BadRequest($"Fehler beim Einlesen der Futterautomaten. Ein benötiger Wert wurde nicht gesetzt! Fehler: {ex.Message}");
            }

            return Ok(output);
        }
    }
}
