


using Infrastructure.Data;
using Infrastructure.Interface;

namespace Infrastructure.Repositories
{
    public class AutoresHasLibrosRepository : IAutor_Has_LibrosRepository
    {
        public Library_Browser_TravelContext context;
        public AutoresHasLibrosRepository(Library_Browser_TravelContext context)
        {
            this.context = context;
        }
        public AutoresHasLibro CreateAutor_Libro(int AutorId, int ISBN)
        {
            AutoresHasLibro autores_Has_Libros = new AutoresHasLibro();
            autores_Has_Libros.AutoresId = AutorId;
            autores_Has_Libros.LibrosIsbn = ISBN;
            context.AutoresHasLibros.Add(autores_Has_Libros);
            context.SaveChanges();
            return autores_Has_Libros;
        }
    }
}
