


using Infrastructure.Data;
using Infrastructure.Interface;

namespace Core.Services
{
    public class AutoresLibrosService : IAutor_Has_LibrosRepository
    {
        public IAutor_Has_LibrosRepository autor_Has_LibrosRepository;
        public AutoresLibrosService(IAutor_Has_LibrosRepository autor_Has_LibrosRepository)
        {
            this.autor_Has_LibrosRepository = autor_Has_LibrosRepository;
        }
        public AutoresHasLibro CreateAutor_Libro(int AutorId, int ISBN)
        {
            return this.autor_Has_LibrosRepository.CreateAutor_Libro(AutorId, ISBN);
        }
    }
}
