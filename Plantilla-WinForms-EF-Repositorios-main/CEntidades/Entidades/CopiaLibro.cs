using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class CopiaLibro
    {
        public int IdCopiaLibro { get; set; }


        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public Libro Libro { get; set; } //Propiedad de navegación
    
        public ICollection<Prestamo> Prestamos { get; set; }
    }
}
