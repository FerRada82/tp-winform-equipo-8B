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
    public partial class Categorias : Form
    {
        private Categoria categoria = null;
        private List<Categoria> listaCategoria;
        private int _idCategoria;
        public Categorias()
        {
            InitializeComponent();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategoria = negocio.Lista();
            dgvCategorias.DataSource = listaCategoria;
            dgvCategorias.Columns["Id"].Visible = false;
        }
       
        private void btnagregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio ximagenNegocio = new CategoriaNegocio();
            categoria = new Categoria();


            categoria.Descripcion = tbxCategoria.Text.Trim();



            if (categoria.Descripcion != "")
            {
                ximagenNegocio.agregar(categoria);
                MessageBox.Show("Agregado exitosamente");
                cargar();
            }
            else
            {
                MessageBox.Show("Agregar una marca por favor");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            ModiCategoria formularioM = new ModiCategoria(seleccionado);
            formularioM.ShowDialog();
            cargar();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            Categoria seleccionado;

            try
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Desea eliminarlo?",
                    "Eliminando",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
