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
        }

        private void btnEliminarMarcas_Click(object sender, EventArgs e)
        {

        }
    }
}
