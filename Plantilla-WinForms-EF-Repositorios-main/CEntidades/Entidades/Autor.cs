using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Autor
    {
        public string IdAutor { get; set; }
        public string Biografia { get; set; }
        public int CantidadLibrosEscritos { get; set; }
        public Persona Persona { get; set; }

    }
}
