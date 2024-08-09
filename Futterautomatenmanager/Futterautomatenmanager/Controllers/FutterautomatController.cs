using FutterautomatenDatenbank.Migrations;
using FutterautomatenDatenbank.Models;
using Futterautomatenmanager.Models.APIModels;
using Microsoft.AspNetCore.Mvc;

namespace Futterautomatenmanager.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class FutterautomatController : ControllerBase
    {
        public IFutterautomatenEFCoreRepository FutterautomatenEFCoreRepository { get; }

        public FutterautomatController(IFutterautomatenEFCoreRepository FutterautomatenEFCoreRepository)
        {
            this.FutterautomatenEFCoreRepository = FutterautomatenEFCoreRepository;
        }

        [HttpGet]
        public IActionResult GetAllFutterautomaten()
        {
            var futterautomat = FutterautomatenEFCoreRepository.GetFutterautomaten().First();
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
            var output = new FutterautomatwerteForAPI(futterautomat);

            return Ok(output);
        }

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
