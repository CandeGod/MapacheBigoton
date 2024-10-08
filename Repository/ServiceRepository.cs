using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MapacheBigoton.Class;
using MapacheBigoton.Connection; // Asegúrate de que este namespace tenga la clase Service

namespace MapacheBigoton.Repository
{
    public class ServiceRepository
    {
        private readonly SqlConnection _connection;

        // Constructor que recibe la conexión a la base de datos
        public ServiceRepository(DatabaseConnection databaseConnection)
        {
            _connection = databaseConnection.GetConnection();
        }

        // Método para obtener servicios por sucursal
        public List<Service> ObtenerServicios(int idSucursal)
        {
            _connection.Close();
            var servicios = new List<Service>();
            string query = "SELECT * FROM TBServicio WHERE IdSucursal = @IdSucursal";

            using (var command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@IdSucursal", idSucursal);
                _connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var servicio = new Service
                        {
                            IdServicio = reader.GetInt32(reader.GetOrdinal("IdServicio")),
                            NombreServicio = reader.GetString(reader.GetOrdinal("NombreServicio")),
                            DescripcionServicio = reader.GetString(reader.GetOrdinal("DescripcionServicio")),
                            CostoServicio = reader.GetDecimal(reader.GetOrdinal("CostoServicio")),
                            IdSucursal = reader.GetInt32(reader.GetOrdinal("IdSucursal"))
                        };
                        servicios.Add(servicio);
                    }
                }
                _connection.Close();
            }
            return servicios;
        }

        // Método para agregar un nuevo servicio
        public void AgregarServicio(Service servicio)
        {
            string query = "INSERT INTO TBServicio (NombreServicio, DescripcionServicio, CostoServicio, IdSucursal) " +
                           "VALUES (@NombreServicio, @DescripcionServicio, @CostoServicio, @IdSucursal)";

            using (var command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@NombreServicio", servicio.NombreServicio);
                command.Parameters.AddWithValue("@DescripcionServicio", servicio.DescripcionServicio);
                command.Parameters.AddWithValue("@CostoServicio", servicio.CostoServicio);
                command.Parameters.AddWithValue("@IdSucursal", servicio.IdSucursal);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
        }
    }
}
