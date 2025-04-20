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

namespace TPWinForm_equipo_10A
{
    public partial class frmAdminMarcas : Form
    {
        public frmAdminMarcas()
        {
            InitializeComponent();
        }

        private void btnAgregarMarcas_Click(object sender, EventArgs e)
        {
            frmAgregarMarcas ventana = new frmAgregarMarcas();
            ventana.ShowDialog();
            cargarArticulos();
        }

        private void btnEliminarMarcas_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            try
            {
                seleccionado=(Marca)dgvMarcas.CurrentRow.DataBoundItem;
                negocio.eliminarMarcas(seleccionado.Id);
                MessageBox.Show("Marca eliminada correctamente");
                cargarArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        private void frmAdminMarcas_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }
        private void cargarArticulos()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = negocio.listar();
        }

       
    }
}
