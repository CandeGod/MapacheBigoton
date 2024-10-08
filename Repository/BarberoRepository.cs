using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MapacheBigoton.Class;
using MapacheBigoton.Connection; // Asegúrate de que este namespace tenga la clase Barber

namespace MapacheBigoton.Repository
{
    public class BarberoRepository
    {
        private readonly SqlConnection _connection;

        // Constructor que recibe la conexión a la base de datos
        public BarberoRepository(DatabaseConnection databaseConnection)
        {
            _connection = databaseConnection.GetConnection();
        }

        // Método para obtener barberos por sucursal
        public List<Barber> ObtenerBarberos(int idSucursal)
        {
            _connection.Close();
            var barberos = new List<Barber>();
            string query = "SELECT * FROM TBBarbero WHERE IdSucursal = @IdSucursal";

            using (var command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@IdSucursal", idSucursal);
                _connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var barbero = new Barber
                        {
                            IdBarbero = reader.GetInt32(reader.GetOrdinal("IdBarbero")),
                            NombreBarbero = reader.GetString(reader.GetOrdinal("NombreBarbero")),
                            IdSucursal = reader.GetInt32(reader.GetOrdinal("IdSucursal"))
                        };
                        barberos.Add(barbero);
                    }
                }
                _connection.Close();
            }
            return barberos;
        }

        // Método para agregar un nuevo barbero
        public void AgregarBarbero(Barber barbero)
        {
            string query = "INSERT INTO TBBarbero (NombreBarbero, IdSucursal) " +
                           "VALUES (@NombreBarbero, @IdSucursal)";

            using (var command = new SqlCommand(query, _connection))
            {
                command.Parameters.AddWithValue("@NombreBarbero", barbero.NombreBarbero);
                command.Parameters.AddWithValue("@IdSucursal", barbero.IdSucursal);

                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
        }
    }
}
