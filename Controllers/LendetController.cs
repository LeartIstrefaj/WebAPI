using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("[action]")]
        public string GetTest()
        {
            _logger.LogInformation("testi i pare");
            return "Testi 1";
        }
    }
}
