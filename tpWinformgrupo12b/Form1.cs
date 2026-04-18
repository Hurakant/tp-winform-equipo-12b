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
            dgvBasedeDatos.Columns["imagen"].Visible = false;  
            dgvBasedeDatos.Columns["Id"].Visible = false;
        }



        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
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
                cargarImagen(articuloList[0].Imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvBasedeDatos_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dgvBasedeDatos.CurrentRow != null)
            {
                Articulo selectActual = (Articulo)dgvBasedeDatos.CurrentRow.DataBoundItem;
                cargarImagen(selectActual.Imagen);
            }

        
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArtfrm agregarArt = new AgregarArtfrm();
            agregarArt.ShowDialog();
            cargar();
        }
    }
}
