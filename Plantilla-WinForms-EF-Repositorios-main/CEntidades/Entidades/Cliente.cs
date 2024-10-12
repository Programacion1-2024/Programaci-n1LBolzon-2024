using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades.Entidades
{
    public class Cliente
    {
       
        public int IdCliente { get; set; }
        public bool TieneMembrecia {  get; set; }
        public bool PagaIva {  get; set; }
        public Persona Persona { get; set; }
        public ICollection<Prestamo> Prestamos { get; set; }
        public ICollection<Venta> Ventas { get; set; }

    }
}
