

using Core.Interface;
using Core.ViewModels;
using Infrastructure.Data;
using Infrastructure.Interface;
using System.Collections.Generic;

namespace Core.Services
{
    public class AutoresService : IAutoresService
    {
        public IAutoresRepository autoresRepository;
        public AutoresService(IAutoresRepository autoresRepository)
        {
            this.autoresRepository = autoresRepository;
        }

        public Autore CreateAutores(Autore autores)
        {
            return this.autoresRepository.CreateAutores(autores);
        }

        public void DeleteAutor(int id)
        {
            this.autoresRepository.DeleteAutor(id);
        }

        public Autore GetAutor(int id)
        {
            return this.autoresRepository.GetAutor(id);
        }

        public AutoresViewModel GetAutores()
        {
            return new AutoresViewModel()
            {
                Autores = autoresRepository.GetAutores()
            };
        }

        public IEnumerable<Autore> GetAutoresAll()
        {
            return autoresRepository.GetAutoresAll();
        }

        public Autore UpdateAutores(Autore autores)
        {
            return this.autoresRepository.UpdateAutores(autores);
        }
    }
}
