namespace TPWinForm_Equipo_8B
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DgvArtículos = new System.Windows.Forms.DataGridView();
            this.ImagenArt = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArtículos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenArt)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvArtículos
            // 
            this.DgvArtículos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArtículos.Location = new System.Drawing.Point(12, 37);
            this.DgvArtículos.Name = "DgvArtículos";
            this.DgvArtículos.Size = new System.Drawing.Size(496, 150);
            this.DgvArtículos.TabIndex = 0;
            // 
            // ImagenArt
            // 
            this.ImagenArt.Location = new System.Drawing.Point(12, 225);
            this.ImagenArt.Name = "ImagenArt";
            this.ImagenArt.Size = new System.Drawing.Size(167, 117);
            this.ImagenArt.TabIndex = 1;
            this.ImagenArt.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 26);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImagenArt);
            this.Controls.Add(this.DgvArtículos);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArtículos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvArtículos;
        private System.Windows.Forms.PictureBox ImagenArt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

