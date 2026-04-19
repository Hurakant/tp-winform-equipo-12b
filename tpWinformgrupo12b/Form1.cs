using Dominio;
using Negocio;
using System;
using System.Collections;
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
    public partial class pbxImagen : Form
    {
        private int imgIndex = 0; //esta es para el indice de las imagenes
        private List<Articulo> articuloList;

        public pbxImagen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Carga del datasource en el grid
            ArticuloNegocio negocio = new ArticuloNegocio();
            articuloList = negocio.listar();
            dgvBasedeDatos.DataSource = articuloList;
            cargar();
        }

        private void ocultarColumnas()
        {
            //verificamos si la columna existe antes de ocultarla
            if (dgvBasedeDatos.Columns["Imagenes"] != null)
            {
                dgvBasedeDatos.Columns["Imagenes"].Visible = false;
            }

            if (dgvBasedeDatos.Columns["Id"] != null)
            {
                dgvBasedeDatos.Columns["Id"].Visible = false;
            }

            dgvBasedeDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                //valida el string
                if (!string.IsNullOrEmpty(imagen))
                    pbxArticulo.Load(imagen);
                else
                    throw new Exception(); //forzamos el catch para usar el placeholder
            }
            catch (Exception)
            {
                //link del placeholder
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void cargar()
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                articuloList = artNegocio.listar();
                dgvBasedeDatos.DataSource = articuloList;

                ocultarColumnas();

                //Cambiar nombres de cabecera y formato de dato
                dgvBasedeDatos.Columns["Codigo"].HeaderText = "Código";
                dgvBasedeDatos.Columns["Precio"].DefaultCellStyle.Format = "C2";

                // Cargar imagen del primer registro si está
                if (articuloList[0].Imagenes.Count > 0)
                    cargarImagen(articuloList[0].Imagenes[0]);
                else
                    cargarImagen(""); //carga de placeholder si el string viene vacio
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void dgvBasedeDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBasedeDatos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvBasedeDatos.CurrentRow.DataBoundItem;
                imgIndex = 0; // se resetea el indice
                if (seleccionado.Imagenes != null && seleccionado.Imagenes.Count > 0)
                {
                    cargarImagen(seleccionado.Imagenes[0]);
                }
                else
                {
                    cargarImagen(""); //Esto lo manda al placeholder directo porque esta vacio y dejamos el if en cargar imagen
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArtfrm agregarArt = new AgregarArtfrm();
            agregarArt.ShowDialog();
            cargar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvBasedeDatos.CurrentRow.DataBoundItem;

            //if para que no se rompa
            if (imgIndex < seleccionado.Imagenes.Count - 1)
            {
                imgIndex++;
                cargarImagen(seleccionado.Imagenes[imgIndex]);
            }
        }

private void btnAnterior_Click(object sender, EventArgs e)
{
    //para saber si estamos en la primera imagen
    if (imgIndex > 0)
    {
        imgIndex--;
        Articulo seleccionado = (Articulo)dgvBasedeDatos.CurrentRow.DataBoundItem;
        cargarImagen(seleccionado.Imagenes[imgIndex]);
    }
}

        private void TsbAgregar_Click(object sender, EventArgs e)
        {
            AgregarArtfrm agregarArt = new AgregarArtfrm();
            agregarArt.ShowDialog();
            cargar();
        }

        private void TsbModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvBasedeDatos.CurrentRow.DataBoundItem;
            AgregarArtfrm modificar = new AgregarArtfrm(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
    }
}
