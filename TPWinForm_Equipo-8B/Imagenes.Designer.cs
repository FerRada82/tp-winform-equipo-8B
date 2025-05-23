namespace TPWinForm_Equipo_8B
{
    partial class Imagenes
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
            this.dgvImagenesUrl = new System.Windows.Forms.DataGridView();
            this.btnAgregarUrl = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnQuitarUrl = new System.Windows.Forms.Button();
            this.fImagenUrl = new System.Windows.Forms.TextBox();
            this.lblIdArticulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenesUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImagenesUrl
            // 
            this.dgvImagenesUrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagenesUrl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvImagenesUrl.Location = new System.Drawing.Point(12, 11);
            this.dgvImagenesUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvImagenesUrl.Name = "dgvImagenesUrl";
            this.dgvImagenesUrl.RowHeadersWidth = 51;
            this.dgvImagenesUrl.RowTemplate.Height = 24;
            this.dgvImagenesUrl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImagenesUrl.Size = new System.Drawing.Size(560, 238);
            this.dgvImagenesUrl.TabIndex = 13;
            // 
            // btnAgregarUrl
            // 
            this.btnAgregarUrl.Location = new System.Drawing.Point(12, 326);
            this.btnAgregarUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarUrl.Name = "btnAgregarUrl";
            this.btnAgregarUrl.Size = new System.Drawing.Size(107, 34);
            this.btnAgregarUrl.TabIndex = 33;
            this.btnAgregarUrl.Text = "Agregar";
            this.btnAgregarUrl.UseVisualStyleBackColor = true;
            this.btnAgregarUrl.Click += new System.EventHandler(this.btnAgregarUrl_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(465, 326);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 34);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnQuitarUrl
            // 
            this.btnQuitarUrl.Location = new System.Drawing.Point(148, 326);
            this.btnQuitarUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarUrl.Name = "btnQuitarUrl";
            this.btnQuitarUrl.Size = new System.Drawing.Size(107, 34);
            this.btnQuitarUrl.TabIndex = 35;
            this.btnQuitarUrl.Text = "Quitar";
            this.btnQuitarUrl.UseVisualStyleBackColor = true;
            this.btnQuitarUrl.Click += new System.EventHandler(this.btnQuitarUrl_Click);
            // 
            // fImagenUrl
            // 
            this.fImagenUrl.Location = new System.Drawing.Point(12, 281);
            this.fImagenUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fImagenUrl.Name = "fImagenUrl";
            this.fImagenUrl.Size = new System.Drawing.Size(560, 22);
            this.fImagenUrl.TabIndex = 36;
            // 
            // lblIdArticulo
            // 
            this.lblIdArticulo.AutoSize = true;
            this.lblIdArticulo.Location = new System.Drawing.Point(12, 383);
            this.lblIdArticulo.Name = "lblIdArticulo";
            this.lblIdArticulo.Size = new System.Drawing.Size(77, 16);
            this.lblIdArticulo.TabIndex = 37;
            this.lblIdArticulo.Text = "nro registro:";
            // 
            // Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.lblIdArticulo);
            this.Controls.Add(this.fImagenUrl);
            this.Controls.Add(this.btnQuitarUrl);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarUrl);
            this.Controls.Add(this.dgvImagenesUrl);
            this.Name = "Imagenes";
            this.Text = "Imagenes";
            this.Load += new System.EventHandler(this.Imagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenesUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImagenesUrl;
        private System.Windows.Forms.Button btnAgregarUrl;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnQuitarUrl;
        private System.Windows.Forms.TextBox fImagenUrl;
        private System.Windows.Forms.Label lblIdArticulo;
    }
}