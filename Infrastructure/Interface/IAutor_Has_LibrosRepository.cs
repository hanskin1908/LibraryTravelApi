using Infrastructure.Data;

using System.Collections.Generic;

namespace   Infrastructure.Interface
{
    public interface IAutor_Has_LibrosRepository
    {
        AutoresHasLibro CreateAutor_Libro(int AutorId, int ISBN);
    }
}
