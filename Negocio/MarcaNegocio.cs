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
        public List<Marca> Listar()
        {

            List<Marca> lista = new List<Marca>();
            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                Datos.ejecutarLectura();

                while (Datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)Datos.Lector["Id"];
                    aux.Descripcion = (string)Datos.Lector["Descripcion"];

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
                Datos.cerrarConexion();
            }
        }
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

                datos.setearConsulta("Insert into MARCAS (Descripcion)values('" + nuevaMarca.Descripcion + "')");
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

                datos.setearConsulta("Select Id, Descripcion from MARCAS");
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
