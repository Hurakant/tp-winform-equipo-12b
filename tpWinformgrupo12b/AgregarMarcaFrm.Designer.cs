namespace tpWinformgrupo12b
{
    partial class AgregarMarcaFrm
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
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnAceptarMarca = new System.Windows.Forms.Button();
            this.txtNomMarca = new System.Windows.Forms.TextBox();
            this.lblNomMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(298, 122);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(78, 28);
            this.btnCancelarMarca.TabIndex = 12;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // btnAceptarMarca
            // 
            this.btnAceptarMarca.Location = new System.Drawing.Point(65, 122);
            this.btnAceptarMarca.Name = "btnAceptarMarca";
            this.btnAceptarMarca.Size = new System.Drawing.Size(81, 28);
            this.btnAceptarMarca.TabIndex = 11;
            this.btnAceptarMarca.Text = "Aceptar";
            this.btnAceptarMarca.UseVisualStyleBackColor = true;
            this.btnAceptarMarca.Click += new System.EventHandler(this.btnAceptarMarca_Click);
            // 
            // txtNomMarca
            // 
            this.txtNomMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNomMarca.Location = new System.Drawing.Point(245, 36);
            this.txtNomMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomMarca.Name = "txtNomMarca";
            this.txtNomMarca.Size = new System.Drawing.Size(160, 22);
            this.txtNomMarca.TabIndex = 9;
            // 
            // lblNomMarca
            // 
            this.lblNomMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNomMarca.AutoSize = true;
            this.lblNomMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomMarca.Location = new System.Drawing.Point(28, 36);
            this.lblNomMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomMarca.Name = "lblNomMarca";
            this.lblNomMarca.Size = new System.Drawing.Size(209, 22);
            this.lblNomMarca.TabIndex = 10;
            this.lblNomMarca.Text = "Nombre de la Marca:";
            // 
            // AgregarMarcaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 194);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAceptarMarca);
            this.Controls.Add(this.txtNomMarca);
            this.Controls.Add(this.lblNomMarca);
            this.MaximumSize = new System.Drawing.Size(486, 241);
            this.MinimumSize = new System.Drawing.Size(486, 241);
            this.Name = "AgregarMarcaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarMarcaFrm";
            this.Load += new System.EventHandler(this.AgregarMarcaFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnAceptarMarca;
        private System.Windows.Forms.TextBox txtNomMarca;
        private System.Windows.Forms.Label lblNomMarca;
    }
}