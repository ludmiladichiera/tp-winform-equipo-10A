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
    public partial class frmAdminArticulos : Form
    {
        public frmAdminArticulos()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminMarcas_Click(object sender, EventArgs e) //agregar articulo (no me deja cambiar el nombre :( )
        {
            frmAgregarArticulo ventana = new frmAgregarArticulo();
            ventana.ShowDialog();
        }

        private void btnAdminArticulos_Click(object sender, EventArgs e)
        {

        }

        private void btnListadoArticulos_Click(object sender, EventArgs e)
        {
            FrmDetalleArticulo ventana = new FrmDetalleArticulo();
            ventana.ShowDialog();
        }

        private void btnModificarArticulos_Click(object sender, EventArgs e)
        {
            //Articulo seleccionado;
            //seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            
            frmAgregarArticulo ventana = new frmAgregarArticulo();
            ventana.ShowDialog();
        }
    }
}
