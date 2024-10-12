using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Persona
    {
        /*[ForeignKey("Empleado")]
        public int EmpleadoId { get; set; }  // Aquí defines la clave foránea

        [ForeignKey("Cliente")]
        */
        
        public int IdPersona { get; set; } 
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public long Dni { get; set;}
        public string Telefono { get; set;}
        public string Direccion { get; set;}
        public string Email { get; set; }
        public Autor ? Autor {  get; set; }
        public Cliente ? Cliente { get; set; }
        public Empleado ? Empleado { get; set; }
        public ICollection<Prestamo> Prestamos { get; set; } // Relación uno a muchos

    }
}
