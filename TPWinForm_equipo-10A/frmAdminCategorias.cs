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
    public partial class frmAdminCategorias : Form
    {
        public frmAdminCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregarCategorias_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria ventana = new frmAgregarCategoria();
            ventana.ShowDialog();
            cargarArticulos();
        }

        private void btnEliminarCategorias_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;
            try
            {
                seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                negocio.eliminarCategorias(seleccionado.Id);
                MessageBox.Show("Marca eliminada correctamente");
                cargarArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        private void frmAdminCategorias_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void cargarArticulos()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = negocio.listar();
        }

    }
}
