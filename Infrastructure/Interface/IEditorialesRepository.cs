using Infrastructure.Data;

using System.Collections.Generic;
namespace Infrastructure.Interface
{
    public interface IEditorialesRepository
    {
        IEnumerable<Editoriale> GetEditoriales();
        IEnumerable<Editoriale> GetEditorialesAll();
        Editoriale GetEditorial(int editorialeId);
        Editoriale CreateEditoriales(Editoriale editoriales);
        void DeleteEditoriales(int id);
        Editoriale UpdateEditoriales(Editoriale editoriales);
    }
}
