using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVagalume.Models
{
    public class Musicas
    {
        public string type { get; set; }
        public Artista art { get; set; }
        public ICollection<Mus> mus { get; set; }
        
       
    }
}