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
    class BarberoRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public BarberoRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public List<Barber> ObtenerBarberos()
        {
            List<Barber> barberos = new List<Barber>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                string query = "SELECT * FROM TBBarbero;";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Barber barbero = new Barber
                    {
                        IdBarbero = reader.GetInt32(0),
                        NombreBarbero = reader.GetString(1)
                    };

                    barberos.Add(barbero);
                }
            }
            return barberos;
        }
    }
}
