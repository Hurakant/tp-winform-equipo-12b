namespace tpWinformgrupo12b
{
    partial class AgregarImagenFrm
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
            this.btnCancelarimg = new System.Windows.Forms.Button();
            this.btnAceptarImg = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURLimg = new System.Windows.Forms.Label();
            this.pbxAgregarImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarimg
            // 
            this.btnCancelarimg.Location = new System.Drawing.Point(241, 285);
            this.btnCancelarimg.Name = "btnCancelarimg";
            this.btnCancelarimg.Size = new System.Drawing.Size(78, 28);
            this.btnCancelarimg.TabIndex = 16;
            this.btnCancelarimg.Text = "Cancelar";
            this.btnCancelarimg.UseVisualStyleBackColor = true;
            this.btnCancelarimg.Click += new System.EventHandler(this.btnCancelarimg_Click);
            // 
            // btnAceptarImg
            // 
            this.btnAceptarImg.Location = new System.Drawing.Point(61, 285);
            this.btnAceptarImg.Name = "btnAceptarImg";
            this.btnAceptarImg.Size = new System.Drawing.Size(81, 28);
            this.btnAceptarImg.TabIndex = 15;
            this.btnAceptarImg.Text = "Aceptar";
            this.btnAceptarImg.UseVisualStyleBackColor = true;
            this.btnAceptarImg.Click += new System.EventHandler(this.btnAceptarImg_Click);
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtURL.Location = new System.Drawing.Point(30, 182);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(320, 22);
            this.txtURL.TabIndex = 13;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // lblURLimg
            // 
            this.lblURLimg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblURLimg.AutoSize = true;
            this.lblURLimg.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURLimg.Location = new System.Drawing.Point(98, 107);
            this.lblURLimg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblURLimg.Name = "lblURLimg";
            this.lblURLimg.Size = new System.Drawing.Size(186, 22);
            this.lblURLimg.TabIndex = 14;
            this.lblURLimg.Text = "URL de la imagen:";
            // 
            // pbxAgregarImg
            // 
            this.pbxAgregarImg.Location = new System.Drawing.Point(405, 47);
            this.pbxAgregarImg.Name = "pbxAgregarImg";
            this.pbxAgregarImg.Size = new System.Drawing.Size(355, 323);
            this.pbxAgregarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAgregarImg.TabIndex = 0;
            this.pbxAgregarImg.TabStop = false;
            this.pbxAgregarImg.WaitOnLoad = true;
            // 
            // AgregarImagenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btnCancelarimg);
            this.Controls.Add(this.btnAceptarImg);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURLimg);
            this.Controls.Add(this.pbxAgregarImg);
            this.MaximumSize = new System.Drawing.Size(818, 445);
            this.MinimumSize = new System.Drawing.Size(818, 445);
            this.Name = "AgregarImagenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarImagenFrm";
            this.Load += new System.EventHandler(this.AgregarImagenFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxAgregarImg;
        private System.Windows.Forms.Button btnCancelarimg;
        private System.Windows.Forms.Button btnAceptarImg;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblURLimg;
    }
}