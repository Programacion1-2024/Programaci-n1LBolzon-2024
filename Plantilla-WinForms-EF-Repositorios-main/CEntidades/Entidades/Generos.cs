﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Generos
    {
        public int IdGenero { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public ICollection<Libro> Libros { get; set; }

    }
}
