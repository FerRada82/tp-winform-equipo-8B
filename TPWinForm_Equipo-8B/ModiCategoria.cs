using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_Equipo_8B
{
    public partial class ModiCategoria : Form
    {
        private Categoria categoria = null;

        public ModiCategoria()
        {
            InitializeComponent();
            Text = "Agregar Categoria";
        }

        public ModiCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
        }
        private void ModiCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                fcatmodi.Text = categoria.Descripcion;
            }
        }

        private void GuardarMarca_Click(object sender, EventArgs e)
        {
            CategoriaNegocio xmarcaNegocio = new CategoriaNegocio();

            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }

                categoria.Descripcion = fcatmodi.Text.Trim();



                if (categoria.Id != 0)
                {
                    xmarcaNegocio.modificar(categoria);
                    MessageBox.Show("Modificado exitosamente");
                }


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
