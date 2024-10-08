using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MapacheBigoton.Repository
{
    public class SucursalRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public SucursalRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        // Obtener todas las sucursales
        public List<Sucursal> ObtenerSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                connection.Close();
                string query = "SELECT IdSucursal, Ubicacion, Direccion FROM TBSucursal";
                
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Sucursal sucursal = new Sucursal
                    {
                        IdSucursal = reader.GetInt32(0),
                        UbicacionSucursal = reader.GetString(1),
                        DireccionSucursal = reader.GetString(2)
                    };

                    sucursales.Add(sucursal);
                }
                reader.Close(); // Asegúrate de cerrar el reader
                connection.Close();
            }

            return sucursales;
        }

        // Obtener una sucursal por Id
        public Sucursal ObtenerSucursalPorId(int idSucursal)
        {
            Sucursal sucursal = null;

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT IdSucursal, Ubicacion, Direccion FROM TBSucursal WHERE IdSucursal = @IdSucursal";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdSucursal", idSucursal);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    sucursal = new Sucursal
                    {
                        IdSucursal = reader.GetInt32(0),
                        UbicacionSucursal = reader.GetString(1),
                        DireccionSucursal = reader.GetString(2)
                    };
                }
                reader.Close(); // Asegúrate de cerrar el reader
                connection.Close();
            }

            return sucursal;
        }

        // Agregar una nueva sucursal
        public void AgregarSucursal(Sucursal sucursal)
        {

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                connection.Close();
                connection.Open();
                string query = "INSERT INTO TBSucursal (Ubicacion, Direccion) " +
                               "VALUES (@Ubicacion, @Direccion)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ubicacion", sucursal.UbicacionSucursal);
                command.Parameters.AddWithValue("@Direccion", sucursal.DireccionSucursal);
                
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // Actualizar una sucursal existente
        public void ActualizarSucursal(Sucursal sucursal)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "UPDATE TBSucursal SET Ubicacion = @Ubicacion, Direccion = @Direccion " +
                               "WHERE IdSucursal = @IdSucursal";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ubicacion", sucursal.UbicacionSucursal);
                    command.Parameters.AddWithValue("@Direccion", sucursal.DireccionSucursal);
                    command.Parameters.AddWithValue("@IdSucursal", sucursal.IdSucursal);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


        // Eliminar una sucursal
        public void EliminarSucursal(int idSucursal)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                connection.Close();
                // Abrir la conexión antes de ejecutar el comando
                connection.Open();
        
                string query = "DELETE FROM TBSucursal WHERE IdSucursal = @IdSucursal";
        
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdSucursal", idSucursal);
            
                    // Ejecutar el comando
                    command.ExecuteNonQuery();
                }
        
                // La conexión se cierra automáticamente al salir del bloque using
    }
}

    }
}
