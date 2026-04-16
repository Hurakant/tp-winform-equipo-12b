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
            this.dgvBasedeDatos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasedeDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBasedeDatos
            // 
            this.dgvBasedeDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBasedeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasedeDatos.Location = new System.Drawing.Point(15, 14);
            this.dgvBasedeDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBasedeDatos.Name = "dgvBasedeDatos";
            this.dgvBasedeDatos.RowHeadersWidth = 51;
            this.dgvBasedeDatos.RowTemplate.Height = 24;
            this.dgvBasedeDatos.Size = new System.Drawing.Size(897, 270);
            this.dgvBasedeDatos.TabIndex = 0;
            this.dgvBasedeDatos.SelectionChanged += new System.EventHandler(this.dgvBasedeDatos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(949, 24);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(315, 311);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 312);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pbxImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 545);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvBasedeDatos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pbxImagen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasedeDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBasedeDatos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAgregar;
    }
}

