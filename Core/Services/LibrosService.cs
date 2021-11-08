
using Core.Interface;

using Core.ViewModels;
using Infrastructure.Data;
using Infrastructure.Interface;
using System.Collections.Generic;

namespace Core.Services
{
    public class LibrosService : ILibrosService
    {
        public ILibrosRepository librosRepository;
        public LibrosService(ILibrosRepository librosRepository)
        {
            this.librosRepository = librosRepository;
        }

        public Libro CreateLibro(Libro libros)
        {
            return this.librosRepository.CreateLibro(libros);
        }

        public void DeleteLibro(int id)
        {
            this.librosRepository.DeleteLibro(id);
        }

        public Libro GetLibro(int id)
        {
            return this.librosRepository.GetLibro(id);
        }

        public IEnumerable<Libro> GetLibros()
        {
            return  this.librosRepository.GetLibros();
        }

        public Libro UpdateLibro(Libro libros)
        {
            return this.librosRepository.UpdateLibro(libros);
        }
    }
}
