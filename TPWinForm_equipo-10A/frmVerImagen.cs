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
    public partial class frmVerImagen : Form
    {
        private int idArticulo;
        public frmVerImagen(int idArticulo)
        {
            InitializeComponent();
            this.idArticulo = idArticulo;
        }

        private void frmVerImagen_Load(object sender, EventArgs e)
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<Imagen> imagenes = imagenNegocio.listar(idArticulo);
            dgvImagen.DataSource = imagenes;

        }

        private void dgvImagen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImagen.CurrentRow != null)
            {
                Imagen imagenSeleccionada = (Imagen)dgvImagen.CurrentRow.DataBoundItem;

                try
                {
                    pbxImagen.Load(imagenSeleccionada.ImagenUrl);
                }
                catch
                {
                    pbxImagen.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
                }
            }
        }
        private void cargarImagenes()
        {
            try
            {
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                List<Imagen> listaImagenes = imagenNegocio.listar(idArticulo);
                dgvImagen.DataSource = null; // por las dudas, resetea
                dgvImagen.DataSource = listaImagenes;

                dgvImagen.Columns["Id"].Visible = false;
                dgvImagen.Columns["IdArticulo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las imágenes: " + ex.Message);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarImagen agregarImagen = new frmAgregarImagen(idArticulo);
            agregarImagen.ShowDialog();
            cargarImagenes();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvImagen.CurrentRow != null)
            {
                Imagen imagenSeleccionada = (Imagen)dgvImagen.CurrentRow.DataBoundItem;
                frmAgregarImagen agregarImagen = new frmAgregarImagen(idArticulo, imagenSeleccionada.Id); // Pasamos el idImagen
                agregarImagen.ShowDialog();
                cargarImagenes();  
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una imagen para modificar.");
            }
        }


        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvImagen.CurrentRow != null)
            {
                Imagen imagenSeleccionada = (Imagen)dgvImagen.CurrentRow.DataBoundItem;

                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro que querés eliminar esta imagen?",
                    "Eliminar imagen",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    ImagenNegocio negocio = new ImagenNegocio();
                    negocio.eliminarImagen(imagenSeleccionada.Id);
                    cargarImagenes(); 
                }
            }
        }
    }
}
      
