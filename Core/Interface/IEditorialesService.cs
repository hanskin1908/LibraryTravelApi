
using Infrastructure.Data;
using Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IEditorialesService
    {
        EditorialesViewModel GetEditoriales();
        IEnumerable<Editoriale> GetEditorialesAll();
        Editoriale GetEditorial(int EditorialeId);
        Editoriale CreateEditoriales(Editoriale editoriales);
        Editoriale UpdateEditoriales(Editoriale editoriales);
        void DeleteEditoriales(int id);
    }
}
