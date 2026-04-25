using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listarPorArticulo(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES WHERE IdArticulo = @id");
                datos.setParametro("@id", idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen img = new Imagen();
                    img.Id = (int)datos.Lector["Id"];
                    img.IdArticulo = (int)datos.Lector["IdArticulo"];
                    img.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    lista.Add(img);
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

        public void agregar(int idArticulo, string url)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArt, @url)");
                datos.setParametro("@idArt", idArticulo);
                datos.setParametro("@url", url);
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

        public void agregarVarias(int idArticulo, List<Imagen> imagenes)
        {
            foreach (Imagen img in imagenes)
            {
                if (!string.IsNullOrEmpty(img.ImagenUrl))
                    agregar(idArticulo, img.ImagenUrl);
            }
        }

        public void eliminar(int idArticulo, string url)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idArt AND ImagenUrl = @url");
                datos.setParametro("@idArt", idArticulo);
                datos.setParametro("@url", url);
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

        public void eliminarTodasDeArticulo(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @idArt");
                datos.setParametro("@idArt", idArticulo);
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

        public void modificar(int idArticulo, string urlVieja, string urlNueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("UPDATE IMAGENES SET ImagenUrl = @urlNueva WHERE IdArticulo = @idArt AND ImagenUrl = @urlVieja");
                datos.setParametro("@urlNueva", urlNueva);
                datos.setParametro("@idArt", idArticulo);
                datos.setParametro("@urlVieja", urlVieja);
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

        public void reemplazarTodas(int idArticulo, List<Imagen> imagenes)
        {
            eliminarTodasDeArticulo(idArticulo);
            agregarVarias(idArticulo, imagenes);
        }
    }
}