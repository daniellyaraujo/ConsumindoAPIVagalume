using Newtonsoft.Json;
using System.Collections.Generic;

namespace APIVagalume.Models
{
    public class Mus
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int lang { get; set; }
        public string text { get; set; }
        //public ICollection<Translate> translate { get; set; }
        public Albuns alb { get; set; }
    }

    public class Mus2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Endpoint")]
        public string url { get; set; }

        [JsonProperty("lang")]
        public int Linguagem { get; set; }

        [JsonProperty("text")]
        public string Letra { get; set; }

        //[JsonProperty("tradução")]
        //public ICollection<Translate> tradução { get; set; }

        [JsonProperty("Albuns")]
        public Albuns albuns { get; set; }
    }
}