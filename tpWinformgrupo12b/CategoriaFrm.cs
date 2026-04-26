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

namespace tpWinformgrupo12b
{
    public partial class CategoriaFrm : Form
    {
        public CategoriaFrm()
        {
            InitializeComponent();
        }

        private List<Categoria> listaCategorias;
        private CategoriaNegocio negocio = new CategoriaNegocio();

        private void cargar()
        {
            listaCategorias = negocio.listar();
            dgvCategoria.DataSource = listaCategorias;
        }

        private void CategoriaFrm_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            AgregarCatFrm cat = new AgregarCatFrm();
            cat.ShowDialog();
            cargar();
        }

        private void btnModificarCat_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                Categoria seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                AgregarCatFrm modificar = new AgregarCatFrm(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow != null)
            {
                Categoria seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;

                try
                {
                    // validacion para que no se eliminen las categorias en uso
                    if (negocio.CatEnUso(seleccionado.Id))
                    {
                        MessageBox.Show("No se puede eliminar la categoría '" + seleccionado.Descripcion + "' porque hay artículos que la están usando.");
                        return; 
                    }               
                    
                    DialogResult respuesta = MessageBox.Show("Eliminar " + seleccionado.Descripcion + "?", "Eliminando", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        negocio.eliminarCat(seleccionado.Id);
                        cargar();
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
