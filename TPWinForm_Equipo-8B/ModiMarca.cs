using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Equipo_8B
{
    public partial class ModiMarca : Form
    {
        private Marca marca = null;

        public ModiMarca()
        {
            InitializeComponent();
            Text = "Agregar Marca";
        }

        public ModiMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void ModiMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                fmarcamodi.Text = marca.Descripcion;
            }

        }
        private void GuardarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio xmarcaNegocio = new MarcaNegocio();

            try
            {
                if (marca == null)
                {
                    marca = new Marca();
                }

                marca.Descripcion = fmarcamodi.Text.Trim();



                if (marca.Id != 0)
                {
                    xmarcaNegocio.modificar(marca);
                    MessageBox.Show("Modificado exitosamente");
                }


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la marca: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void ModiMarca_Load_1(object sender, EventArgs e)
        {
            if (marca != null)
            {
                fmarcamodi.Text = marca.Descripcion;
            }
        }
    }
}
