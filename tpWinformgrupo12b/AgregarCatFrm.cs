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
using System.Text.RegularExpressions;
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

        private void btnAceptarCat_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            string nombreNuevo = txtNomCat.Text.Trim();
            try
            {
                // para saber si la categoria ya existe a la hora de agregar
                if (categoria == null && negocio.existeCat(nombreNuevo))
                {
                    MessageBox.Show("La categoria '" + nombreNuevo + "' ya existe.");
                    return;
                }

                // validad q tenga texto
                if (validar())
                {
                    MessageBox.Show("Por favor, complete los campos obligatorios.");
                    return;
                }

                if (categoria == null) categoria = new Categoria();

                categoria.Descripcion = txtNomCat.Text;

                if (categoria.Id != 0)
                {
                    negocio.modificarCat(categoria);
                    MessageBox.Show("Modificada exitosamente!");
                }
                else
                {
                    negocio.agregarCat(txtNomCat.Text);
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

        private void btnCancelarCat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validar()
        {
            // resetear colores de fondo por si antes falló y ahora está bien
            txtNomCat.BackColor = Color.White;
            


            if (string.IsNullOrWhiteSpace(txtNomCat.Text))
            {
                txtNomCat.BackColor = Color.Red;
                return true; // Hay error
            }
            return false; // si llega aca no hay ningun txt en blanco/null
        }
    }
}
