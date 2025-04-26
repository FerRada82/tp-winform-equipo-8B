﻿using System;
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
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALAGO_P3_DB; integrated securty=true; "
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

                return lista;   

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

    }
}
