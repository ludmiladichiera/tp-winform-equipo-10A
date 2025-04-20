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
    public partial class frmAdminArticulos : Form
    {
        public frmAdminArticulos()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminMarcas_Click(object sender, EventArgs e) //agregar articulo (no me deja cambiar el nombre :( )
        {
            frmAgregarArticulo ventana = new frmAgregarArticulo();
            ventana.Show();
            cargarArticulos();
        }

        private void btnAdminArticulos_Click(object sender, EventArgs e)
        {

        }

        private void btnListadoArticulos_Click(object sender, EventArgs e)
        {
            FrmDetalleArticulo ventana = new FrmDetalleArticulo();
            ventana.Show();
            cargarArticulos();
        }

        //para MODIFICAR con los parametros cargados:

        private void btnModificarArticulos_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            
            frmAgregarArticulo modificar = new frmAgregarArticulo(seleccionado);
            modificar.ShowDialog();
            cargarArticulos();
        }



        private void frmAdminArticulos_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }


        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                string imagenUrl = seleccionado.Imagenes != null && seleccionado.Imagenes.Count > 0
                    ? seleccionado.Imagenes[0].ImagenUrl
                    : "https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=";

                try
                {
                    pbxArticulo.Load(imagenUrl);
                }
                catch
                {

                    pbxArticulo.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
                }
            }
        }

        private void btnEliminarArticulos_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                negocio.EliminarArticulo(seleccionado.Id);
                MessageBox.Show("Articulo eliminado correctamente");
                cargarArticulos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void cargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = negocio.listar();
        }
    }
}
