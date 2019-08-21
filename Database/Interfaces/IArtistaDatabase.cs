using APIVagalume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVagalume.Database.Interfaces
{
    public interface IArtistaDatabase
    {
        ICollection<Artista> Get();
        string Save(Artista artista);
        string Update(Artista artista);
        string Delete(string id);
    }
}
