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
            Text = "Agregar Artículo"; //Cuando es vacio agrega entonces le puse este nombre po si acaso
        }
        public AgregarArtfrm(Articulo seleccionado)
        {
            InitializeComponent();
            this.articulo = seleccionado;
            Text = "Modificar Artículo"; //Este es cuando se modifica un articulo
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
                //validamos que no queden en blanco/null los txt
                if (validar())
                {
                    MessageBox.Show("Por favor, complete los campos obligatorios.");
                    return;
                }

                //si es un alta nueva, instanciamos
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                //Textos
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                //Imagenes
                articulo.Imagenes.Clear();
                if (!string.IsNullOrWhiteSpace(txturlImagen.Text))
                {
                    articulo.Imagenes.Add(txturlImagen.Text);
                }

                //comboBox para estas 2 cosas feas
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;

                //if para modificar o agregar
                if (articulo.Id != 0)
                {
                    artnegocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente!");
                }
                else
                {
                    artnegocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente!");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            CategoriaNegocio negocioC = new CategoriaNegocio();
            MarcaNegocio negocioM = new MarcaNegocio();
            try
            {
                cbxMarca.DataSource = negocioM.listarM();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                cbxCategoria.DataSource = negocioC.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo.ToString();
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();

                    if (articulo.Imagenes != null && articulo.Imagenes.Count > 0)
                    {
                        // primer link
                        txturlImagen.Text = articulo.Imagenes[0];
                        // cargar picturebox
                        cargarImagen(articulo.Imagenes[0]);
                    }

                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnMasImagen_Click(object sender, EventArgs e)
        {
            //agregar mas de 1 enlace?
        }

        private bool validar()
        {
            // resetear colores de fondo por si antes falló y ahora está bien
            txtCodigo.BackColor = Color.White;
            txtNombre.BackColor = Color.White;
            txtDescripcion.BackColor = Color.White;
            txtPrecio.BackColor = Color.White;


            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                txtCodigo.BackColor = Color.Red;
                return true; // Hay error
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = Color.Red;
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.BackColor = Color.Red;
                return true;
            }
            if (string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                txtPrecio.BackColor = Color.Red;
                return true;
            }

            return false; // si llega aca no hay ningun txt en blanco/null
        }
    }
}
