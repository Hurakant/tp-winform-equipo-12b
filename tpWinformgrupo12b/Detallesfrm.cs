using Dominio;
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
    public partial class Detallesfrm : Form
    {
        private Articulo articuloDetalle;
        public Detallesfrm(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            this.articuloDetalle = articuloSeleccionado;
        }

        private void Detallesfrm_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarImagenes();
        }
        private void CargarDatos() 
        {
            //Asignamos los datos a los Labels del formulario
            lbCodigo.Text = articuloDetalle.Codigo;
            lbNombre.Text = articuloDetalle.Nombre;
            lbMarca.Text = articuloDetalle.Marca.Descripcion;
            lbCategoria.Text = articuloDetalle.Categoria.Descripcion;
            //Los textboxs
            txtPrecio.Text = $"$ {articuloDetalle.Precio:0.00}";
            rtxtDescripcion.Text = articuloDetalle.Descripcion;
        }
            private void CargarImagenes()
        {
            flpImagenes.Controls.Clear();

            //Buscamos la imagen
            foreach (Imagen img in articuloDetalle.Imagen)
            {
                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom; //Mantenemos la proporcion IMPORTANTE
                pb.Width = 150;
                pb.Height = 150;
                pb.Margin = new Padding(10); //Padding para bonito

                try
                {
                    //cargamo con try
                    pb.Load(img.ImagenUrl);
                }
                catch (Exception)
                {
                    // Si el link está roto o vacío, cargamos una imagen de error por defecto
                    pb.Load("https://picsum.photos/seed/picsum/200/300");
                }

                // Agregamos el PictureBox creado al FlowLayoutPanel IMPORTANTE ESTO
                flpImagenes.Controls.Add(pb);
            }
        }
    }
}
