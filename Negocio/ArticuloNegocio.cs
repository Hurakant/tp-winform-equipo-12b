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

                    aux.Id = (Int32)datos.Lector["Id"];
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

                    //Aquí se cargan las imagenes ahora, llama a una funcion que hace cosas, es por si tiene mas de una
                    aux.Imagenes = listarImagenesPorArticulo(aux.Id);

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

                datos.setParametro("@idmarca", nuevo.Marca.Id);
                datos.setParametro("@idcategoria", nuevo.Categoria.Id);

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

                    // se guarda la imagen
                    // y con el id q buscamos ponemos su imagen
                    datos = new AccesoDatos();
                    datos.setConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArt, @url)");
                    datos.setParametro("@idArt", idAsignado);
                    datos.setParametro("@url", nuevo.Imagenes.Count > 0 ? nuevo.Imagenes[0] : "");

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
        public List<string> listarImagenesPorArticulo(int idArticulo)
        {
            List<string> lista = new List<string>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("SELECT ImagenUrl FROM IMAGENES WHERE IdArticulo = @id");
                datos.setParametro("@id", idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add((string)datos.Lector["ImagenUrl"]);
                }
                return lista;
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

                datos.cerrarConexion();
                datos = new AccesoDatos();

                datos.setConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idArt");
                datos.setParametro("@idArt", art.Id);
                datos.ejecutarAccion();
                datos.cerrarConexion();

                //si el artículo tiene al menos una imagen en la lista, la insertamos
                if (art.Imagenes.Count > 0 && !string.IsNullOrEmpty(art.Imagenes[0]))
                {
                    datos = new AccesoDatos();
                    datos.setConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArt, @url)");
                    datos.setParametro("@idArt", art.Id);
                    datos.setParametro("@url", art.Imagenes[0]);

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
        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setConsulta("DELETE From ARTICULOS WHERE Id = @id");
                datos.setParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}