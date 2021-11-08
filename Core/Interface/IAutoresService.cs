
using Core.ViewModels;
using Infrastructure.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Core.Interface
{
    public interface IAutoresService
    {
        AutoresViewModel GetAutores();
        IEnumerable<Autore> GetAutoresAll();
        Autore GetAutor(int id);
        Autore CreateAutores(Autore autores);
        Autore UpdateAutores(Autore autores);
        void DeleteAutor(int id);
    }
}
