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
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTituloAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            cboMarca.Items.Add("Samsung");
            cboMarca.Items.Add("Sony");
            cboMarca.Items.Add("Apple");

            cboCategoria.Items.Add("Celulares");
            cboCategoria.Items.Add("Media");
            cboCategoria.Items.Add("Televisores");
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                nuevoArticulo.Codigo = txtCodigo.Text;
                nuevoArticulo.Nombre = txtNombre.Text;
                nuevoArticulo.Descripcion = txtDescripcion.Text;
                nuevoArticulo.Marca = (Marca)cboMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);

                negocio.agregar(nuevoArticulo);
                MessageBox.Show("Agregado exitosamente!");
                Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
//Celulares
//Media
//Televisores