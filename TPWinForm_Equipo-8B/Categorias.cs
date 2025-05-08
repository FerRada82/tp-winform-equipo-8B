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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            dgvCategorias.DataSource = categoria.Listar();
            dgvCategorias.Columns["Id"].Visible = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            /*Categoria nuevacategoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                nuevacategoria.Descripcion = tbxCategoria.Text;
                negocio.a
            }
            catch (Exception)
            {

                throw;
            }*/
        }
    }
}
