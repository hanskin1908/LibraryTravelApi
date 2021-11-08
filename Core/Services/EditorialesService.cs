
using Core.Interface;

using Core.ViewModels;
using Infrastructure.Data;
using Infrastructure.Interface;
using System.Collections.Generic;

namespace Core.Services
{
    public class EditorialesService : IEditorialesService
    {
        public IEditorialesRepository editorialesRepository;
        public EditorialesService(IEditorialesRepository editorialesRepository)
        {
            this.editorialesRepository = editorialesRepository;
        }

        public Editoriale CreateEditoriales(Editoriale editoriales)
        {
            return this.editorialesRepository.CreateEditoriales(editoriales);
        }

        public void DeleteEditoriales(int id)
        {
            this.editorialesRepository.DeleteEditoriales(id);
        }

        public Editoriale GetEditorial(int EditorialeId)
        {
            return editorialesRepository.GetEditorial(EditorialeId);
        }

        public EditorialesViewModel GetEditoriales()
        {
            return new EditorialesViewModel()
            {
                Editoriales = editorialesRepository.GetEditoriales()
            };
        }

        public IEnumerable<Editoriale> GetEditorialesAll()
        {
            return editorialesRepository.GetEditorialesAll();
        }

        public Editoriale UpdateEditoriales(Editoriale editoriales)
        {
            return this.editorialesRepository.UpdateEditoriales(editoriales);
        }
    }
}
