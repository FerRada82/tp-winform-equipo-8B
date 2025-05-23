namespace TPWinForm_Equipo_8B
{
    partial class ABM
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fdescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fcategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fmarca = new System.Windows.Forms.ComboBox();
            this.fnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fagregar = new System.Windows.Forms.Button();
            this.fprecio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(320, 341);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 34);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F);
            this.label6.Location = new System.Drawing.Point(212, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Precio: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fdescripcion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fcategoria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fmarca);
            this.groupBox1.Controls.Add(this.fnombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fcodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(621, 242);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del producto";
            // 
            // fdescripcion
            // 
            this.fdescripcion.Location = new System.Drawing.Point(107, 140);
            this.fdescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fdescripcion.Multiline = true;
            this.fdescripcion.Name = "fdescripcion";
            this.fdescripcion.Size = new System.Drawing.Size(467, 80);
            this.fdescripcion.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descripción";
            // 
            // fcategoria
            // 
            this.fcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fcategoria.FormattingEnabled = true;
            this.fcategoria.Location = new System.Drawing.Point(401, 102);
            this.fcategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fcategoria.Name = "fcategoria";
            this.fcategoria.Size = new System.Drawing.Size(172, 24);
            this.fcategoria.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca";
            // 
            // fmarca
            // 
            this.fmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fmarca.FormattingEnabled = true;
            this.fmarca.Location = new System.Drawing.Point(107, 102);
            this.fmarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fmarca.Name = "fmarca";
            this.fmarca.Size = new System.Drawing.Size(172, 24);
            this.fmarca.TabIndex = 7;
            // 
            // fnombre
            // 
            this.fnombre.Location = new System.Drawing.Point(107, 69);
            this.fnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fnombre.Name = "fnombre";
            this.fnombre.Size = new System.Drawing.Size(467, 22);
            this.fnombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // fcodigo
            // 
            this.fcodigo.Location = new System.Drawing.Point(107, 34);
            this.fcodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fcodigo.Name = "fcodigo";
            this.fcodigo.Size = new System.Drawing.Size(201, 22);
            this.fcodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // fagregar
            // 
            this.fagregar.Location = new System.Drawing.Point(197, 341);
            this.fagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fagregar.Name = "fagregar";
            this.fagregar.Size = new System.Drawing.Size(107, 34);
            this.fagregar.TabIndex = 27;
            this.fagregar.Text = "Guardar";
            this.fagregar.UseVisualStyleBackColor = true;
            this.fagregar.Click += new System.EventHandler(this.fagregar_Click);
            // 
            // fprecio
            // 
            this.fprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.12F);
            this.fprecio.Location = new System.Drawing.Point(284, 275);
            this.fprecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fprecio.Name = "fprecio";
            this.fprecio.Size = new System.Drawing.Size(134, 27);
            this.fprecio.TabIndex = 30;
            // 
            // ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 398);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fagregar);
            this.Controls.Add(this.fprecio);
            this.Name = "ABM";
            this.Text = "ABM";
            this.Load += new System.EventHandler(this.ABM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fdescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fcategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fmarca;
        private System.Windows.Forms.TextBox fnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fagregar;
        private System.Windows.Forms.TextBox fprecio;
    }
}