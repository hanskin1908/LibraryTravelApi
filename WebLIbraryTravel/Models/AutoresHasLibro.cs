using System;
using System.Collections.Generic;
using WebLIbraryTravel.Models;

#nullable disable
namespace WebLIbraryTravel.Models
{
    public partial class AutoresHasLibro
    {
        public int AutoresId { get; set; }
        public int LibrosIsbn { get; set; }

        public virtual Autore Autores { get; set; }
        public virtual Libro LibrosIsbnNavigation { get; set; }
    }
}
