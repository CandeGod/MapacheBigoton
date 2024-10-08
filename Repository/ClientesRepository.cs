using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace MapacheBigoton.Repository
{
    public class ClientesRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public ClientesRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        // Método para obtener todos los clientes
        public List<Client> ObtenerClientes()
        {
            List<Client> clientes = new List<Client>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    string query = "SELECT IdCliente, NombreCliente, TelefonoCliente FROM TBCliente";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Client cliente = new Client
                        {
                            IdCliente = reader.GetInt32(0),
                            NombreCliente = reader.GetString(1),
                            TelefonoCliente = reader.GetString(2)
                        };

                        clientes.Add(cliente);
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al obtener clientes: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return clientes;
        }

        // Método para agregar un nuevo cliente
        public void AgregarCliente(Client cliente)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    string query = "INSERT INTO TBCliente (NombreCliente, TelefonoCliente) VALUES (@NombreCliente, @TelefonoCliente)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                    command.Parameters.AddWithValue("@TelefonoCliente", cliente.TelefonoCliente);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al agregar cliente: " + ex.Message);
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
