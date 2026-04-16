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
            //Cosas que se usan
            List<Articulo> Lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            //Try para evitar excepciones
            try
            {
                //Conexion con la base de datos usando acceso datos
                datos.setConsulta("select P.Id, P.Codigo, P.Nombre, P.Descripcion, P.IdCategoria, P.Precio, E.Descripcion Marca, J.ImagenUrl FROM dbo.ARTICULOS P INNER JOIN dbo.MARCAS E ON P.IdMarca = E.Id INNER JOIN dbo.IMAGENES J ON P.Id = J.IdArticulo");
                datos.ejecutarLectura();
                //While para cargar los datos a la lista de articulo
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (Int32)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = (string)datos.Lector["Marca"];
                    aux.Categoria = (int)datos.Lector["IdCategoria"];
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
            //Finally para asegurarnos de cerrar la conexion
            finally { datos.cerrarConexion(); }
        }


        // EN PROCESO HAY QUE HACER CLASE IMAGEN Y CATEGORIA

        //public void agregar(Articulo nuevo)
        //{
        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {
                  // no estoy 100% de que el insert sea asi 😢
        //        datos.setConsulta("Insert into ARTICULOS (Codigo,Nombre,Descripcion,Precio,IdMarca,IdCategoria) values (@codigo,@nombre,@descripcion,@precio,@idmarca,@idcategoria)");
        //        datos.setParametro("@codigo", nuevo.Codigo.id);  con id?
        //        datos.ejecutarLectura();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();  // para qe se cierre igual
        //    }
        //}


    }
}
