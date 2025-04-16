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

namespace TPWinForm_equipo_10A
{
    public partial class FrmDetalleArticulo : Form
    {
        public FrmDetalleArticulo()
        {
            InitializeComponent();
        }

        private void FrmDetalleArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.listar();


        }
    }
}
