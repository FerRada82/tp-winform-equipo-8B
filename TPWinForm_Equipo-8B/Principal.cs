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
        private int indiceImagenActual = 0;
        private Articulo articuloActual;

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


                if (listaArticulo.Count > 0)
                {
                    dgvArticulos.Rows[0].Selected = true;
                    articuloActual = listaArticulo[0];
                    MostrarImagenArticulo(articuloActual);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar artículos: {ex.Message}");
                MostrarImagenPorDefecto();
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                indiceImagenActual = 0;
                MostrarImagenArticulo(articuloActual);
                ActualizarEstadoBotones();
            }
        }

        private void MostrarImagenArticulo(Articulo articulo)
        {
            try
            {
                if (articulo.RutasImagenes != null && articulo.RutasImagenes.Count > 0)
                {
                    
                          pbImagen.Load(articulo.RutasImagenes[indiceImagenActual]);
                        
                }
                else
                {
                    MostrarImagenPorDefecto();
                }
            }
            catch
            {
               // MessageBox.Show($"Error al cargar imagen: {ex.Message}");
                MostrarImagenPorDefecto();
            }
        }

        private void MostrarImagenPorDefecto()
        {
            try
            {
                pbImagen.Load("https://s1.qwant.com/thumbr/474x355/9/c/3a3f18de5d589407b3abcc185fce3e756b9485acad5b920d3d11446c6a2f90/th.jpg?u=https%3A%2F%2Ftse.mm.bing.net%2Fth%3Fid%3DOIP.AhRqkCZNh-f7x1ZEE3G34QHaFj%26pid%3DApi&q=0&b=1&p=0&a=0");
            }
            catch
            {
                pbImagen.Load("https://s1.qwant.com/thumbr/474x355/9/c/3a3f18de5d589407b3abcc185fce3e756b9485acad5b920d3d11446c6a2f90/th.jpg?u=https%3A%2F%2Ftse.mm.bing.net%2Fth%3Fid%3DOIP.AhRqkCZNh-f7x1ZEE3G34QHaFj%26pid%3DApi&q=0&b=1&p=0&a=0");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (articuloActual != null && articuloActual.RutasImagenes != null)
            {
                indiceImagenActual++;
                if (indiceImagenActual >= articuloActual.RutasImagenes.Count)
                {
                    indiceImagenActual = 0;
                }
                MostrarImagenArticulo(articuloActual);
                ActualizarEstadoBotones();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (articuloActual != null && articuloActual.RutasImagenes != null)
            {
                indiceImagenActual--;
                if (indiceImagenActual < 0)
                {
                    indiceImagenActual = articuloActual.RutasImagenes.Count - 1;
                }
                MostrarImagenArticulo(articuloActual);
                ActualizarEstadoBotones();
            }
        }

        private void ActualizarEstadoBotones()
        {

            bool hayImagenes = articuloActual != null &&
                               articuloActual.RutasImagenes != null &&
                               articuloActual.RutasImagenes.Count > 1;

            btnAnterior.Enabled = hayImagenes;
            btnSiguiente.Enabled = hayImagenes;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ABM formularioA = new ABM();
            formularioA.ShowDialog();
            cargar();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Show();
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

        private void btnImagen_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            Imagenes formularioM = new Imagenes(seleccionado.Id);

            formularioM.ShowDialog();
            cargar();
        }

        private void fbuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listasFiltrada;
            String filtro = fbuscar.Text;

            if (filtro != "")
            {
                listasFiltrada = listaArticulo.FindAll(ARTI => ARTI.Nombre.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listasFiltrada = listaArticulo;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listasFiltrada;


        }
    }
}
