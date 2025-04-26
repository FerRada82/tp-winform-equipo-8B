namespace TPWinForm_Equipo_8B
{
    partial class Categorias
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
            this.feliminar = new System.Windows.Forms.Button();
            this.fmodificar = new System.Windows.Forms.Button();
            this.fagregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fguardar
            // 
            this.fguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fguardar.Location = new System.Drawing.Point(96, 141);
            this.fguardar.Margin = new System.Windows.Forms.Padding(2);
            this.fguardar.Name = "fguardar";
            this.fguardar.Size = new System.Drawing.Size(28, 28);
            this.fguardar.TabIndex = 36;
            this.fguardar.UseVisualStyleBackColor = true;
            // 
            // feliminar
            // 
            this.feliminar.Location = new System.Drawing.Point(11, 186);
            this.feliminar.Margin = new System.Windows.Forms.Padding(2);
            this.feliminar.Name = "feliminar";
            this.feliminar.Size = new System.Drawing.Size(80, 28);
            this.feliminar.TabIndex = 35;
            this.feliminar.Text = "Eliminar";
            this.feliminar.UseVisualStyleBackColor = true;
            // 
            // fmodificar
            // 
            this.fmodificar.Location = new System.Drawing.Point(11, 141);
            this.fmodificar.Margin = new System.Windows.Forms.Padding(2);
            this.fmodificar.Name = "fmodificar";
            this.fmodificar.Size = new System.Drawing.Size(80, 28);
            this.fmodificar.TabIndex = 34;
            this.fmodificar.Text = "Modificar";
            this.fmodificar.UseVisualStyleBackColor = true;
            // 
            // fagregar
            // 
            this.fagregar.Location = new System.Drawing.Point(11, 100);
            this.fagregar.Margin = new System.Windows.Forms.Padding(2);
            this.fagregar.Name = "fagregar";
            this.fagregar.Size = new System.Drawing.Size(80, 28);
            this.fagregar.TabIndex = 33;
            this.fagregar.Text = "Agregar";
            this.fagregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(180, 202);
            this.dataGridView1.TabIndex = 32;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 329);
            this.Controls.Add(this.fguardar);
            this.Controls.Add(this.feliminar);
            this.Controls.Add(this.fmodificar);
            this.Controls.Add(this.fagregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Categorias";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fguardar;
        private System.Windows.Forms.Button feliminar;
        private System.Windows.Forms.Button fmodificar;
        private System.Windows.Forms.Button fagregar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}