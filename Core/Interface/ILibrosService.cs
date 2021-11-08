
using Infrastructure.Data;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core.Interface
{
    public interface ILibrosService
    {
        IEnumerable<Libro> GetLibros();
        Libro GetLibro(int id);
        Libro CreateLibro(Libro libros);
        Libro UpdateLibro(Libro libros);
        void DeleteLibro(int id);
    }
}
