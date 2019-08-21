using APIVagalume.Models;
using System.Net.Http;

namespace APIVagalume
{
    public class VagamuleService
    {
        private string _host = "https://api.vagalume.com.br/search.php?";
        private readonly HttpClient _client;

        public VagamuleService()
        {
            _client = new HttpClient();
        }
        public Musicas GetMusic(string insertArt, string insertMus)
        {
            string url = $"{_host}art={insertArt}&mus={insertMus}&extra=alb&apiKey=8225b96502a09ad6758f6c4d593b4230s";
            var result = _client.GetAsync(url).Result;
            var musica = result.Content.ReadAsAsync<Musics>().Result;

            var mus = new Musicas();
            mus.art = musica.art;
            mus.type = musica.type;

            foreach (var item in musica.mus)
            {
                var msc = new Mus2();
                msc.Id = item.id;
                msc.Nome = item.name;
                msc.Letra = item.text;
                msc.url = item.url;
                msc.albuns = item.alb;
                mus.mus.Add(msc);
            }

            return mus;
        }
    }
}
