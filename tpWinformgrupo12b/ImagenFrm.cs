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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow == null) return;

            Imagen seleccionada = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;

            // Abrimos un form simple con un textbox para la nueva URL
            Form frmModificar = new Form();
            frmModificar.Text = "Modificar imagen";
            frmModificar.Size = new Size(400, 150);
            frmModificar.FormBorderStyle = FormBorderStyle.FixedDialog;
            frmModificar.StartPosition = FormStartPosition.CenterParent;

            TextBox txtNuevaUrl = new TextBox();
            txtNuevaUrl.Text = seleccionada.ImagenUrl;
            txtNuevaUrl.Width = 360;
            txtNuevaUrl.Location = new Point(10, 20);
            frmModificar.Controls.Add(txtNuevaUrl);

            Button btnAceptar = new Button();
            btnAceptar.Text = "Aceptar";
            btnAceptar.Location = new Point(200, 60);
            btnAceptar.DialogResult = DialogResult.OK;
            frmModificar.Controls.Add(btnAceptar);

            Button btnCancelar = new Button();
            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(290, 60);
            btnCancelar.DialogResult = DialogResult.Cancel;
            frmModificar.Controls.Add(btnCancelar);

            frmModificar.AcceptButton = btnAceptar;
            frmModificar.CancelButton = btnCancelar;

            if (frmModificar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImagenNegocio imgNegocio = new ImagenNegocio();
                    imgNegocio.modificar(seleccionada.IdArticulo, seleccionada.ImagenUrl, txtNuevaUrl.Text);
                    cargar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvImagenes.CurrentRow == null) return;

            Imagen seleccionada = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;

            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro que querés eliminar esta imagen?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    ImagenNegocio imgNegocio = new ImagenNegocio();
                    imgNegocio.eliminar(seleccionada.IdArticulo, seleccionada.ImagenUrl);
                    cargar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
