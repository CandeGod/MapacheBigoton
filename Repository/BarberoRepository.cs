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
    public class BarberoRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public BarberoRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public List<Barber> ObtenerBarberos()
        {
            List<Barber> barbers = new List<Barber>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = "SELECT B.NombreBarbero, C.IdBarbero " +
                               "FROM TBBarbero C " +
                               "JOIN TBBarbero CL ON C.IdBarbero = CL.IdBarbero " +
                               "JOIN TBBarbero B ON C.IdBarbero = B.IdBarbero";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Barber barber = new Barber
                    {
                        NombreBarbero = reader.GetString(0),
                        IdBarbero = reader.GetInt32(1)
                    };

                    barbers.Add(barber);
                }
            } // La conexión se cierra automáticamente aquí

            return barbers;
        }

        public void AgregarBarbero(Barber barber)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string query = "INSERT INTO TBBarbero (NombreBarbero) VALUES (@NombreBarbero)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombreBarbero", barber.NombreBarbero);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejo de la excepción
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            } // La conexión se cierra automáticamente aquí
        }
    }
}