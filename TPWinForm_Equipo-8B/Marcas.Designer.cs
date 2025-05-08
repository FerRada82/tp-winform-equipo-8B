namespace TPWinForm_Equipo_8B
{
    partial class Marcas
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
            this.fguardar = new System.Windows.Forms.Button();
            this.fagregar = new System.Windows.Forms.Button();
            this.marcagv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.newMarca = new System.Windows.Forms.TextBox();
            this.fmodificar = new System.Windows.Forms.Button();
            this.feliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marcagv)).BeginInit();
            this.SuspendLayout();
            // 
            // fguardar
            // 
            this.fguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fguardar.Location = new System.Drawing.Point(11, 3);
            this.fguardar.Margin = new System.Windows.Forms.Padding(2);
            this.fguardar.Name = "fguardar";
            this.fguardar.Size = new System.Drawing.Size(28, 28);
            this.fguardar.TabIndex = 36;
            this.fguardar.UseVisualStyleBackColor = true;
            // 
            // fagregar
            // 
            this.fagregar.Location = new System.Drawing.Point(11, 36);
            this.fagregar.Margin = new System.Windows.Forms.Padding(2);
            this.fagregar.Name = "fagregar";
            this.fagregar.Size = new System.Drawing.Size(114, 28);
            this.fagregar.TabIndex = 33;
            this.fagregar.Text = "Agregar";
            this.fagregar.UseVisualStyleBackColor = true;
            this.fagregar.Click += new System.EventHandler(this.fagregar_Click);
            // 
            // marcagv
            // 
            this.marcagv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marcagv.Location = new System.Drawing.Point(11, 150);
            this.marcagv.Margin = new System.Windows.Forms.Padding(2);
            this.marcagv.Name = "marcagv";
            this.marcagv.RowHeadersWidth = 51;
            this.marcagv.Size = new System.Drawing.Size(231, 202);
            this.marcagv.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 28);
            this.button1.TabIndex = 37;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newMarca
            // 
            this.newMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.newMarca.Location = new System.Drawing.Point(11, 122);
            this.newMarca.Name = "newMarca";
            this.newMarca.Size = new System.Drawing.Size(231, 23);
            this.newMarca.TabIndex = 38;
            this.newMarca.TextChanged += new System.EventHandler(this.newMarca_TextChanged);
            // 
            // fmodificar
            // 
            this.fmodificar.Location = new System.Drawing.Point(132, 36);
            this.fmodificar.Margin = new System.Windows.Forms.Padding(2);
            this.fmodificar.Name = "fmodificar";
            this.fmodificar.Size = new System.Drawing.Size(110, 28);
            this.fmodificar.TabIndex = 34;
            this.fmodificar.Text = "Modificar";
            this.fmodificar.UseVisualStyleBackColor = true;
            this.fmodificar.Click += new System.EventHandler(this.fmodificar_Click);
            // 
            // feliminar
            // 
            this.feliminar.Location = new System.Drawing.Point(132, 68);
            this.feliminar.Margin = new System.Windows.Forms.Padding(2);
            this.feliminar.Name = "feliminar";
            this.feliminar.Size = new System.Drawing.Size(110, 28);
            this.feliminar.TabIndex = 35;
            this.feliminar.Text = "Eliminar";
            this.feliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Inserte Marca";
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newMarca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fguardar);
            this.Controls.Add(this.feliminar);
            this.Controls.Add(this.fmodificar);
            this.Controls.Add(this.fagregar);
            this.Controls.Add(this.marcagv);
            this.Name = "Marcas";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.Marcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcagv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fguardar;
        private System.Windows.Forms.Button fagregar;
        private System.Windows.Forms.DataGridView marcagv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newMarca;
        private System.Windows.Forms.Button fmodificar;
        private System.Windows.Forms.Button feliminar;
        private System.Windows.Forms.Label label1;
    }
}