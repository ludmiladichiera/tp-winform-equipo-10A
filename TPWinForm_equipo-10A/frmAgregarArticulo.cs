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
        private Articulo articulo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        //para modificar:
        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            txtTituloAgregarArticulo.Text = "Modificar articulo";
            Text = "Modificar Articulo"; //titulo de ventana
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

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboMarca.DataSource = marcaNegocio.listar();

                if (articulo != null)
                {
                    txtCodigo.Text=articulo.Codigo;
                    txtNombre.Text=articulo.Nombre;
                    txtDescripcion.Text=articulo.Descripcion;
                    cboMarca.SelectedItem=articulo.Marca;
                    cboCategoria.SelectedItem=articulo.Categoria;
                    //txtUrlImagen.Text=articulo.Imagenes;
                    txtPrecio.Text=articulo.Precio.ToString();

                    //try
                    //{
                    //    pbxArticulo.Load(txtUrlImagen.Text);
                    //}
                    //catch
                    //{
                    //    pbxArticulo.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
                    //}

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
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
                //aca agregar IMAGEN- video 14
               // nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);

                decimal precio;
                if (!decimal.TryParse(txtPrecio.Text, out precio))
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para el precio.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                nuevoArticulo.Precio = precio;

                nuevoArticulo.Imagenes = new List<Imagen>();

                if (articulo != null && articulo.Id != 0)
                {
                    nuevoArticulo.Id = articulo.Id;
                    negocio.Modificar(nuevoArticulo);
                    MessageBox.Show("Artículo modificado exitosamente!");

                    DialogResult resultado = MessageBox.Show("¿Quieres modificar las imágenes del artículo?", "Modificar Imágenes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {

                        frmAgregarImagen frmImagen = new frmAgregarImagen(nuevoArticulo.Id);
                        frmImagen.ShowDialog();
                    }

                }
                else
                {
                    int nuevoId = negocio.agregarArticuloYDevolverId(nuevoArticulo);
                    MessageBox.Show("Agregado exitosamente!");
                    frmAgregarImagen frmImagen = new frmAgregarImagen(nuevoId);
                    frmImagen.ShowDialog();
                }


                //int nuevoId =negocio.agregarArticuloYDevolverId(nuevoArticulo);
                // MessageBox.Show("Agregado exitosamente!");
                //frmAgregarImagen frmImagen = new frmAgregarImagen(nuevoId);
                //frmImagen.ShowDialog();

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

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    pbxArticulo.Load(txtUrlImagen.Text);
            //}
            //catch
            //{
            //    pbxArticulo.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
            //}
        }
    }
}
//Celulares
//Media
//Televisores