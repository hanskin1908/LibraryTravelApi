
using Infrastructure.Data;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{ 
    public class AutoresRepository : IAutoresRepository
    {
        public Library_Browser_TravelContext context;
        public AutoresRepository(Library_Browser_TravelContext context)
        {
            this.context = context;
        }

        public Autore CreateAutores(Autore autores)
        {
            context.Autores.Add(autores);
            context.SaveChanges();
            return autores;
        }

        public void DeleteAutor(int id)
        {
            Autore autores = new Autore();
            autores = context.Autores.Where(x => x.Id == id).FirstOrDefault();
            context.Autores.Remove(autores);
            context.SaveChanges();
        }

        public Autore GetAutor(int id)
        {
            return context.Autores.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Autore> GetAutores()
        {
            return context.Autores;
        }

        public IEnumerable<Autore> GetAutoresAll()
        {
            return context.Autores;
        }

        public Autore UpdateAutores(Autore autores)
        {
            context.Entry(autores).State = EntityState.Modified;
            context.SaveChanges();
            return autores;
        }
    }
}
