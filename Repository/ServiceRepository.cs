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

        public List<Service> ObtenerServicios()
        {
            List<Service> servicios = new List<Service>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "select * from TBServicio;";

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
            return servicios;
        }
    }
}
