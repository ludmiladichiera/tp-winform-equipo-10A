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

namespace TPWinForm_equipo_10A
{
    public partial class FrmDetalleArticulo : Form
    {
        private List<Articulo> listaArticulo;
        public FrmDetalleArticulo()
        {
            InitializeComponent();
        }

        private void FrmDetalleArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = negocio.listar();


        }
    }
}
