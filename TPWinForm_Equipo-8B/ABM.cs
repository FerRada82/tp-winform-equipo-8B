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
            ;
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
            ArticuloNegocio xarticuloNegocio = new ArticuloNegocio();

            try
            {

                if (articulo == null)
                    articulo = new Articulo();
                    articulo.Codigo      = fcodigo.Text;
                    articulo.Nombre      = fnombre.Text;
                    articulo.Marca       = (Marca)fmarca.SelectedItem;
                    articulo.Categoria   = (Categoria)fcategoria.SelectedItem;
                    articulo.Descripcion = fdescripcion.Text;
                    articulo.Precio      = decimal.Parse(fprecio.Text);

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
                MessageBox.Show(ex.ToString());
                // throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
