using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private ImagenNegocio imagenNegocio = new ImagenNegocio();
        public List<Articulo> listar()
        {
            List<Articulo> Lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT P.Id,P.Codigo,P.Nombre,P.Descripcion,P.Precio,P.IdMarca,P.IdCategoria, C.Descripcion as Categoria,E.Descripcion as Marca FROM dbo.ARTICULOS P LEFT JOIN dbo.MARCAS E ON P.IdMarca = E.Id LEFT JOIN dbo.CATEGORIAS C ON P.IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = datos.Lector["IdMarca"] is DBNull ? 0 : (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = datos.Lector["Marca"] is DBNull ? "Sin Marca" : (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = datos.Lector["IdCategoria"] is DBNull ? 0 : (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = datos.Lector["Categoria"] is DBNull ? "Sin Categoría" : (string)datos.Lector["Categoria"];

                    Lista.Add(aux);
                }

                // Cerramos la conexión del listar antes de abrir las de imágenes
                datos.cerrarConexion();

                foreach(Articulo art in Lista)
{
                    art.Imagen = imagenNegocio.listarPorArticulo(art.Id);
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
                datos.setParametro("@idmarca", nuevo.Marca.Id);
                datos.setParametro("@idcategoria", nuevo.Categoria.Id);

                datos.ejecutarAccion();
                datos.cerrarConexion();

                datos = new AccesoDatos();
                datos.setConsulta("SELECT Id FROM ARTICULOS WHERE Codigo = @codigoBusqueda");
                datos.setParametro("@codigoBusqueda", nuevo.Codigo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    int idAsignado = (int)datos.Lector["Id"];
                    datos.cerrarConexion();

                    // Delegamos a ImagenNegocio con los objetos Imagen
                    imagenNegocio.agregarVarias(idAsignado, nuevo.Imagen);
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
        public void modificar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, Precio = @precio, IdMarca = @idmarca, IdCategoria = @idcategoria WHERE Id = @id");

                datos.setParametro("@codigo", art.Codigo);
                datos.setParametro("@nombre", art.Nombre);
                datos.setParametro("@descripcion", art.Descripcion);
                datos.setParametro("@precio", art.Precio);
                datos.setParametro("@idmarca", art.Marca.Id);
                datos.setParametro("@idcategoria", art.Categoria.Id);
                datos.setParametro("@id", art.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            //mandamos lo de imágenes a ImagenNegocio
            imagenNegocio.reemplazarTodas(art.Id, art.Imagen);
        }
        public void eliminar(int id)
        {
            // Primero borramos
            imagenNegocio.eliminarTodasDeArticulo(id);

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("DELETE FROM ARTICULOS WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.ejecutarAccion();
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