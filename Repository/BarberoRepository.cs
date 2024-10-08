using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MapacheBigoton.Repository
{
    public class BarberoRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public BarberoRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public List<Barber> ObtenerBarberos()
        {
            List<Barber> barbers = new List<Barber>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    // Query simplificado para obtener solo los barberos
                    string query = "SELECT IdBarbero, NombreBarbero FROM TBBarbero";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Barber barber = new Barber
                        {
                            IdBarbero = reader.GetInt32(0),
                            NombreBarbero = reader.GetString(1)
                        };

                        barbers.Add(barber);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al obtener barberos: " + ex.Message);
                }
            }

            return barbers;
        }

        public void AgregarBarbero(Barber barber)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    // Consulta para agregar un nuevo barbero
                    string query = "INSERT INTO TBBarbero (NombreBarbero) VALUES (@NombreBarbero)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombreBarbero", barber.NombreBarbero);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejo de la excepción
                    Console.WriteLine("Error al agregar barbero: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
