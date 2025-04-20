using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPWinForm_equipo_10A
{
    public partial class frmAgregarCategoria : Form
    {
        private Categoria categoria = null;
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        //para modificar:
        public frmAgregarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
            label1.Text = "Modificar categoria";
        }
        //boton aceptar:
        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                categoria.Descripcion = txtDescripcion.Text;
                if (categoria != null && categoria.Id != 0) //estoy modificando si id !=0
                {

                    negocio.Modificar(categoria);
                    MessageBox.Show("modificado exitosamente!");

                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show("Agregado exitosamente!");
                }



                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null) // si se toca el boton agregar PRECARGO txtDescripcion
            {
                txtDescripcion.Text = categoria.Descripcion;
            }
        }


        //boton cancelar:
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
