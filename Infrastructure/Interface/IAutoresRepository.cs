using Infrastructure.Data;

using System.Collections.Generic;
namespace Infrastructure.Interface
{
    public interface IAutoresRepository
    {
        IEnumerable<Autore> GetAutores();
        IEnumerable<Autore >GetAutoresAll();
        Autore CreateAutores(Autore autores);
        void DeleteAutor(int id);
        Autore GetAutor(int id);
        Autore UpdateAutores(Autore autores);
    }
}
