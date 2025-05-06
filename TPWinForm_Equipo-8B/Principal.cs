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
    public partial class Principal : Form
    {
        private List<Articulo> listaArticulo;
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulo = negocio.ArticuloLista();

                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["IdMarca"].Visible = false;
                dgvArticulos.Columns["IdCategoria"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABM formularioA = new ABM();
            formularioA.ShowDialog();
            cargar();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
         
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            Marcas marcas = new Marcas();
            marcas.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            ABM formularioM = new ABM(seleccionado);
            formularioM.ShowDialog();
            cargar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            Articulo seleccionado;
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
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Por favor seleccione un artículo", "Advertencia",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            ABM formularioDetalle = new ABM(seleccionado, true); 
            formularioDetalle.ShowDialog();
        }
    }
}
