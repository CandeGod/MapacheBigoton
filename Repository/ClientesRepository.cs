using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapacheBigoton.Repository
{
    public class ClientesRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public ClientesRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public List<Client> ObtenerClientes(int idSucursal)
        {
            List<Client> clientes = new List<Client>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = "SELECT idCliente, idSucursal, NombreCliente, TelefonoCliente FROM TBCliente WHERE idSucursal = " + idSucursal;

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
                    string query = "INSERT INTO TBCliente (idSucursal, NombreCliente, TelefonoCliente) VALUES (@idSucursal, @NombreCliente, @TelefonoCliente)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idSucursal", cliente.IdSucursal);
                    command.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                    command.Parameters.AddWithValue("@TelefonoCliente", cliente.TelefonoCliente);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
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
