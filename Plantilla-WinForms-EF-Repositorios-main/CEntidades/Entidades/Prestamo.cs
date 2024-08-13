using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int MontoTotal { get; set; }
        public DateTime FechaPrestamos { get; set; }
        public DateTime ? FechaDevolucion { get; set; }
        public bool Estado { get; set; }
        public Cliente Cliente { get; set; }
        public FormaPago FormaPago { get; set; }
        public CopiaLibro CopiaLibro { get; set; }
        public Empleado Empleado { get; set; }

    }
}
