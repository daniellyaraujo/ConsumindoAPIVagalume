using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace APIVagalume.Models
{
    public class Musics
    {
        public string type { get; set; }
        public Artista art { get; set; }
        public ICollection<Mus> mus { get; set; }   
       
    }

    public class Musicas
    {
        public Musicas()
        {
            mus = new Collection<Mus2>();
        }
        public string type { get; set; }
        public Artista art { get; set; }
        public ICollection<Mus2> mus { get; set; }

    }

}