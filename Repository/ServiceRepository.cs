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
    class ServiceRepository
    {
        private readonly DatabaseConnection _databaseConnection;
        public ServiceRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public List<Service> ObtenerServicios(int idSucursal)
        {
            List<Service> servicios = new List<Service>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "select * from TBServicio WHERE idSucursal = " + idSucursal;

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Service servicio = new Service
                    {
                        IdServicio = reader.GetInt32(0),
                        IdSucursal = reader.GetInt32(1),
                        NombreServicio = reader.GetString(2),
                        DescripcionServicio = reader.GetString(3),
                        CostoServicio = reader.GetDecimal(4)
                    };
                    servicios.Add(servicio);
                }
            }
            return servicios;
        }
    }
}
