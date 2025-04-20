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
    public partial class frmAgregarMarcas : Form
    {
        public frmAgregarMarcas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                nuevaMarca.Descripcion=txtDescripcion.Text;
                negocio.agregar(nuevaMarca);
                MessageBox.Show("Marca agregada exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
