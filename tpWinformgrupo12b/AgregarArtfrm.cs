using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace tpWinformgrupo12b
{
    public partial class AgregarArtfrm : Form
    {
        private Articulo articulo = null;

        public AgregarArtfrm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        //  EL BOTON ACEPTAR NO AGREGA NADA, FALTA METODO DE AGREGAR Y MODIFICAR
        // tmb faltan las demas opciones como lo del url de imagen y que ande el aceptar y no se si poner la picturebox
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artnegocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                articulo.Codigo = txtCodigo.Text;

                if (articulo.Id != 0)
                {
                    //articulo.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    //Negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
