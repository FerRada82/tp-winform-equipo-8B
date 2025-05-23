namespace TPWinForm_Equipo_8B
{
    partial class ModiMarca
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
            this.fmarcamodi = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.GuardarCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fmarcamodi
            // 
            this.fmarcamodi.Location = new System.Drawing.Point(49, 36);
            this.fmarcamodi.Margin = new System.Windows.Forms.Padding(2);
            this.fmarcamodi.Name = "fmarcamodi";
            this.fmarcamodi.Size = new System.Drawing.Size(198, 20);
            this.fmarcamodi.TabIndex = 40;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(165, 71);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // GuardarCat
            // 
            this.GuardarCat.Location = new System.Drawing.Point(49, 71);
            this.GuardarCat.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarCat.Name = "GuardarCat";
            this.GuardarCat.Size = new System.Drawing.Size(82, 28);
            this.GuardarCat.TabIndex = 38;
            this.GuardarCat.Text = "Guardar";
            this.GuardarCat.UseVisualStyleBackColor = true;
            this.GuardarCat.Click += new System.EventHandler(this.GuardarMarca_Click);
            // 
            // ModiMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 135);
            this.Controls.Add(this.fmarcamodi);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.GuardarCat);
            this.Name = "ModiMarca";
            this.Text = "ModiMarca";
            this.Load += new System.EventHandler(this.ModiMarca_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fmarcamodi;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button GuardarCat;
    }
}