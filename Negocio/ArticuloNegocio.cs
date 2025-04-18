using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = (@"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion AS Marca, 
                     A.IdCategoria, C.Descripcion AS Categoria, A.Precio, 
                     MIN(I.ImagenUrl) AS ImagenesUrl
                     FROM ARTICULOS A
                     JOIN MARCAS M ON A.IdMarca = M.Id
                     LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id
                     LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo
                     GROUP BY A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion, A.IdCategoria, C.Descripcion, A.Precio");
                //comando.CommandText = "SELECT A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.Precio FROM ARTICULOS A LEFT JOIN MARCAS M ON M.Id = A.IdMarca LEFT JOIN CATEGORIAS C ON C.Id = A.IdCategoria;";
                //comando.CommandText = "Select Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, Precio From ARTICULOS A, MARCAS M, CATEGORIAS C Where M.Id = A.IdMarca AND C.Id = A.IdCategoria";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) //posiciona el puntero
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Precio = (decimal)lector["Precio"];

                    aux.Marca = new Marca();
                    //aux.Marca.Descripcion = (string)lector["Marca"];
                    aux.Marca.Descripcion = lector["Marca"] != DBNull.Value ? lector["Marca"].ToString() : "NO especifica";

                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = lector["Categoria"] != DBNull.Value ? lector["Categoria"].ToString() : "NO especifica";



                    //problemas clase imagen 
                    if (aux.Imagenes == null)
                        aux.Imagenes = new List<Imagen>();

                    if (!(lector["ImagenesUrl"] is DBNull))
                    {
                        aux.Imagenes.Add(new Imagen(lector["ImagenesUrl"].ToString()));
                    }
                    else
                    {
                        aux.Imagenes.Add(new Imagen("https://media.istockphoto.com/id/1128826884/es/vector/ning%C3%BAn-s%C3%ADmbolo-de-vector-de-imagen-falta-icono-disponible-no-hay-galer%C3%ADa-para-este-momento.jpg?s=612x612&w=0&k=20&c=9vnjI4XI3XQC0VHfuDePO7vNJE7WDM8uzQmZJ1SnQgk="));
                    }


                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Articulo nuevo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                //prueba de insert:
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre,Descripcion,IdMarca, IdCategoria,Precio) values ('','','',1,1,60)");

                //insert con datos desde la ventana
                //datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "'," + nuevo.Marca + "," + nuevo.Categoria + "," + nuevo.Precio + ")");

                //pruebas extra:
                //datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (" +
                //nuevo.Codigo + ", '" +
                //nuevo.Nombre.Replace("'", "''") + "', '" +  
                //nuevo.Descripcion.Replace("'", "''") + "', " +
                //nuevo.Marca + ", " +
                //nuevo.Categoria + ", " +
                //nuevo.Precio.ToString(System.Globalization.CultureInfo.InvariantCulture) + ")");


                //            string consulta = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES ("
                //+ nuevo.Codigo + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', " + nuevo.Marca + ", " + nuevo.Categoria + ", " + nuevo.Precio + ")";

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
