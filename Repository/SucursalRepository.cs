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
    public class SucursalRepository
    {
        private readonly DatabaseConnection _databaseConnection;

        public SucursalRepository(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public List<Sucursal> ObtenerSucursales()
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("Sucursales", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        Sucursal sucursal = new Sucursal
                        {
                            IdSucursal = reader.GetInt32(0),
                            NombreSucursal = reader.GetString(1),
                            Estado = reader.GetString(2),
                            Municipio = reader.GetString(3),
                            Calle = reader.GetString(4)
                        };
                        sucursales.Add(sucursal);
                        Console.WriteLine(sucursal.ToString());
                    }
                }
            }
            return sucursales;
        }

        public Sucursal ObtenerSucursal(int idSucursal)
        {
            Sucursal sucursal = null;
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                using(SqlCommand cmd = new SqlCommand("BuscarSucursal"))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@idSucursal", System.Data.SqlDbType.Int).Value = idSucursal;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        sucursal = new Sucursal
                        {
                            IdSucursal = reader.GetInt32(0),
                            NombreSucursal = reader.GetString(1),
                            Estado = reader.GetString(2),
                            Municipio = reader.GetString(3),
                            Calle = reader.GetString(4)
                        };
                        
                    }
                }
            }
            return sucursal;
        }

        public void InsertarSucursal(Sucursal sucursal)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                using(SqlCommand cmd = new SqlCommand("InsertarSucursal", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@NombreSucursal", SqlDbType.Int).Value = sucursal.NombreSucursal;
                    cmd.Parameters.Add("@Estado", SqlDbType.VarChar, 30).Value = sucursal.Estado;
                    cmd.Parameters.Add("@Municipio", SqlDbType.VarChar, 30).Value = sucursal.Municipio;
                    cmd.Parameters.Add("@Calle", SqlDbType.VarChar, 30).Value = sucursal.Calle;
                    cmd.ExecuteNonQuery();

                }
            }
        }

    }
}
