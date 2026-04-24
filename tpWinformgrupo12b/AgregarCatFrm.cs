using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpWinformgrupo12b
{
    public partial class AgregarCatFrm : Form
    {
        private Categoria categoria = null;
        public AgregarCatFrm()
        {
            InitializeComponent();
            Text = "Agregar Categoría";
        }

        public AgregarCatFrm(Categoria seleccionado)
        {
            InitializeComponent();
            this.categoria = seleccionado;
            Text = "Modificar Categoría";
        }

        private List<Categoria> listaCategorias;
        private CategoriaNegocio negocio = new CategoriaNegocio();

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cargar()
        {
            try
            {
                listaCategorias = negocio.listar();
                //dgvCategoria.DataSource = listaCategorias;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptarCat_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (categoria == null) categoria = new Categoria();

                categoria.Descripcion = txtNomCat.Text;

                if (categoria.Id != 0)
                {
                    negocio.modificarCat(categoria);
                    MessageBox.Show("Modificada exitosamente!");
                }
                else
                {
                    negocio.agregarCat(categoria.ToString());
                    MessageBox.Show("Agregada exitosamente!");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AgregarCatFrm_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                txtNomCat.Text = categoria.Descripcion;
            }
        }
    }
}
