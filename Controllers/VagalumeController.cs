using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using APIVagalume.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIVagalume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class VagalumeController : ControllerBase
    {

        private string _host = "https://api.vagalume.com.br/search.php?";
        private readonly HttpClient _client;

        public VagalumeController()
        {
            _client = new HttpClient();
        }

        [HttpGet("{insertArt}/{insertMus}")]
        public ActionResult GetMusicByValue(string insertArt,string insertMus)
        {
            string url = $"{_host}art={insertArt}&mus={insertMus}&apiKey=key";
            var result = _client.GetAsync(url).Result;
            var musica = result.Content.ReadAsAsync<Musicas>().Result;
            return new OkObjectResult(musica);
        }
    }
}
