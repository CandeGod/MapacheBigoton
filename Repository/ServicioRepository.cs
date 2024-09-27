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
    public class ServicioRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public ServicioRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        // Obtener todos los servicios
        public List<Service> ObtenerServicios()
        {
            List<Service> servicios = new List<Service>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT IdServicio, NombreServicio, DescripcionServicio, CostoServicio FROM TBServicio";

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

        // Obtener un servicio por Id
        public Service ObtenerServicioPorId(int idServicio)
        {
            Service servicio = null;

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT IdServicio, NombreServicio, DescripcionServicio, CostoServicio FROM TBServicio WHERE IdServicio = @IdServicio";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdServicio", idServicio);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    servicio = new Service
                    {
                        IdServicio = reader.GetInt32(0),
                        NombreServicio = reader.GetString(1),
                        DescripcionServicio = reader.GetString(2),
                        CostoServicio = reader.GetDecimal(3)
                    };
                }
            }

            return servicio;
        }

        // Agregar un nuevo servicio
        public void AgregarServicio(Service servicio)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "INSERT INTO TBServicio (NombreServicio, DescripcionServicio, CostoServicio) " +
                               "VALUES (@NombreServicio, @DescripcionServicio, @CostoServicio)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NombreServicio", servicio.NombreServicio);
                command.Parameters.AddWithValue("@DescripcionServicio", servicio.DescripcionServicio);
                command.Parameters.AddWithValue("@CostoServicio", servicio.CostoServicio);

                command.ExecuteNonQuery();
            }
        }

        // Actualizar un servicio existente
        public void ActualizarServicio(Service servicio)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "UPDATE TBServicio SET NombreServicio = @NombreServicio, DescripcionServicio = @DescripcionServicio, CostoServicio = @CostoServicio " +
                               "WHERE IdServicio = @IdServicio";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdServicio", servicio.IdServicio);
                command.Parameters.AddWithValue("@NombreServicio", servicio.NombreServicio);
                command.Parameters.AddWithValue("@DescripcionServicio", servicio.DescripcionServicio);
                command.Parameters.AddWithValue("@CostoServicio", servicio.CostoServicio);

                command.ExecuteNonQuery();
            }
        }

        // Eliminar un servicio por Id
        public void EliminarServicio(int idServicio)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "DELETE FROM TBServicio WHERE IdServicio = @IdServicio";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdServicio", idServicio);

                command.ExecuteNonQuery();
            }
        }
    }
}
