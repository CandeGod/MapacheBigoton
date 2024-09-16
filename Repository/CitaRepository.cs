using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace MapacheBigoton.Repository
{
    public class CitaRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public CitaRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public List<Cita> ObtenerCitas()
        {
            List<Cita> citas = new List<Cita>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT C.Fecha, CL.NombreCliente, B.NombreBarbero, S.NombreServicio " +
                               "FROM TBCita C " +
                               "JOIN TBCliente CL ON C.IdCliente = CL.IdCliente " +
                               "JOIN TBBarbero B ON C.IdBarbero = B.IdBarbero " +
                               "JOIN TBServicio S ON C.IdServicio = S.IdServicio";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cita cita = new Cita
                    {

                        Fecha = reader.GetDateTime(0),
                        Client = new Client { NombreCliente = reader.GetString(1) },
                        Barber = new Barber { NombreBarbero = reader.GetString(2) },
                        Service = new Service { NombreServicio = reader.GetString(3) }
                    };

                    citas.Add(cita);
                }
            }

            return citas;
        }
        public void AgregarCita(TimeSpan Hora, DateTime Fecha, int idCliente, int idBarbero, int idServicio)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("InsertarCita", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Hora", SqlDbType.Time).Value = Hora;
                    cmd.Parameters.Add("@Fecha", SqlDbType.Date).Value = Fecha;
                    cmd.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente;
                    cmd.Parameters.Add("@IdBarbero", SqlDbType.Int).Value = idBarbero;
                    cmd.Parameters.Add("@IdServicio", SqlDbType.Int).Value = idServicio;
                    cmd.ExecuteNonQuery();
                }
                
                
            }
        }

    }


}
