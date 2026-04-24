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
            this.tsbCategorias = new System.Windows.Forms.ToolStripButton();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.lbBusquedaRapida = new System.Windows.Forms.Label();
            this.tbxBusquedaRapida = new System.Windows.Forms.TextBox();
            this.gbFiltrosDB = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lbOrdenarPrecio = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbOrdenarCategoria = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lbOrdenarMarca = new System.Windows.Forms.Label();
            this.lbordenarpor = new System.Windows.Forms.Label();
            this.btnBusquedaRapida = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            this.dgvBasedeDatos.Location = new System.Drawing.Point(15, 36);
            this.dgvBasedeDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBasedeDatos.Name = "dgvBasedeDatos";
            this.dgvBasedeDatos.RowHeadersWidth = 51;
            this.dgvBasedeDatos.RowTemplate.Height = 24;
            this.dgvBasedeDatos.Size = new System.Drawing.Size(896, 457);
            this.dgvBasedeDatos.TabIndex = 0;
            this.dgvBasedeDatos.SelectionChanged += new System.EventHandler(this.dgvBasedeDatos_SelectionChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.Location = new System.Drawing.Point(1143, 377);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(129, 28);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Imagen siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnterior.Location = new System.Drawing.Point(1005, 375);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(129, 28);
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
            this.tsbCategorias});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1323, 31);
            this.tsMain.TabIndex = 5;
            this.tsMain.Text = "toolStrip1";
            // 
            // TsbAgregar
            // 
            this.TsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject("TsbAgregar.Image")));
            this.TsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAgregar.Name = "TsbAgregar";
            this.TsbAgregar.Size = new System.Drawing.Size(87, 28);
            this.TsbAgregar.Text = "Agregar";
            this.TsbAgregar.ToolTipText = "Agregar un articulo";
            this.TsbAgregar.Click += new System.EventHandler(this.TsbAgregar_Click);
            // 
            // TsbModificar
            // 
            this.TsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("TsbModificar.Image")));
            this.TsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbModificar.Name = "TsbModificar";
            this.TsbModificar.Size = new System.Drawing.Size(97, 28);
            this.TsbModificar.Text = "Modificar";
            this.TsbModificar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TsbModificar.ToolTipText = "Modificar un articulo";
            this.TsbModificar.Click += new System.EventHandler(this.TsbModificar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // TsbEliminarArticulo
            // 
            this.TsbEliminarArticulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TsbEliminarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("TsbEliminarArticulo.Image")));
            this.TsbEliminarArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEliminarArticulo.Name = "TsbEliminarArticulo";
            this.TsbEliminarArticulo.Size = new System.Drawing.Size(87, 28);
            this.TsbEliminarArticulo.Text = "Eliminar";
            this.TsbEliminarArticulo.ToolTipText = "Eliminar articulo";
            this.TsbEliminarArticulo.Click += new System.EventHandler(this.TsbEliminarArticulo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbCategorias
            // 
            this.tsbCategorias.Image = global::tpWinformgrupo12b.Properties.Resources.ModificarArticulo1;
            this.tsbCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCategorias.Name = "tsbCategorias";
            this.tsbCategorias.Size = new System.Drawing.Size(104, 28);
            this.tsbCategorias.Text = "Categorias";
            this.tsbCategorias.ToolTipText = "Administrar Categorias";
            this.tsbCategorias.Click += new System.EventHandler(this.tsbCategorias_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(955, 33);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(356, 337);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalles.Location = new System.Drawing.Point(1076, 426);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(129, 28);
            this.btnDetalles.TabIndex = 6;
            this.btnDetalles.Text = "Ver detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // lbBusquedaRapida
            // 
            this.lbBusquedaRapida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbBusquedaRapida.AutoSize = true;
            this.lbBusquedaRapida.Location = new System.Drawing.Point(8, 20);
            this.lbBusquedaRapida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBusquedaRapida.Name = "lbBusquedaRapida";
            this.lbBusquedaRapida.Size = new System.Drawing.Size(114, 16);
            this.lbBusquedaRapida.TabIndex = 7;
            this.lbBusquedaRapida.Text = "Busqueda rapida:";
            // 
            // tbxBusquedaRapida
            // 
            this.tbxBusquedaRapida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxBusquedaRapida.Location = new System.Drawing.Point(125, 16);
            this.tbxBusquedaRapida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxBusquedaRapida.Name = "tbxBusquedaRapida";
            this.tbxBusquedaRapida.Size = new System.Drawing.Size(132, 22);
            this.tbxBusquedaRapida.TabIndex = 8;
            // 
            // gbFiltrosDB
            // 
            this.gbFiltrosDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbFiltrosDB.Controls.Add(this.panel1);
            this.gbFiltrosDB.Controls.Add(this.btnBusquedaRapida);
            this.gbFiltrosDB.Controls.Add(this.tbxBusquedaRapida);
            this.gbFiltrosDB.Controls.Add(this.lbBusquedaRapida);
            this.gbFiltrosDB.Location = new System.Drawing.Point(16, 498);
            this.gbFiltrosDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFiltrosDB.Name = "gbFiltrosDB";
            this.gbFiltrosDB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbFiltrosDB.Size = new System.Drawing.Size(895, 156);
            this.gbFiltrosDB.TabIndex = 9;
            this.gbFiltrosDB.TabStop = false;
            this.gbFiltrosDB.Text = "Filtrar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.lbOrdenarPrecio);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.lbOrdenarCategoria);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnOrdenar);
            this.panel1.Controls.Add(this.lbOrdenarMarca);
            this.panel1.Controls.Add(this.lbordenarpor);
            this.panel1.Location = new System.Drawing.Point(8, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 100);
            this.panel1.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(580, 48);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(160, 24);
            this.comboBox3.TabIndex = 7;
            // 
            // lbOrdenarPrecio
            // 
            this.lbOrdenarPrecio.AutoSize = true;
            this.lbOrdenarPrecio.Location = new System.Drawing.Point(519, 52);
            this.lbOrdenarPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrdenarPrecio.Name = "lbOrdenarPrecio";
            this.lbOrdenarPrecio.Size = new System.Drawing.Size(49, 16);
            this.lbOrdenarPrecio.TabIndex = 6;
            this.lbOrdenarPrecio.Text = "Precio:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(99, 48);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // lbOrdenarCategoria
            // 
            this.lbOrdenarCategoria.AutoSize = true;
            this.lbOrdenarCategoria.Location = new System.Drawing.Point(268, 52);
            this.lbOrdenarCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrdenarCategoria.Name = "lbOrdenarCategoria";
            this.lbOrdenarCategoria.Size = new System.Drawing.Size(69, 16);
            this.lbOrdenarCategoria.TabIndex = 4;
            this.lbOrdenarCategoria.Text = "Categoria:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(349, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(749, 46);
            this.btnOrdenar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 28);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // lbOrdenarMarca
            // 
            this.lbOrdenarMarca.AutoSize = true;
            this.lbOrdenarMarca.Location = new System.Drawing.Point(44, 52);
            this.lbOrdenarMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrdenarMarca.Name = "lbOrdenarMarca";
            this.lbOrdenarMarca.Size = new System.Drawing.Size(48, 16);
            this.lbOrdenarMarca.TabIndex = 1;
            this.lbOrdenarMarca.Text = "Marca:";
            // 
            // lbordenarpor
            // 
            this.lbordenarpor.AutoSize = true;
            this.lbordenarpor.Location = new System.Drawing.Point(4, 0);
            this.lbordenarpor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbordenarpor.Name = "lbordenarpor";
            this.lbordenarpor.Size = new System.Drawing.Size(82, 16);
            this.lbordenarpor.TabIndex = 0;
            this.lbordenarpor.Text = "Ordenar por:";
            // 
            // btnBusquedaRapida
            // 
            this.btnBusquedaRapida.Location = new System.Drawing.Point(267, 14);
            this.btnBusquedaRapida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBusquedaRapida.Name = "btnBusquedaRapida";
            this.btnBusquedaRapida.Size = new System.Drawing.Size(100, 28);
            this.btnBusquedaRapida.TabIndex = 9;
            this.btnBusquedaRapida.Text = "Buscar";
            this.btnBusquedaRapida.UseVisualStyleBackColor = true;
            this.btnBusquedaRapida.Click += new System.EventHandler(this.btnBusquedaRapida_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(92, 28);
            this.toolStripButton1.Text = "Recargar";
            this.toolStripButton1.ToolTipText = "Recargar la lista de articulos";
            // 
            // pbxImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 670);
            this.Controls.Add(this.gbFiltrosDB);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvBasedeDatos);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1338, 707);
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
        private System.Windows.Forms.ToolStripButton tsbCategorias;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label lbBusquedaRapida;
        private System.Windows.Forms.TextBox tbxBusquedaRapida;
        private System.Windows.Forms.GroupBox gbFiltrosDB;
        private System.Windows.Forms.Button btnBusquedaRapida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbOrdenarCategoria;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lbOrdenarMarca;
        private System.Windows.Forms.Label lbordenarpor;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lbOrdenarPrecio;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

