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
        public ICollection<Translate> translate { get; set; }
    }
}