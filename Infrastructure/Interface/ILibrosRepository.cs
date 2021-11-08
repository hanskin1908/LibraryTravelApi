using Infrastructure.Data;

using System.Collections.Generic;

namespace Infrastructure.Interface
{
    public interface ILibrosRepository
    {
        IEnumerable<Libro> GetLibros();
        Libro GetLibro(int id);
        Libro CreateLibro(Libro libros);
        Libro UpdateLibro(Libro libros);
        void DeleteLibro(int Id);
    }
}
