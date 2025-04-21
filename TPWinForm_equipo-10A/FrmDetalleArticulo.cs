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
    public partial class FrmDetalleArticulo : Form
    {
        private Articulo articuloSeleccionado;
        private int indiceImagen = 0;

        public FrmDetalleArticulo()
        {
            InitializeComponent();
        }

        private void FrmDetalleArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.listar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                ImagenNegocio imagenNegocio = new ImagenNegocio();
                articuloSeleccionado.Imagenes = imagenNegocio.listar(articuloSeleccionado.Id);

                indiceImagen = 0;
                mostrarImagen();
            }
        }

        private void mostrarImagen()
        {
            if (articuloSeleccionado.Imagenes != null && articuloSeleccionado.Imagenes.Count > 0)
            {
                string url = articuloSeleccionado.Imagenes[indiceImagen].ImagenUrl;

                try
                {
                    if (!string.IsNullOrWhiteSpace(url) && Uri.IsWellFormedUriString(url, UriKind.Absolute))
                        pbxArticulo.Load(url);
                    else
                        pbxArticulo.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
                }
                catch
                {
                    pbxArticulo.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
                }
            }
            else
            {
                pbxArticulo.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (articuloSeleccionado != null && articuloSeleccionado.Imagenes != null && articuloSeleccionado.Imagenes.Count > 0)
            {
                indiceImagen--;
                if (indiceImagen < 0)
                    indiceImagen = articuloSeleccionado.Imagenes.Count - 1;

                mostrarImagen();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (articuloSeleccionado != null && articuloSeleccionado.Imagenes != null && articuloSeleccionado.Imagenes.Count > 0)
            {
                indiceImagen++;
                if (indiceImagen >= articuloSeleccionado.Imagenes.Count)
                    indiceImagen = 0;

                mostrarImagen();
            }
        }

        private void pbxArticulo_Click(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.RowIndex >= 0)
            {
                var articuloSeleccionado = (Articulo)dgvArticulos.Rows[e.RowIndex].DataBoundItem;

                MessageBox.Show($"Artículo seleccionado: {articuloSeleccionado.Nombre}");
            }*/
        }
    }
}