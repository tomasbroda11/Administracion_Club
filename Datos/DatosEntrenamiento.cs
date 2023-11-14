﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosEntrenamiento
    {
        public DatosEntrenamiento() { }

        public Entrenamiento obtenerEntrenamiento(int id)
        {
            Entrenamiento e = null;
            //Abrir conexion
            SqlConnection connection = Conexion.openConection();

            string query = "SELECT * FROM entrenamientos e WHERE e.idEntrenamiento=@Id";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.Read())
                        {
                            int idEntrenamiento = (int)reader["idEntrenamiento"];
                            TimeOnly horaDesde = (TimeOnly)reader["horaDesde"];
                            TimeOnly horaHasta = (TimeOnly)reader["horaHasta"];
                            int dia = (int)reader["dia"];
                            Instalacion ins = new DatosInstalacion().obtenerInstalacionXId((int)reader["idInstalacion"]);
                            Profesor profesor = (Profesor)new DatosPersona().getPersonaByDNI(reader["idProfesor"].ToString());

                            e = new Entrenamiento(idEntrenamiento, horaDesde, horaHasta, dia, ins, profesor);
                        }
                    }
                    catch
                    {
                        Conexion.closeConnection(connection);
                        return null;
                    }
                }
            }
            Conexion.closeConnection(connection);

            return e;
        }
        public bool ExisteEntrenamientoEnFechaYHora(int dia, TimeOnly horaD, TimeOnly horaH, Instalacion instalacion)
        {
            using (SqlConnection connection = Conexion.openConection())
            {
                string query = "SELECT COUNT(*) FROM entrenamientos " +
                               "WHERE dia = @Dia AND horaDesde <= @HoraHasta AND horaHasta > @HoraDesde " +
                               "AND idInstalacion = @InstalacionId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Dia", dia);
                    command.Parameters.AddWithValue("@HoraHasta", horaH);
                    command.Parameters.AddWithValue("@HoraDesde", horaD);
                    command.Parameters.AddWithValue("@InstalacionId", instalacion.getId());

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public void CrearEntrenamiento(Entrenamiento entrenamiento)
        {
            try
            {
                using (SqlConnection connection = Conexion.openConection())
                {
                    string query = "INSERT INTO entrenamientos (horaDesde, horaHasta, dia, idProfesor, idInstalacion) " +
                                   "VALUES (@HoraDesde, @HoraHasta, @Dia, @ProfesorId, @InstalacionId)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HoraDesde", entrenamiento.HoraDesde);
                        command.Parameters.AddWithValue("@HoraHasta", entrenamiento.HoraHasta);
                        command.Parameters.AddWithValue("@Dia", entrenamiento.Dia);
                        command.Parameters.AddWithValue("@ProfesorId", entrenamiento.Profesor.getDni());
                        command.Parameters.AddWithValue("@InstalacionId", entrenamiento.Instalacion.getId());

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public List<Entrenamiento> ConsultarEntrenamientosPorInstalacionDiaYHora(int idInstalacion, int dia, TimeOnly hora)
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

            using (SqlConnection connection = Conexion.openConection())
            {

                string query = "SELECT * FROM entrenamientos " +
                               "WHERE dia = @Dia AND horaDesde <= @Hora AND horaHasta > @Hora AND idInstalacion = @InstalacionId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Dia", dia);
                    command.Parameters.AddWithValue("@Hora", hora);
                    command.Parameters.AddWithValue("@InstalacionId", idInstalacion);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Entrenamiento entrenamiento = new Entrenamiento
                            (
                                (int)reader["idEntrenamiento"],
                                (TimeOnly)reader["horaDesde"],
                                (TimeOnly)reader["horaHasta"],
                                (int)reader["dia"],
                                new DatosInstalacion().obtenerInstalacionXId((int)reader["idInstalacion"]),                              
                                (Profesor)new DatosPersona().getPersonaByDNI(reader["idProfesor"].ToString())
                            );

                            entrenamientos.Add(entrenamiento);
                        }
                    }
                }
            }

            return entrenamientos;
        }

        public List<Entrenamiento> ConsultarEntrenamientosProfesor(string dni)
        {
            List<Entrenamiento> entrenamientos = new List<Entrenamiento>();

            using (SqlConnection connection = Conexion.openConection())
            {

                string query = "SELECT * FROM entrenamientos " +
                               "WHERE idProfesor = @ProfesorId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProfesorId", dni);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Entrenamiento entrenamiento = new Entrenamiento
                            (
                                (int)reader["idEntrenamiento"],
                                (TimeOnly)reader["horaDesde"],
                                (TimeOnly)reader["horaHasta"],
                                (int)reader["dia"],
                                new DatosInstalacion().obtenerInstalacionXId((int)reader["idInstalacion"]),
                                (Profesor)new DatosPersona().getPersonaByDNI(reader["idProfesor"].ToString())
                            );

                            entrenamientos.Add(entrenamiento);
                        }
                    }
                }
            }

            return entrenamientos;
        }

        public void updateEntrenamiento(Entrenamiento entrenamiento)
        {
            SqlConnection connection = null;
            try
            {

                connection = Conexion.openConection();

                string query = "UPDATE entrenamientos SET horaDesde = @HoraDesde, horaHasta = @HoraHasta, dia = @Dia, idInstalacion = @IdInstalacion WHERE idEntrenamiento = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HoraDesde", entrenamiento.HoraDesde);
                    command.Parameters.AddWithValue("@HoraHasta", entrenamiento.HoraHasta);
                    command.Parameters.AddWithValue("@Dia", entrenamiento.Dia);
                    command.Parameters.AddWithValue("@IdInstalacion", entrenamiento.Instalacion.getId());
                    command.Parameters.AddWithValue("@Id", entrenamiento.IdEntrenamiento);

                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (connection != null)
                {
                    Conexion.closeConnection(connection);
                }
            }
        }

        public void deleteEntrenamiento(int id)
        {
            using (SqlConnection connection = Conexion.openConection())
            {
                string query = "DELETE FROM entrenamientos WHERE idEntrenamiento = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

