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

        public int agregarArticuloYDevolverId(Articulo nuevoArticulo)
        {
            int idGenerado;
            SqlConnection conexion = new SqlConnection( "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = @"INSERT INTO Articulos (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) 
                                VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @IdMarca, @IdCategoria);
                                SELECT SCOPE_IDENTITY();";

                comando.Parameters.AddWithValue("@Codigo", nuevoArticulo.Codigo);
                comando.Parameters.AddWithValue("@Nombre", nuevoArticulo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", nuevoArticulo.Descripcion);
                comando.Parameters.AddWithValue("@Precio", nuevoArticulo.Precio);
                comando.Parameters.AddWithValue("@IdMarca", nuevoArticulo.Marca.Id);
                comando.Parameters.AddWithValue("@IdCategoria", nuevoArticulo.Categoria.Id);

                conexion.Open();
                idGenerado = Convert.ToInt32(comando.ExecuteScalar()); //recupero el ID generado

                return idGenerado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        public void agregarImagenUrl(int idArticulo, List<Imagen> imagenes)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                foreach (Imagen imagen in imagenes)
                {
                    datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) " +
                                         "VALUES (@IdArticulo, @ImagenUrl)");
                    datos.setearParametro("@IdArticulo", idArticulo);
                    datos.setearParametro("@ImagenUrl", imagen.ImagenUrl);
                    datos.ejecutarAccion();
                }
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
        public int ObtenerIdPorCodigo(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Id FROM ARTICULOS WHERE Codigo = @Codigo");
                datos.setearParametro("@Codigo", codigo);
                datos.ejecutarLectura();

                //ver
                if (datos.Lector.Read())
                    return (int)datos.Lector["Id"];
                else
                    return -1; // No encontrado
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