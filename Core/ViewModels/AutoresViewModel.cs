﻿

using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class AutoresViewModel
    {
        public IEnumerable<Autore> Autores { get; set; }
    }
}
