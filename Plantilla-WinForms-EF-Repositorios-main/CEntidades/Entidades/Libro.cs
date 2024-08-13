using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Isbn { get; set; }
        public string Descripcion { get; set; }
        public DateTime AnioPublicacion { get; set; }
        public string Titulo { get; set; }
        public double PrecioVenta { get; set; }
        public Editorial Editorial { get; set; }
        
      
       
    }
}
