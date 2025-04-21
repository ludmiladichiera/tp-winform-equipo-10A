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

        
        public frmAgregarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoría";
            label1.Text = "Modificar categoría";
        }

        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null) 
            {
                txtDescripcion.Text = categoria.Descripcion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
              
                if (categoria == null)
                    categoria = new Categoria();

                categoria.Descripcion = txtDescripcion.Text;

                if (categoria.Id != 0) 
                {
                    negocio.Modificar(categoria);
                    MessageBox.Show("¡Categoría modificada exitosamente!");
                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show("¡Categoría agregada exitosamente!");
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