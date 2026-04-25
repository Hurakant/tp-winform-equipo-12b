using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public List<string> Imagenes { get; set; }
        public List<Imagen> Imagen { get; set; }
        public decimal Precio { get; set; }

        public Articulo()
        {
            Imagenes = new List<string>(); //Inicializar para evitar basura
            //Aqui puse esta para no romper todo y poder y cambiando gradualmente
            Imagen = new List<Imagen>();
        }
    }
}
