using System.Collections.Generic;
using VagalumeModelos.Models;

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
