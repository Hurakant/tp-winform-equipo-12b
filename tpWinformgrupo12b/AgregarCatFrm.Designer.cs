namespace tpWinformgrupo12b
{
    partial class AgregarCatFrm
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
            this.txtNomCat = new System.Windows.Forms.TextBox();
            this.lblNomCat = new System.Windows.Forms.Label();
            this.btnAceptarCat = new System.Windows.Forms.Button();
            this.btnCancelarCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomCat
            // 
            this.txtNomCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNomCat.Location = new System.Drawing.Point(303, 71);
            this.txtNomCat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomCat.Name = "txtNomCat";
            this.txtNomCat.Size = new System.Drawing.Size(160, 22);
            this.txtNomCat.TabIndex = 5;
            // 
            // lblNomCat
            // 
            this.lblNomCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNomCat.AutoSize = true;
            this.lblNomCat.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCat.Location = new System.Drawing.Point(50, 69);
            this.lblNomCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomCat.Name = "lblNomCat";
            this.lblNomCat.Size = new System.Drawing.Size(245, 22);
            this.lblNomCat.TabIndex = 6;
            this.lblNomCat.Text = "Nombre de la Categoria:";
            // 
            // btnAceptarCat
            // 
            this.btnAceptarCat.Location = new System.Drawing.Point(132, 157);
            this.btnAceptarCat.Name = "btnAceptarCat";
            this.btnAceptarCat.Size = new System.Drawing.Size(81, 28);
            this.btnAceptarCat.TabIndex = 7;
            this.btnAceptarCat.Text = "Aceptar";
            this.btnAceptarCat.UseVisualStyleBackColor = true;
            this.btnAceptarCat.Click += new System.EventHandler(this.btnAceptarCat_Click);
            // 
            // btnCancelarCat
            // 
            this.btnCancelarCat.Location = new System.Drawing.Point(315, 157);
            this.btnCancelarCat.Name = "btnCancelarCat";
            this.btnCancelarCat.Size = new System.Drawing.Size(78, 28);
            this.btnCancelarCat.TabIndex = 8;
            this.btnCancelarCat.Text = "Cancelar";
            this.btnCancelarCat.UseVisualStyleBackColor = true;
            this.btnCancelarCat.Click += new System.EventHandler(this.btnCancelarCat_Click);
            // 
            // AgregarCatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 233);
            this.Controls.Add(this.btnCancelarCat);
            this.Controls.Add(this.btnAceptarCat);
            this.Controls.Add(this.txtNomCat);
            this.Controls.Add(this.lblNomCat);
            this.MaximumSize = new System.Drawing.Size(560, 280);
            this.MinimumSize = new System.Drawing.Size(560, 280);
            this.Name = "AgregarCatFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCatFrm";
            this.Load += new System.EventHandler(this.AgregarCatFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomCat;
        private System.Windows.Forms.Label lblNomCat;
        private System.Windows.Forms.Button btnAceptarCat;
        private System.Windows.Forms.Button btnCancelarCat;
    }
}