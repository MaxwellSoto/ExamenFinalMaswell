using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace proyectoFinal.CLogica
{
    public class ConexionBD
    {
        private SqlConnection conexion;

        public ConexionBD(string server, string database, string username, string password)
        {
           
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = localhost; 
            builder.InitialCatalog = examenfinal;
            builder.UserID = maswell; 
            builder.Password = maswell2024; 
            connectionString = builder.ConnectionString;
        }

        public DataTable EjecutarConsulta(string consulta)
        {
            DataTable tabla = new DataTable();

            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                Console.WriteLine("Error al ejecutar consulta: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return tabla;
        }

        public void EjecutarComando(string comando)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Manejar excepciones
                Console.WriteLine("Error al ejecutar comando: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}