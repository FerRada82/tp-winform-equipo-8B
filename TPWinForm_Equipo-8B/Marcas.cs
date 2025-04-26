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
        }
    }
}
