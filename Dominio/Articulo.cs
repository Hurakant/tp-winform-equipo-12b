using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        //Cosas que tiene el articulo, lo de imagen se debe cambiar y hacer un objeto imagen
        // para poder hacerlo un array, supongo
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int Categoria { get; set; } // el tipo e dato va como CATEGORIA EN VEZ DE int
        public string Imagen { get; set; } // el tipo e dato va como  IMAGEN EN VEZ DE STRING
        public decimal Precio { get; set; }
    }
}
