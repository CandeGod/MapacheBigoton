using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using System;
using System.Collections.Generic;
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

    }
}
