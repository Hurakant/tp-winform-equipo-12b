namespace tpWinformgrupo12b
{
    partial class pbxImagen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pbxImagen));
            this.dgvBasedeDatos = new System.Windows.Forms.DataGridView();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.TsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.TsbModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbEliminarArticulo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbCategoria = new System.Windows.Forms.ToolStripButton();
            this.tsbMarcas = new System.Windows.Forms.ToolStripButton();
            this.tsbImagen = new System.Windows.Forms.ToolStripButton();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.lbBusquedaRapida = new System.Windows.Forms.Label();
            this.tbxBusquedaRapida = new System.Windows.Forms.TextBox();
            this.gbFiltrosDB = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboPrecio = new System.Windows.Forms.ComboBox();
            this.lbOrdenarPrecio = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lbOrdenarCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lbOrdenarMarca = new System.Windows.Forms.Label();
            this.lbordenarpor = new System.Windows.Forms.Label();
            this.btnBusquedaRapida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasedeDatos)).BeginInit();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.gbFiltrosDB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBasedeDatos
            // 
            this.dgvBasedeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBasedeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasedeDatos.Location = new System.Drawing.Point(11, 29);
            this.dgvBasedeDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBasedeDatos.Name = "dgvBasedeDatos";
            this.dgvBasedeDatos.RowHeadersWidth = 51;
            this.dgvBasedeDatos.RowTemplate.Height = 24;
            this.dgvBasedeDatos.Size = new System.Drawing.Size(670, 363);
            this.dgvBasedeDatos.TabIndex = 0;
            this.dgvBasedeDatos.SelectionChanged += new System.EventHandler(this.dgvBasedeDatos_SelectionChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Location = new System.Drawing.Point(855, 306);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(97, 23);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Imagen siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnterior.Location = new System.Drawing.Point(715, 306);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(97, 23);
            this.btnAnterior.TabIndex = 4;
            this.btnAnterior.Text = "Imagen anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // tsMain
            // 
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbAgregar,
            this.TsbModificar,
            this.toolStripSeparator1,
            this.TsbEliminarArticulo,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.tsbCategoria,
            this.tsbMarcas,
            this.tsbImagen});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(992, 27);
            this.tsMain.TabIndex = 5;
            this.tsMain.Text = "toolStrip1";
            // 
            // TsbAgregar
            // 
            this.TsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("TsbAgregar.Image")));
            this.TsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAgregar.Name = "TsbAgregar";
            this.TsbAgregar.Size = new System.Drawing.Size(73, 24);
            this.TsbAgregar.Text = "Agregar";
            this.TsbAgregar.ToolTipText = "Agregar un articulo";
            this.TsbAgregar.Click += new System.EventHandler(this.TsbAgregar_Click);
            // 
            // TsbModificar
            // 
            this.TsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("TsbModificar.Image")));
            this.TsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbModificar.Name = "TsbModificar";
            this.TsbModificar.Size = new System.Drawing.Size(82, 24);
            this.TsbModificar.Text = "Modificar";
            this.TsbModificar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TsbModificar.ToolTipText = "Modificar un articulo";
            this.TsbModificar.Click += new System.EventHandler(this.TsbModificar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // TsbEliminarArticulo
            // 
            this.TsbEliminarArticulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TsbEliminarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("TsbEliminarArticulo.Image")));
            this.TsbEliminarArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEliminarArticulo.Name = "TsbEliminarArticulo";
            this.TsbEliminarArticulo.Size = new System.Drawing.Size(74, 24);
            this.TsbEliminarArticulo.Text = "Eliminar";
            this.TsbEliminarArticulo.ToolTipText = "Eliminar articulo";
            this.TsbEliminarArticulo.Click += new System.EventHandler(this.TsbEliminarArticulo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton1.Text = "Recargar";
            this.toolStripButton1.ToolTipText = "Recargar la lista de articulos";
            this.toolStripButton1.Click += new System.EventHandler(this.tsbRecargar_Click);
            // 
            // tsbCategoria
            // 
            this.tsbCategoria.Image = global::tpWinformgrupo12b.Properties.Resources.categoria;
            this.tsbCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCategoria.Name = "tsbCategoria";
            this.tsbCategoria.Size = new System.Drawing.Size(87, 24);
            this.tsbCategoria.Text = "Categorias";
            this.tsbCategoria.ToolTipText = "Administrar Categorias";
            this.tsbCategoria.Click += new System.EventHandler(this.tsbCategoria_Click);
            // 
            // tsbMarcas
            // 
            this.tsbMarcas.Image = global::tpWinformgrupo12b.Properties.Resources.marcas;
            this.tsbMarcas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMarcas.Name = "tsbMarcas";
            this.tsbMarcas.Size = new System.Drawing.Size(69, 24);
            this.tsbMarcas.Text = "Marcas";
            this.tsbMarcas.ToolTipText = "Administrar Marcas";
            this.tsbMarcas.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbImagen
            // 
            this.tsbImagen.Image = global::tpWinformgrupo12b.Properties.Resources.imagenes;
            this.tsbImagen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImagen.Name = "tsbImagen";
            this.tsbImagen.Size = new System.Drawing.Size(82, 24);
            this.tsbImagen.Text = "Imagenes";
            this.tsbImagen.ToolTipText = "Administrar Imagenes";
            this.tsbImagen.Click += new System.EventHandler(this.tsbImagen_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(699, 29);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(267, 274);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            this.pbxArticulo.WaitOnLoad = true;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalles.Location = new System.Drawing.Point(786, 346);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(97, 23);
            this.btnDetalles.TabIndex = 6;
            this.btnDetalles.Text = "Ver detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // lbBusquedaRapida
            // 
            this.lbBusquedaRapida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbBusquedaRapida.AutoSize = true;
            this.lbBusquedaRapida.Location = new System.Drawing.Point(6, 16);
            this.lbBusquedaRapida.Name = "lbBusquedaRapida";
            this.lbBusquedaRapida.Size = new System.Drawing.Size(90, 13);
            this.lbBusquedaRapida.TabIndex = 7;
            this.lbBusquedaRapida.Text = "Busqueda rapida:";
            // 
            // tbxBusquedaRapida
            // 
            this.tbxBusquedaRapida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxBusquedaRapida.Location = new System.Drawing.Point(94, 13);
            this.tbxBusquedaRapida.Name = "tbxBusquedaRapida";
            this.tbxBusquedaRapida.Size = new System.Drawing.Size(100, 20);
            this.tbxBusquedaRapida.TabIndex = 8;
            // 
            // gbFiltrosDB
            // 
            this.gbFiltrosDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbFiltrosDB.Controls.Add(this.panel1);
            this.gbFiltrosDB.Controls.Add(this.btnBusquedaRapida);
            this.gbFiltrosDB.Controls.Add(this.tbxBusquedaRapida);
            this.gbFiltrosDB.Controls.Add(this.lbBusquedaRapida);
            this.gbFiltrosDB.Location = new System.Drawing.Point(12, 396);
            this.gbFiltrosDB.Name = "gbFiltrosDB";
            this.gbFiltrosDB.Size = new System.Drawing.Size(671, 127);
            this.gbFiltrosDB.TabIndex = 9;
            this.gbFiltrosDB.TabStop = false;
            this.gbFiltrosDB.Text = "Filtrar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboPrecio);
            this.panel1.Controls.Add(this.lbOrdenarPrecio);
            this.panel1.Controls.Add(this.cboMarca);
            this.panel1.Controls.Add(this.lbOrdenarCategoria);
            this.panel1.Controls.Add(this.cboCategoria);
            this.panel1.Controls.Add(this.btnOrdenar);
            this.panel1.Controls.Add(this.lbOrdenarMarca);
            this.panel1.Controls.Add(this.lbordenarpor);
            this.panel1.Location = new System.Drawing.Point(6, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 81);
            this.panel1.TabIndex = 10;
            // 
            // cboPrecio
            // 
            this.cboPrecio.FormattingEnabled = true;
            this.cboPrecio.Location = new System.Drawing.Point(435, 39);
            this.cboPrecio.Name = "cboPrecio";
            this.cboPrecio.Size = new System.Drawing.Size(121, 21);
            this.cboPrecio.TabIndex = 7;
            // 
            // lbOrdenarPrecio
            // 
            this.lbOrdenarPrecio.AutoSize = true;
            this.lbOrdenarPrecio.Location = new System.Drawing.Point(389, 42);
            this.lbOrdenarPrecio.Name = "lbOrdenarPrecio";
            this.lbOrdenarPrecio.Size = new System.Drawing.Size(40, 13);
            this.lbOrdenarPrecio.TabIndex = 6;
            this.lbOrdenarPrecio.Text = "Precio:";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(74, 39);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 5;
            // 
            // lbOrdenarCategoria
            // 
            this.lbOrdenarCategoria.AutoSize = true;
            this.lbOrdenarCategoria.Location = new System.Drawing.Point(201, 42);
            this.lbOrdenarCategoria.Name = "lbOrdenarCategoria";
            this.lbOrdenarCategoria.Size = new System.Drawing.Size(55, 13);
            this.lbOrdenarCategoria.TabIndex = 4;
            this.lbOrdenarCategoria.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(262, 39);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 3;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(562, 37);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lbOrdenarMarca
            // 
            this.lbOrdenarMarca.AutoSize = true;
            this.lbOrdenarMarca.Location = new System.Drawing.Point(33, 42);
            this.lbOrdenarMarca.Name = "lbOrdenarMarca";
            this.lbOrdenarMarca.Size = new System.Drawing.Size(40, 13);
            this.lbOrdenarMarca.TabIndex = 1;
            this.lbOrdenarMarca.Text = "Marca:";
            // 
            // lbordenarpor
            // 
            this.lbordenarpor.AutoSize = true;
            this.lbordenarpor.Location = new System.Drawing.Point(3, 0);
            this.lbordenarpor.Name = "lbordenarpor";
            this.lbordenarpor.Size = new System.Drawing.Size(66, 13);
            this.lbordenarpor.TabIndex = 0;
            this.lbordenarpor.Text = "Ordenar por:";
            // 
            // btnBusquedaRapida
            // 
            this.btnBusquedaRapida.Location = new System.Drawing.Point(200, 11);
            this.btnBusquedaRapida.Name = "btnBusquedaRapida";
            this.btnBusquedaRapida.Size = new System.Drawing.Size(75, 23);
            this.btnBusquedaRapida.TabIndex = 9;
            this.btnBusquedaRapida.Text = "Buscar";
            this.btnBusquedaRapida.UseVisualStyleBackColor = true;
            this.btnBusquedaRapida.Click += new System.EventHandler(this.btnBusquedaRapida_Click);
            // 
            // pbxImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 541);
            this.Controls.Add(this.gbFiltrosDB);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvBasedeDatos);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1008, 580);
            this.MinimumSize = new System.Drawing.Size(1008, 580);
            this.Name = "pbxImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasedeDatos)).EndInit();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.gbFiltrosDB.ResumeLayout(false);
            this.gbFiltrosDB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBasedeDatos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton TsbAgregar;
        private System.Windows.Forms.ToolStripButton TsbModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbEliminarArticulo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbImagen;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label lbBusquedaRapida;
        private System.Windows.Forms.TextBox tbxBusquedaRapida;
        private System.Windows.Forms.GroupBox gbFiltrosDB;
        private System.Windows.Forms.Button btnBusquedaRapida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lbOrdenarCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lbOrdenarMarca;
        private System.Windows.Forms.Label lbordenarpor;
        private System.Windows.Forms.ComboBox cboPrecio;
        private System.Windows.Forms.Label lbOrdenarPrecio;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsbCategoria;
        private System.Windows.Forms.ToolStripButton tsbMarcas;
    }
}

