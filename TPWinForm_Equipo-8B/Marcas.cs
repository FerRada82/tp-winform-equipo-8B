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

namespace TPWinForm_Equipo_8B
{
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        public void Marcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            marcagv.DataSource = marca.listar();
            marcagv.Columns["Id"].Visible = false;
        }

        private void fagregar_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {

                if (newMarca.Text != "")
                {
                    nuevaMarca.Descripcion = newMarca.Text;
                    negocio.agregar(nuevaMarca);
                    //// NO PUEDO AGREGAR UN MENSAJE EN PANTALLA SI LA MARCA YA EXISTE, SIEMPRE QUE LLEGA ACA DICE QUE SE AGREGO!!
                    MessageBox.Show("La marca fue agregada exitosamente!");
                    newMarca.Text = ("");
                }
                else
                {
                    MessageBox.Show("Debe completar el campo en blanco para agregar...");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            marcagv.DataSource = null;
            marcagv.DataSource = marca.listar();
            marcagv.Columns["Id"].Visible = false;
        }

        private void fmodificar_Click(object sender, EventArgs e)
        {

        }

    }
}
