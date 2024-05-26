using Database.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Reflection.Metadata.Ecma335;
using WebAPI_App.Repository;

namespace WebAPI_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LendetController : ControllerBase
    {
        private readonly ILogger<LendetController> _logger;
        private readonly IRepository<Lendet> _repository;
        public LendetController(ILogger<LendetController> logger, IRepository<Lendet> respository)
        {
            _logger = logger;
            _repository = respository;
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

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<Lendet> MerrLenden(int id, CancellationToken token)
        {
            return await _repository.Get(id, token);
        }

        
            
     }
}
