using FutterautomatenDatenbank.Models;
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

            var output = new Futterautomat()
            {
                Aquarium = new Aquarium() { Name = "nicht aus Datenbank"}
            };

            return Ok(output);
        }
    }
}
