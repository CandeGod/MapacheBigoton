using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MapacheBigoton.Repository
{
    public class ClienteRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public ClienteRepository(DatabaseConnection databaseConnection)
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

                    string query = "SELECT IdCliente, NombreCliente, TelefonoCliente FROM TBCliente;";
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
            }

            return clientes;
        }

        // Método para obtener un cliente por su número de teléfono
        public Client ObtenerCliente(string telefonoCliente)
        {
            Client cliente = null;

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    using (SqlCommand cmd = new SqlCommand("BuscarCliente", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@TelefonoCliente", SqlDbType.VarChar, 10).Value = telefonoCliente;

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows && reader.Read())
                        {
                            cliente = new Client
                            {
                                IdCliente = reader.GetInt32(0),
                                NombreCliente = reader.GetString(1),
                                TelefonoCliente = reader.GetString(2)
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al obtener cliente: " + ex.Message);
                }
            }

            return cliente;
        }
    }
}
