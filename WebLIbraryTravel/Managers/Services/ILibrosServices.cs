

using System.Threading.Tasks;
using WebLIbraryTravel.Models;

namespace WebLIbraryTravel.Managers.Services
{
    public interface ILibrosServices
    {
        public Task<Response<Libro>> GetAll();
        public Task<Response<Libro>> GetDetails(int id);
    }
}
