using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapacheBigoton.Repository
{
    class ClienteRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public ClienteRepository (DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public List<Client> ObtenerClientes()
        {
            List<Client> clientes = new List<Client>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT * FROM TBCliente;";

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

            return clientes;
        }

        public Client ObtenerCliente(string TelefonoCliente)
        {
            Client client = new Client();
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("BuscarCliente", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TelefonoCliente", SqlDbType.VarChar, 10).Value = TelefonoCliente;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            client.IdCliente = reader.GetInt32(0);
                            client.NombreCliente = reader.GetString(1);
                            client.TelefonoCliente = reader.GetString(2);

                        }
                    }
                }

            }
            return client;
        }

    }
}
