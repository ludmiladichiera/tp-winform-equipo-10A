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

        
        public frmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
            label1.Text = "Modificar marca";
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {
            if (marca != null) 
            {
                txtDescripcion.Text = marca.Descripcion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                
                if (marca == null)
                    marca = new Marca();

                marca.Descripcion = txtDescripcion.Text;

                if (marca.Id != 0)
                {
                    negocio.Modificar(marca);
                    MessageBox.Show("¡Marca modificada exitosamente!");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("¡Marca agregada exitosamente!");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}