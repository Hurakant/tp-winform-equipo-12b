using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listarM()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
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


        public void agregarMarca(string nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("INSERT INTO MARCAS (Descripcion) VALUES (@desc)");
                datos.setParametro("@desc", nueva);
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

        public void modificarMarca(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("UPDATE MARCAS SET Descripcion = @desc WHERE Id = @id");
                datos.setParametro("@desc", marca.Descripcion);
                datos.setParametro("@id", marca.Id);
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

        public void eliminarMarca(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("DELETE FROM MARCAS WHERE Id = @id");
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

        public bool existeMarca(string descripcion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // contamos cuántas marcas tienen ese nombre (ignorando mayúsculas/minúsculas)
                datos.setConsulta("SELECT COUNT(*) FROM MARCAS WHERE Descripcion = @desc");
                datos.setParametro("@desc", descripcion);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    int cantidad = (int)datos.Lector[0];
                    return cantidad > 0; // si es mayor a 0, ya existe
                }
                return false;
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
