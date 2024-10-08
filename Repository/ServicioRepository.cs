using MapacheBigoton.Class;
using MapacheBigoton.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

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
                string query = "SELECT S.IdServicio, S.NombreServicio, S.DescripcionServicio, S.CostoServicio, SU.Ubicacion " +
                               "FROM TBServicio S " +
                               "JOIN TBSucursal SU ON S.IdSucursal = SU.IdSucursal";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Service servicio = new Service
                            {
                                IdServicio = reader.GetInt32(0),
                                NombreServicio = reader.GetString(1),
                                DescripcionServicio = reader.GetString(2),
                                CostoServicio = reader.GetDecimal(3),
                                Sucursal = new Sucursal { UbicacionSucursal = reader.GetString(4) }
                            };

                            servicios.Add(servicio);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al obtener servicios: " + ex.Message);
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
                string query = "SELECT S.IdServicio, S.NombreServicio, S.DescripcionServicio, S.CostoServicio, SU.Ubicacion " +
                               "FROM TBServicio S " +
                               "JOIN TBSucursal SU ON S.IdSucursal = SU.IdSucursal " +
                               "WHERE S.IdServicio = @IdServicio";

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdServicio", idServicio);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            servicio = new Service
                            {
                                IdServicio = reader.GetInt32(0),
                                NombreServicio = reader.GetString(1),
                                DescripcionServicio = reader.GetString(2),
                                CostoServicio = reader.GetDecimal(3),
                                Sucursal = new Sucursal { UbicacionSucursal = reader.GetString(4) }
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al obtener servicio por ID: " + ex.Message);
                }
            }

            return servicio;
        }

        // Agregar un nuevo servicio
        public void AgregarServicio(Service servicio)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("InsertarServicio", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@NombreServicio", SqlDbType.NVarChar).Value = servicio.NombreServicio;
                        cmd.Parameters.Add("@DescripcionServicio", SqlDbType.NVarChar).Value = servicio.DescripcionServicio;
                        cmd.Parameters.Add("@CostoServicio", SqlDbType.Decimal).Value = servicio.CostoServicio;
                        cmd.Parameters.Add("@IdSucursal", SqlDbType.Int).Value = servicio.Sucursal.IdSucursal;

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al agregar servicio: " + ex.Message);
                }
            }
        }

        // Actualizar un servicio existente
        public void ActualizarServicio(Service servicio)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("ActualizarServicio", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@IdServicio", SqlDbType.Int).Value = servicio.IdServicio;
                        cmd.Parameters.Add("@NombreServicio", SqlDbType.NVarChar).Value = servicio.NombreServicio;
                        cmd.Parameters.Add("@DescripcionServicio", SqlDbType.NVarChar).Value = servicio.DescripcionServicio;
                        cmd.Parameters.Add("@CostoServicio", SqlDbType.Decimal).Value = servicio.CostoServicio;
                        cmd.Parameters.Add("@IdSucursal", SqlDbType.Int).Value = servicio.Sucursal.IdSucursal;

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al actualizar servicio: " + ex.Message);
                }
            }
        }

        // Eliminar un servicio
        public void EliminarServicio(int idServicio)
        {
            using (SqlConnection connection = _databaseConnection.GetConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("EliminarServicio", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@IdServicio", SqlDbType.Int).Value = idServicio;

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al eliminar servicio: " + ex.Message);
                }
            }
        }
    }
}
