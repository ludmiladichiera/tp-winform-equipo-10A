using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_10A
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void administrarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminArticulos ventana = new frmAdminArticulos();
            ventana.ShowDialog();
        }

        private void btnAdminArticulos_Click(object sender, EventArgs e)
        {
            frmAdminArticulos ventana = new frmAdminArticulos();
            ventana.ShowDialog();
        }

        private void administrarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminMarcas ventana= new frmAdminMarcas();
            ventana.ShowDialog();
        }
        private void btnAdminMarcas_Click(object sender, EventArgs e)
        {
            frmAdminMarcas ventana = new frmAdminMarcas();
            ventana.ShowDialog();
        }

        private void administrarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminCategorias ventana= new frmAdminCategorias();
            ventana.ShowDialog();
        }

        private void btnAdminCategoria_Click(object sender, EventArgs e)
        {
            frmAdminCategorias ventana = new frmAdminCategorias();
            ventana.ShowDialog();
        }

    }
}
