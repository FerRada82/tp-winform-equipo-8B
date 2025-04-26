using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class MarcaNegocio
    {
        /*
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                //conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALAGO_P3_DB; integrated security=true";
                /// por algun motivo no me funciono con la forma de arriba...
                conexion.ConnectionString = "Data Source = .\\SQLEXPRESS; Initial Catalog =CATALOGO_P3_DB; Integrated Security = true";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Descripcion from MARCAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) {
                
                    Marca aux = new Marca();
                    aux.Id = (int)lector["Id"];
                    aux.Descripcion = (string)lector["Descripcion"];

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
        */
        public void agregar(Marca nuevaMarca)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Marca> lista = new List<Marca>();

            try
            {
                lista = listar();

                foreach (Marca marca in lista) {

                    if(marca.Descripcion == nuevaMarca.Descripcion)
                    {

                        //// NO PUEDO AGREGAR UN MENSAJE EN PANTALLA SOLO EN CONSOLA, LA MARCA YA EXISTE !!!
                        Console.WriteLine("Imposible cargar, ya existe una marca con ese nombre!");
                        return;
                    }
               
                }

                datos.setConsulta("Insert into MARCAS (Descripcion)values('" + nuevaMarca.Descripcion + "')");
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
        public void modificar(Marca modifMarca)
        {

        }
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setConsulta("Select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);

                }
                return lista;

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
