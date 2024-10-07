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

        public List<Client> ObtenerClientes(int idSucursal)
        {
            List<Client> clientes = new List<Client>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT * FROM TBCliente WHERE idSucursal = " + idSucursal;

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Client cliente = new Client
                    {
                        IdCliente = reader.GetInt32(0),
                        IdSucursal = reader.GetInt32(1),
                        NombreCliente = reader.GetString(2),
                        TelefonoCliente = reader.GetString(3)
                    };

                    clientes.Add(cliente);
                }
            }

            return clientes;
        }

        public Client ObtenerCliente(string TelefonoCliente, int idSucursal)
        {
            Client client = new Client();
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("BuscarCliente", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TelefonoCliente", SqlDbType.VarChar, 10).Value = TelefonoCliente;
                    cmd.Parameters.Add("@idSucursal", SqlDbType.Int).Value = idSucursal;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            client.IdCliente = reader.GetInt32(0);
                            client.IdSucursal = reader.GetInt32(1);
                            client.NombreCliente = reader.GetString(2);
                            client.TelefonoCliente = reader.GetString(3);

                        }
                    }
                }

            }
            return client;
        }

        public Client ObtenerClienteSuc(int idCliente, int idSucursal)
        {
            Client client = new Client();
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("BuscarClienteSucursal", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = idCliente;
                    cmd.Parameters.Add("@idSucursal", SqlDbType.Int).Value = idSucursal;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            client.IdCliente = reader.GetInt32(0);
                            client.IdSucursal = reader.GetInt32(1);
                            client.NombreCliente = reader.GetString(2);
                            client.TelefonoCliente = reader.GetString(3);

                        }
                    }
                }

            }
            return client;
        }

    }
}
