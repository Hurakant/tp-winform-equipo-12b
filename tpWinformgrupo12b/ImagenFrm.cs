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
    public partial class ImagenFrm : Form
    {
        private int IdArt;
        public ImagenFrm(int IdArt)
        {
            InitializeComponent();
            this.IdArt = IdArt;
        }

        private void cargar()
        {
            try
            {
                ImagenNegocio imgNegocio = new ImagenNegocio();
                List<Imagen> listaImagenes = imgNegocio.listarPorArticulo(IdArt);
                dgvImagenes.DataSource = listaImagenes;

                dgvImagenes.Columns["Id"].Visible = false;
                dgvImagenes.Columns["IdArticulo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las imágenes: " + ex.Message);
            }
        }

        private void ImagenFrm_Load(object sender, EventArgs e)
        {
            ImagenNegocio ImgNeg = new ImagenNegocio();
            List<Imagen> imagenes = ImgNeg.listarPorArticulo(IdArt);
            dgvImagenes.DataSource = imagenes;
            cargar();
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow != null)
            {
                Imagen seleccionada = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;

                try
                {
                    pbxImagen.Load(seleccionada.ImagenUrl);
                }
                catch (Exception)
                {
                   pbxImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarImagenFrm img = new AgregarImagenFrm(IdArt);
            img.ShowDialog();
            cargar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
