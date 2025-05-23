using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace TPWinForm_Equipo_8B
{
    public partial class Marcas : Form
    {

        private Marca marca = null;
        private List<Marca> listaMarca;
        private int _idMarca;
        public Marcas()
        {
            InitializeComponent();
        }

        public void Marcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            listaMarca = negocio.Lista();
            dgvMarcas.DataSource = listaMarca;
            dgvMarcas.Columns["Id"].Visible = false;
        }
        private void fagregar_Click(object sender, EventArgs e)
        {
            MarcaNegocio ximagenNegocio = new MarcaNegocio();
            marca = new Marca();


            marca.Descripcion = fmarca.Text.Trim();
            


            if (marca.Descripcion != "")
            {
                ximagenNegocio.agregar(marca);
                MessageBox.Show("Agregado exitosamente");
                cargar();
            }
            else
            {
                MessageBox.Show("Agregar una marca por favor");
            }
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            listaMarca = negocio.Lista();
            dgvMarcas.DataSource = listaMarca;
            dgvMarcas.Columns["Id"].Visible = false;
        }*/

        private void fmodificar_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            ModiMarca formularioM = new ModiMarca(seleccionado);
            formularioM.ShowDialog();
            cargar();
        }

        private void newMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void feliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            Marca seleccionado;

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
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
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
