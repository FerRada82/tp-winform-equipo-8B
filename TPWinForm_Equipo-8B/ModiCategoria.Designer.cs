namespace TPWinForm_Equipo_8B
{
    partial class ModiCategoria
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
            this.fcatmodi = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.GuardarCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fcatmodi
            // 
            this.fcatmodi.Location = new System.Drawing.Point(69, 34);
            this.fcatmodi.Margin = new System.Windows.Forms.Padding(2);
            this.fcatmodi.Name = "fcatmodi";
            this.fcatmodi.Size = new System.Drawing.Size(198, 20);
            this.fcatmodi.TabIndex = 43;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(185, 69);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // GuardarCat
            // 
            this.GuardarCat.Location = new System.Drawing.Point(69, 69);
            this.GuardarCat.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarCat.Name = "GuardarCat";
            this.GuardarCat.Size = new System.Drawing.Size(82, 28);
            this.GuardarCat.TabIndex = 41;
            this.GuardarCat.Text = "Guardar";
            this.GuardarCat.UseVisualStyleBackColor = true;
            this.GuardarCat.Click += new System.EventHandler(this.GuardarMarca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "label1";
            // 
            // ModiCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fcatmodi);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.GuardarCat);
            this.Name = "ModiCategoria";
            this.Text = "ModiCategoria";
            this.Load += new System.EventHandler(this.ModiCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fcatmodi;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button GuardarCat;
        private System.Windows.Forms.Label label1;
    }
}