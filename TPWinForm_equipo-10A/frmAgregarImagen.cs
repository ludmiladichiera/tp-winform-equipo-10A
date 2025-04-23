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
    public partial class frmAgregarImagen : Form
    {
        private int _nuevoId;
        private int _idArticulo;
        private int? _idImagen;


        public frmAgregarImagen(int nuevoId)
        {
            InitializeComponent();
            _nuevoId = nuevoId; //guarda id
        }
        public frmAgregarImagen(int idArticulo, int? idImagen = null)
        {
            InitializeComponent();
            _idArticulo = idArticulo;
            _idImagen = idImagen;
        }


        private void frmAgregarImagen_Load(object sender, EventArgs e)
        {
            try
            {
                pbxArticulo.Load(txtUrlImagen.Text);
            }
            catch
            {
                pbxArticulo.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            try
            {
                pbxArticulo.Load(txtUrlImagen.Text);
            }
            catch
            {
                pbxArticulo.Load("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk=");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            Imagen nuevaImagen = new Imagen();

            nuevaImagen.IdArticulo = _nuevoId;
            nuevaImagen.ImagenUrl = txtUrlImagen.Text;

            negocio.Agregar(nuevaImagen);

            MessageBox.Show("Imagen agregada con éxito.");
            Close(); // LUDMIII ACA EN VEZ DE QUE SE CIERRE HAY QUE HACER QUE PREGUNTE SI SE QUIERE AGREGAR OTRA IMAGEN MAS
        }
    }
}
