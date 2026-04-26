using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
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

        public void agregarCat(string nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("INSERT INTO CATEGORIAS (Descripcion) VALUES (@desc)");
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

        public void modificarCat(Categoria cat)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("UPDATE CATEGORIAS SET Descripcion = @desc WHERE Id = @id");
                datos.setParametro("@desc", cat.Descripcion);
                datos.setParametro("@id", cat.Id);
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

        public void eliminarCat(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("DELETE FROM CATEGORIAS WHERE Id = @id");
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

        public bool existeCat(string descripcion, int IdActual=0)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // contamos cuántas marcas tienen ese nombre (ignorando mayúsculas/minúsculas)
                datos.setConsulta("SELECT COUNT(*) FROM CATEGORIAS WHERE Descripcion = @desc AND Id != @id");
                datos.setParametro("@desc", descripcion);
                datos.setParametro("@id", IdActual);
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

        public bool CatEnUso(int idCat)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // contamos cuántas marcas tienen ese nombre (ignorando mayúsculas/minúsculas)
                datos.setConsulta("SELECT COUNT(*) FROM ARTICULOS WHERE IdCategoria = @id");
                datos.setParametro("@id", idCat);
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
