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

        public List<Cita> ObtenerCitas(int idSucursal)
        {
            List<Cita> citas = new List<Cita>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT * FROM TBCita WHERE idSucursal = " + idSucursal;

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cita cita = new Cita
                    {
                        IdCita = reader.GetInt32(0),
                        idClient = reader.GetInt32(1) ,
                        idBarber = reader.GetInt32(2) ,
                        idService = reader.GetInt32(3) , 
                        IdSucursal = reader.GetInt32(4),
                        Hora = reader.GetTimeSpan(5),
                        Fecha = reader.GetDateTime(6),

                    };

                    citas.Add(cita);
                }
            }

            return citas;
        }
        public void AgregarCita(TimeSpan Hora, DateTime Fecha, int idCliente, int idBarbero, int idServicio, int idSucursal)
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
                    cmd.Parameters.Add("@idSucursal", SqlDbType.Int).Value = idSucursal;
                    cmd.ExecuteNonQuery();
                }
                
                
            }
        }

    }


}
