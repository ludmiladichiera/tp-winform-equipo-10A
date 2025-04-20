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
    public partial class frmAgregarCategoria : Form
    {
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        //boton aceptar:
        private void button1_Click(object sender, EventArgs e)
        {
            Categoria nuevaCategoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio(); // para concectar con DB
            try
            {
                nuevaCategoria.Descripcion= txtDescripcion.Text;
                negocio.agregar(nuevaCategoria);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {
           
        }


        //boton cancelar:
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
