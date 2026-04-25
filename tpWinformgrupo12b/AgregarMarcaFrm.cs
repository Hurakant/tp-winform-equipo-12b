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
    public partial class AgregarMarcaFrm : Form
    {

        private Marca marca = null;

        public AgregarMarcaFrm()
        {
            InitializeComponent();
            Text = "Agregar Marca";
        }

        public AgregarMarcaFrm(Marca seleccionado)
        {
            InitializeComponent();
            this.marca = seleccionado;
            Text = "Modificar Marca";
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            string nombreNuevo = txtNomMarca.Text.Trim(); // para qeu agarre el texto sin espacios
            try
            {
                // para saber si la marca ya existe a la hora de agregar
                if (marca == null && negocio.existeMarca(nombreNuevo)) 
                {
                    MessageBox.Show("La marca '" + nombreNuevo + "' ya existe.");
                    return;
                }

                if (marca == null) marca = new Marca();

                marca.Descripcion = txtNomMarca.Text;

                if (marca.Id != 0)
                {
                    negocio.modificarMarca(marca);
                    MessageBox.Show("Modificada exitosamente!");
                }
                else
                {
                    negocio.agregarMarca(txtNomMarca.Text);
                    MessageBox.Show("Agregada exitosamente!");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AgregarMarcaFrm_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                txtNomMarca.Text = marca.Descripcion;
            }
        }
    }
}
