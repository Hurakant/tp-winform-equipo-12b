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
    public partial class MarcaFrm : Form
    {
        public MarcaFrm()
        {
            InitializeComponent();
        }

        private List<Marca> listaMarca;
        private MarcaNegocio negocio = new MarcaNegocio();

        private void cargar()
        {
            listaMarca = negocio.listarM();
            dgvMarca.DataSource = listaMarca;
        }

        private void MarcaFrm_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            AgregarMarcaFrm marca = new AgregarMarcaFrm();
            marca.ShowDialog();
            cargar();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarca.CurrentRow != null)
            {
                Marca seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                AgregarMarcaFrm modificar = new AgregarMarcaFrm(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarca.CurrentRow != null)
            {
                Marca seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                // preguntar si se elimina o no
                DialogResult respuesta = MessageBox.Show("Eliminar " + seleccionado.Descripcion + "?", "Eliminando", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        negocio.eliminarMarca(seleccionado.Id);
                        cargar();
                    }
                    catch (Exception ex)
                    {
                        throw ex; // error de que si esta en uso no se borre
                    }
                }
            }
        }
    }
}
