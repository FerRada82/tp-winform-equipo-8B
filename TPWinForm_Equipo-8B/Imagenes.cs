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
    public partial class Imagenes : Form
    {
        private Imagen imagen = null;
        private List<Imagen> listaUrl;
        private int _idArticulo;
        public Imagenes()
        {
            InitializeComponent();
            Text = "Agregar/Quitar Imagenes";
        }


        public Imagenes(int idArticulo)
        {
            InitializeComponent();
            _idArticulo = idArticulo;
        }
        private void Imagenes_Load(object sender, EventArgs e)
        {
           // lblIdArticulo.Text = $"ID Artículo: {_idArticulo}"; 
            cargar(); 
        }
        private void cargar()
        {
            ImagenNegocio negocio = new ImagenNegocio();
            listaUrl = negocio.Lista(_idArticulo);
            dgvImagenesUrl.DataSource = listaUrl;
            dgvImagenesUrl.Columns["Id"].Visible = false;
            dgvImagenesUrl.Columns["IdArticulo"].Visible = false;

        }
        private void btnAgregarUrl_Click(object sender, EventArgs e)
        {
     
            ImagenNegocio ximagenNegocio = new ImagenNegocio();

                imagen = new Imagen();


                imagen.ImagenUrl  = fImagenUrl.Text.Trim();
                imagen.IdArticulo = _idArticulo;
              

                if (imagen.ImagenUrl != "")
                {
                    ximagenNegocio.agregar(imagen);
                    MessageBox.Show("Agregado exitosamente");
                    cargar();
                }

            
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
     
            this.Close();
        }

        private void btnQuitarUrl_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();

            Imagen seleccionado;
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
                    seleccionado = (Imagen)dgvImagenesUrl.CurrentRow.DataBoundItem;
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
