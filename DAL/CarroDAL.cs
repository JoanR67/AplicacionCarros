using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models;


namespace DAL
{
    public static class CarroDAL
    {
        private static string connectionString = "Server=DESKTOP-HEAE8BS\\SQLEXPRESS;Database=AplicacionCarros;Trusted_Connection=True;";

        public static List<Carro> ObtenerTodos()
        {
            List<Carro> lista = new List<Carro>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Carros", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Carro c = new Carro
                    {
                        Id = (int)reader["Id"],
                        Marca = reader["Marca"].ToString(),
                        Modelo = reader["Modelo"].ToString(),
                        Año = (int)reader["Año"],
                        Precio = (decimal)reader["Precio"],
                        FechaRegistro = (DateTime)reader["FechaRegistro"]
                    };
                    lista.Add(c);
                }

            }

            return lista;
        }

        public static void Agregar(Carro c)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("InsertarCarro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Marca", c.Marca);
                cmd.Parameters.AddWithValue("@Modelo", c.Modelo);
                cmd.Parameters.AddWithValue("@Año", c.Año);
                cmd.Parameters.AddWithValue("@Precio", c.Precio);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public static bool Editar(Carro c)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("ActualizarCarro", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", c.Id);
                    cmd.Parameters.AddWithValue("@Marca", c.Marca);
                    cmd.Parameters.AddWithValue("@Modelo", c.Modelo);
                    cmd.Parameters.AddWithValue("@Año", c.Año);
                    cmd.Parameters.AddWithValue("@Precio", c.Precio);
                    con.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;  // true si se actualizó al menos un registro
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public static void Eliminar(int id)
        {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("EliminarCarro", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
        }//Fin de método Eliminar
    }//Fin de clase CarroDAL
}//Fin de namespace
