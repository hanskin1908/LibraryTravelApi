

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Infrastructure.Interface;

namespace Infrastructure.Repositories { 
    public class LibrosRepository : ILibrosRepository
    {
        public Library_Browser_TravelContext context;
        public LibrosRepository(Library_Browser_TravelContext context)
        {
            this.context = context;
        }
        public IEnumerable<Libro> GetLibros()
        {
            return context.Libros;
        }
        public Libro GetLibro(int id)
        {
            return  context.Libros.Where(x => x.Isbn == id).FirstOrDefault();
        }
        public Libro CreateLibro(Libro libros)
        {
            context.Libros.Add(libros);
            context.SaveChanges();
            return libros;
        }
        public Libro UpdateLibro(Libro libros)
        {
            context.Entry(libros).State = EntityState.Modified;
            context.SaveChanges();
            return libros;
        }
        public void DeleteLibro(int Id)
        {
            Libro libros = new Libro();
            libros = context.Libros.Where(x => x.Isbn== Id).FirstOrDefault();
            context.Libros.Remove(libros);
            context.SaveChanges();
        }

       

     
    }
}
