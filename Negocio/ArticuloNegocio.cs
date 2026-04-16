using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> Lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("Server=localhost,1433; Database=CATALOGO_P3_DB; integrated security=false; User Id=sa; Password=Antonio12345@; TrustServerCertificate=True");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (Int32)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = (string)datos.Lector["Marca"];
                    aux.Categoria = (string)datos.Lector["IdCategoria"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    Lista.Add(aux);
                }
                return Lista;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }


    }
}
