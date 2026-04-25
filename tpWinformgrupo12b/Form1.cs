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

        private void TsbEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvBasedeDatos.CurrentRow.DataBoundItem;
                negocio.eliminar(seleccionado.Id);
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbRecargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recargando lista...");
            cargar();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnBusquedaRapida_Click(object sender, EventArgs e)
        {
            string filtro = tbxBusquedaRapida.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(filtro))
            {
                cargar();
                return;
            }

            // foreach para ver las coincidencias
            bool hayCoincidencias = false;
            foreach (Articulo art in articuloList)
            {
                if (CoincideConBusqueda(art, filtro) == true)
                {
                    hayCoincidencias = true;
                    break; //en la primera coincidencia pum para afuera
                }
            }

            //aqui no hay coincidencias por eso salimos
            if (hayCoincidencias == false)
            {
                MessageBox.Show("No hubo coincidencias", "Búsqueda Rápida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Logica compleja para decidir el orden
            List<Articulo> listaOrdenada = articuloList
                .OrderByDescending(art => CoincideConBusqueda(art, filtro))
                .ThenBy(art => art.Nombre)
                .ToList();

            dgvBasedeDatos.DataSource = null;
            dgvBasedeDatos.DataSource = listaOrdenada;

            ocultarColumnas();
            if (dgvBasedeDatos.Columns["Codigo"] != null)
                dgvBasedeDatos.Columns["Codigo"].HeaderText = "Código";
            if (dgvBasedeDatos.Columns["Precio"] != null)
                dgvBasedeDatos.Columns["Precio"].DefaultCellStyle.Format = "C2";
        }
        private bool CoincideConBusqueda(Articulo aux, string filtro)
        {
            // usamos el poder de los 50ifs juntos para evaluar todos los campos y mandarlos al principio de la lista

            if (aux.Codigo != null && aux.Codigo.ToUpper().Contains(filtro))
            {
                return true;
            }

            if (aux.Nombre != null && aux.Nombre.ToUpper().Contains(filtro))
            {
                return true;
            }

            if (aux.Descripcion != null && aux.Descripcion.ToUpper().Contains(filtro))
            {
                return true;
            }

            if (aux.Marca != null && aux.Marca.Descripcion.ToUpper().Contains(filtro))
            {
                return true;
            }

            if (aux.Categoria != null && aux.Categoria.Descripcion.ToUpper().Contains(filtro))
            {
                return true;
            }

            if (aux.Precio.ToString().Contains(filtro))
            {
                return true;
            }
            //si llegó hasta aqui significa que no hay coincidencias
            return false;
        }

        private void tsbCategorias_Click(object sender, EventArgs e)
        {
            CategoriaFrm Cat = new CategoriaFrm();
            Cat.ShowDialog();
            cargar();
        }

        private void tsbMarcas_Click(object sender, EventArgs e)
        {
            MarcaFrm marca = new MarcaFrm();
            marca.ShowDialog();
            cargar();
        }
    }
}
