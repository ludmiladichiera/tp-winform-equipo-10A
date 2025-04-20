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
    public partial class frmAgregarMarca : Form
    {
        private Marca marca = null;
        public frmAgregarMarca()
        {
            InitializeComponent();
        }
        //para modificar:
        public frmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
            label1.Text = "Modificar marca";
        }
        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            
            if (marca != null) // si se toca el boton agregar PRECARGO txtDescripcion
            {
                txtDescripcion.Text = marca.Descripcion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Marca nuevaMarca = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                marca.Descripcion=txtDescripcion.Text;

                if (marca != null && marca.Id != 0) //estoy modificando si id !=0
                {
                    
                    negocio.Modificar(marca);
                    MessageBox.Show("modificado exitosamente!");

                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Agregado exitosamente!");
                }



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
