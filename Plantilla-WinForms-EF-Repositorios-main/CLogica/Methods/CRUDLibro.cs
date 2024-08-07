using CDatos.Contexts;
using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogica.Methods
{
    public class CRUDLibro
    {
        public LibreriaContext context = new LibreriaContext();
        public void AgregarLibro(Libro libro)
        {
            Libro libroNuevo = new Libro();
            
            libroNuevo.Isbn = libro.Isbn;
            libroNuevo.Descripcion = libro.Descripcion;
            libroNuevo.AnioPublicacion = libro.AnioPublicacion;
            libroNuevo.Titulo = libro.Titulo;

        }
    }
}
