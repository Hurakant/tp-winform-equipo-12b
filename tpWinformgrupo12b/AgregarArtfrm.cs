using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //falta metodo modificar
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
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Imagen = txturlImagen.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    //artnegocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    artnegocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
                
        }
        private void txturlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txturlImagen.Text); //el url para mostar la imagen en el agregar
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAgregarArticulo.Load(imagen);
                
            }
            catch (Exception ex)
            {
                pbxAgregarArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void AgregarArtfrm_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
