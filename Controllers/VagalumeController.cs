using APIVagalumeService;
using Microsoft.AspNetCore.Mvc;

namespace APIVagalume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class VagalumeController : ControllerBase
    {    

        public VagalumeController()
        {}

        [HttpGet("{insertArt}/{insertMus}")]
        public ActionResult GetMusicByValue(string insertArt,string insertMus)
        {
            var mus3 = new VagalumeSvc("https://api.vagalume.com.br/search.php?");
            var results = mus3.GetMusicas(insertArt, insertMus);
            return new OkObjectResult(results);
        }

        [HttpGet("{insertArt}")]
        public ActionResult GetArtRel(string insertArt)
        {
            var artnew = new VagalumeSvc("https://api.vagalume.com.br/search.php?");
            var results = artnew.ObterArtRel(insertArt);
            return new OkObjectResult(results);
        }
    }
}