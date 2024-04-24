using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenFinal.CapaLogica
{
    public class Venta_OP
    {

        private readonly string _connectionString;

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable ObtenerVentas()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string procedimiento = "GestionarVentas";
                using (SqlCommand comando = new SqlCommand(procedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@accion", "consultar");
                    conexion.Open();
                    DataTable tabla = new DataTable();
                    tabla.Load(comando.ExecuteReader());
                    return tabla;
                }
            }
        }


        public void AgregarVentas(int ID_Agente, int ID_Cliente, int ID_Casa, int fecha)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string procedimiento = "GestionarVentas";
                using (SqlCommand comando = new SqlCommand(procedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@accion", "agregar");
                    comando.Parameters.AddWithValue("@ID_Agente", ID_Agente);
                    comando.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                    comando.Parameters.AddWithValue("@ID_Casa", ID_Casa);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void BorrarVentas(int id)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string procedimiento = "GestionarVentas";
                using (SqlCommand comando = new SqlCommand(procedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@accion", "borrar");
                    comando.Parameters.AddWithValue("@id", id);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }


        public void ModificarVentas(int id, string nombre, string email, string telefono)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string procedimiento = "GestionarVentas";
                using (SqlCommand comando = new SqlCommand(procedimiento, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@accion", "modificar");
                    comando.Parameters.AddWithValue("@ID_Agente", ID_Agente);
                    comando.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                    comando.Parameters.AddWithValue("@ID_Casa", ID_Casa);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}