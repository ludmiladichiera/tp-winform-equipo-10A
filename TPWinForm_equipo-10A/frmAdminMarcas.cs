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
            frmAgregarMarca ventana = new frmAgregarMarca();
            ventana.ShowDialog();
            cargarDGV();
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
                cargarDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        private void frmAdminMarcas_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }
        private void btnModificarMarcas_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;


            frmAgregarMarca modificar = new frmAgregarMarca(seleccionado);
            modificar.ShowDialog();
            cargarDGV();
        }
        private void cargarDGV()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = negocio.listar();
        }

    }
}
