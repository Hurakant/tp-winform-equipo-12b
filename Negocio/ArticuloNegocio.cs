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
                datos.setConsulta("select P.Id, P.Codigo, P.Nombre, P.Descripcion, P.Precio, P.IdCategoria, C.Descripcion as Categoria, E.Descripcion as Marca, J.ImagenUrl FROM dbo.ARTICULOS P LEFT JOIN dbo.MARCAS E ON P.IdMarca = E.Id LEFT JOIN dbo.CATEGORIAS C ON P.IdCategoria = C.Id LEFT JOIN dbo.IMAGENES J ON P.Id = J.IdArticulo"); datos.ejecutarLectura();
            
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (Int32)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();

                     // carga marca si existe
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    // carga categoria si existe
                    if (!(datos.Lector["Categoria"] is DBNull))
                    {
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    }
                    else
                    {
                        aux.Categoria.Descripcion = "sin categoria";   // para que no salte q no hay categoria 
                    }

                    // cargar el url si existe    
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.Imagen = (string)datos.Lector["ImagenUrl"];
                    }

                    Lista.Add(aux);
                }

                return Lista;   
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) VALUES (@codigo, @nombre, @descripcion, @precio, @idmarca, @idcategoria)");

                datos.setParametro("@codigo", nuevo.Codigo);
                datos.setParametro("@nombre", nuevo.Nombre);
                datos.setParametro("@descripcion", nuevo.Descripcion);
                datos.setParametro("@precio", nuevo.Precio);

                // datos predeterminados hasta que se haga una clase de marcanegorio y categorianegocio
                // queda como samsung y celular
                datos.setParametro("@idmarca", 1);
                datos.setParametro("@idcategoria", 1);

                datos.ejecutarAccion();

                // Esto seria para poder asignarle el url del alta al grid, sino aparece la imagen por defecto
                datos.cerrarConexion(); // para hacer nueva consulta
                // buscar el id asignado x su codigo
                datos = new AccesoDatos();
                datos.setConsulta("SELECT Id FROM ARTICULOS where Codigo = @codigoBusqueda");
                datos.setParametro("@codigoBusqueda", nuevo.Codigo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    // guaardar el ID que encontramos
                    int idAsignado = (int)datos.Lector["Id"];
                    datos.cerrarConexion();

                    // se guarda ka imagen
                    // y con el id q buscamos ponemos su imagen
                    datos = new AccesoDatos();
                    datos.setConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArt, @url)");
                    datos.setParametro("@idArt", idAsignado);
                    datos.setParametro("@url", nuevo.Imagen);

                    datos.ejecutarAccion();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}