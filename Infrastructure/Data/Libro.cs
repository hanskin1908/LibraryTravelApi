using System;
using System.Collections.Generic;

#nullable disable

namespace Infrastructure.Data
{
    public partial class Libro
    {
     

        public int Isbn { get; set; }
        public int? EditorialesId { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string NPaginas { get; set; }


    }
}
