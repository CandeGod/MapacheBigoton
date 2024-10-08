using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace MapacheBigoton.Repository
{
    public class ServiceRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public ServiceRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        // Método para obtener todos los servicios
        public List<Service> ObtenerServicios()
        {
            List<Service> servicios = new List<Service>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    string query = "SELECT * FROM TBServicio;";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Service servicio = new Service
                        {
                            IdServicio = reader.GetInt32(0),
                            NombreServicio = reader.GetString(1),
                            DescripcionServicio = reader.GetString(2),
                            CostoServicio = reader.GetDecimal(3)
                        };
                        servicios.Add(servicio);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al obtener servicios: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return servicios;
        }
    }
}
