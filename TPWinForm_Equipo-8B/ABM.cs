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
    public partial class ABM : Form
    {
        private Articulo articulo = null;

        private bool modoDetalle = false; 
        public ABM()
        {
            InitializeComponent();
            Text = "Agregar Articulo";
        }
        public ABM(Articulo articulo, bool modoDetalle = false)
        {
            InitializeComponent();
            this.articulo = articulo;
            
            this.modoDetalle = modoDetalle; 
            Text = modoDetalle ? "Detalle del Artículo" : "Modificar Artículo";
        }

        private void ABM_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                fmarca.DataSource        = marcaNegocio.Listar();
                fmarca.ValueMember       = "Id";
                fmarca.DisplayMember     = "Descripcion";
                fcategoria.DataSource    = categoriaNegocio.Listar();
                fcategoria.ValueMember   = "Id";
                fcategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    fcodigo.Text = articulo.Codigo;
                    fnombre.Text = articulo.Nombre;
                    fmarca.SelectedValue = articulo.Marca.Id;
                    fcategoria.SelectedValue = articulo.Categoria.Id;
                    fdescripcion.Text = articulo.Descripcion;
                    fprecio.Text = articulo.Precio.ToString();
                }

                if (modoDetalle)
                {
                    ConfigurarModoDetalle();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void ConfigurarModoDetalle()
        {
           
            fcodigo.Enabled = false;
            fnombre.Enabled = false;
            fmarca.Enabled = false;
            fcategoria.Enabled = false;
            fdescripcion.Enabled = false;
            fprecio.Enabled = false;

           
            fcodigo.BackColor = SystemColors.Control;
            fnombre.BackColor = SystemColors.Control;
            fdescripcion.BackColor = SystemColors.Control;
            fprecio.BackColor = SystemColors.Control;

            fagregar.Visible = false;

         
            btnCancelar.Text = "Cerrar";
        }
        private void fagregar_Click(object sender, EventArgs e)
        {
         
            if (!ValidarCampos())
                return;

            ArticuloNegocio xarticuloNegocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

               
                articulo.Codigo = fcodigo.Text.Trim();
                articulo.Nombre = fnombre.Text.Trim();

                if (fmarca.SelectedItem == null || fcategoria.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una marca y una categoría válidas");
                    return;
                }

                articulo.Marca = (Marca)fmarca.SelectedItem;
                articulo.Categoria = (Categoria)fcategoria.SelectedItem;
                articulo.Descripcion = fdescripcion.Text.Trim();

             
                if (!decimal.TryParse(fprecio.Text.Trim(), out decimal precio))
                {
                    MessageBox.Show("Ingrese un valor numérico válido para el precio");
                    return;
                }
                articulo.Precio = precio;

                if (articulo.Id != 0)
                {
                    xarticuloNegocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    xarticuloNegocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el artículo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(fcodigo.Text))
            {
                MessageBox.Show("El código es obligatorio");
                fcodigo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(fnombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                fnombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(fprecio.Text))
            {
                MessageBox.Show("El precio es obligatorio");
                fprecio.Focus();
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
