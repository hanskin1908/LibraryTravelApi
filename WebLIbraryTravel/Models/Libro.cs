using System;
using System.Collections.Generic;

#nullable disable
namespace WebLIbraryTravel.Models
{
    public partial class Libro
    {
        public Libro()
        {
            AutoresHasLibros = new HashSet<AutoresHasLibro>();
        }

        public int Isbn { get; set; }
        public int? EditorialesId { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string NPaginas { get; set; }

        public virtual Editoriale Editoriales { get; set; }
        public virtual ICollection<AutoresHasLibro> AutoresHasLibros { get; set; }
    }
}
