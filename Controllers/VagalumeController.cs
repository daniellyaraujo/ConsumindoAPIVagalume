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
            var mus3 = new VagamuleService();
            var results = mus3.GetMusic(insertArt, insertMus);
            return new OkObjectResult(results);
        }
    }
}
