using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Empleado
    {
        public int IdEmpleado {  get; set; }
        public double sueldo {  get; set; }
        public string Puesto { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Persona Persona { get; set; }

    }
}
