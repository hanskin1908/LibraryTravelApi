using Infrastructure.Data;
using Infrastructure.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class EditorialesRepository : IEditorialesRepository
    {
        public Library_Browser_TravelContext context;
        public EditorialesRepository(Library_Browser_TravelContext context)
        {
            this.context = context;
        }

        public Editoriale CreateEditoriales(Editoriale editoriales)
        {
            context.Editoriales.Add(editoriales);
            context.SaveChanges();
            return editoriales;
        }

        public void DeleteEditoriales(int id)
        {
            Editoriale editoriales = new Editoriale();
            editoriales = context.Editoriales.Where(x => x.Id == id).FirstOrDefault();
            context.Editoriales.Remove(editoriales);
            context.SaveChanges();
        }

        public Editoriale GetEditorial(int editorialeId)
        {
            return context.Editoriales.Where(x => x.Id == editorialeId).FirstOrDefault();
        }

        public IEnumerable<Editoriale> GetEditoriales()
        {
            return context.Editoriales;
        }

        public IEnumerable<Editoriale> GetEditorialesAll()
        {
            return context.Editoriales;
        }

        public Editoriale UpdateEditoriales(Editoriale editoriales)
        {
            context.Entry(editoriales).State = EntityState.Modified;
            context.SaveChanges();
            return editoriales;
        }
    }
}
