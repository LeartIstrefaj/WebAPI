using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebAPI_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LendetController : ControllerBase
    {
        private readonly ILogger<LendetController> _logger;
        public LendetController(ILogger<LendetController> logger)
        {
            _logger = logger;
        }

        //[HttpGet("[action]")]
        //public string GetTest()
        //{
        //    _logger.LogInformation("testi i pare");
        //    return "Testi 1";
        //}

        [HttpGet("[action]")]
        public TestKlasa GetTest()
        {
            _logger.LogInformation("testi i pare");

            var obj = new TestKlasa();
            obj.Mosha = 21;
            obj.Emri = "Leart";

            return obj;
        }

        public TestKlasa PostTest()
        {
            _logger.LogInformation("testi i pare si POST");

            var obj = new TestKlasa();
            obj.Mosha = 19;
            obj.Emri = "John";

            return obj;   
        }

        
            
     }
}
