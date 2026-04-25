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
    public partial class AgregarImagenFrm : Form
    {

        private int idNuevo;

        public AgregarImagenFrm(int idNuevo)
        {
            InitializeComponent();
            this.idNuevo = idNuevo;
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
               pbxAgregarImg.Load(txtURL.Text);
            }
            catch (Exception)
            {
                pbxAgregarImg.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnCancelarimg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarImg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtURL.Text))
            {
                MessageBox.Show("Por favor, ingrese una URL.");
                return;
            }

            Imagen nuevaImg = new Imagen();
            ImagenNegocio negocio = new ImagenNegocio();

            nuevaImg.IdArticulo = idNuevo;
            nuevaImg.ImagenUrl = txtURL.Text;

            negocio.agregar(nuevaImg.IdArticulo,nuevaImg.ImagenUrl);
            MessageBox.Show("Imagen agregada correctamente!");

            Close();
            
        }

        private void AgregarImagenFrm_Load(object sender, EventArgs e)
        {
            try
            {
                pbxAgregarImg.Load(txtURL.Text);
            }
            catch (Exception)
            {
                pbxAgregarImg.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            try // cada vez que se cambia el texto en el txt se carga el url en el pbx, no encontre otra forma de que cargue
            {
                pbxAgregarImg.Load(txtURL.Text);
            }
            catch (Exception)
            {
                pbxAgregarImg.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
    }
}
