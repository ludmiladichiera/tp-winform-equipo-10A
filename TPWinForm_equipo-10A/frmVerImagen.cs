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
    }

}
    
