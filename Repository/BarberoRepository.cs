using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MapacheBigoton.Repository
{
    public class BarberoRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public BarberoRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public List<Barber> ObtenerBarberos(int idSucursal)
        {
            List<Barber> barbers = new List<Barber>();

            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string query = "SELECT * FROM TBBarbero WHERE idSucursal = " + idSucursal;

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Barber barber = new Barber
                    {
                        IdBarbero = reader.GetInt32(0),
                        IdSucursal = reader.GetInt32(1),
                        NombreBarbero = reader.GetString(2)
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
                    string query = "INSERT INTO TBBarbero (idSucursal, NombreBarbero) VALUES (@idSucursal, @NombreBarbero)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@idSucursal", barber.IdSucursal);
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

        public Barber ObtenerBarbero(int idBarbero, int idSucursal)
        {
            Barber barber = new Barber();
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("BuscarBarbero", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idBarbero", SqlDbType.Int).Value = idBarbero;
                    cmd.Parameters.Add("@idSucursal", SqlDbType.Int).Value = idSucursal;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            barber.IdBarbero = reader.GetInt32(0);
                            barber.IdSucursal = reader.GetInt32(1);
                            barber.NombreBarbero = reader.GetString(2);

                        }
                    }
                }

            }
            return barber;
        }
    }
}