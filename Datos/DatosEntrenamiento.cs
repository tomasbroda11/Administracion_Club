using Entidades;
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

            SqlConnection connection = Conexion.openConection();

            string query = "SELECT * FROM entrenamientos e WHERE e.idEntrenamiento=@Id;";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        int idEntrenamiento = (int)reader["idEntrenamiento"];
                        TimeOnly horaDesde = TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("horaDesde")));
                        TimeOnly horaHasta = TimeOnly.FromTimeSpan(reader.GetTimeSpan(reader.GetOrdinal("horaHasta")));
                        int dia = (int)reader["dia"];
                        Instalacion ins = new DatosInstalacion().obtenerInstalacionXId((int)reader["idInstalacion"]);
                        Profesor profesor = new Profesor();

                        e = new Entrenamiento(idEntrenamiento, horaDesde, horaHasta, dia, ins, profesor);
                    }
                    else { }

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
                    TimeSpan nuevaHoraD= new TimeSpan(horaD.Hour, horaD.Minute, horaD.Second);
                    TimeSpan nuevaHoraH = new TimeSpan(horaH.Hour, horaH.Minute, horaH.Second);

                    command.Parameters.AddWithValue("@Dia", dia);
                    command.Parameters.AddWithValue("@HoraHasta", nuevaHoraH);
                    command.Parameters.AddWithValue("@HoraDesde", nuevaHoraD);
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
                        TimeSpan nuevaHoraD = new TimeSpan(entrenamiento.HoraDesde.Hour, entrenamiento.HoraDesde.Minute, entrenamiento.HoraDesde.Second);
                        TimeSpan nuevaHoraH = new TimeSpan(entrenamiento.HoraHasta.Hour, entrenamiento.HoraHasta.Minute, entrenamiento.HoraHasta.Second);

                        command.Parameters.AddWithValue("@HoraDesde", nuevaHoraD);
                        command.Parameters.AddWithValue("@HoraHasta", nuevaHoraH);
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
            List<Entrenamiento> entrenamientos= new List<Entrenamiento>();

            SqlConnection connection = Conexion.openConection();
            string query = "SELECT  idEntrenamiento, horaDesde, horaHasta, dia, idProfesor, idInstalacion FROM entrenamientos WHERE idProfesor = '21345532';";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Random random = new Random();

                        int hour = random.Next(8, 21);
                        int HoraDos = hour + 1;
                        TimeOnly randomTime = new TimeOnly(hour, 0, 0);
                        TimeOnly timeOneHourLater = randomTime.AddHours(1);
                        Entrenamiento ent = new Entrenamiento
                        (
                            int.Parse(reader["idEntrenamiento"].ToString()),
                            randomTime,
                            timeOneHourLater,
                            int.Parse(reader["dia"].ToString()),
                            new DatosInstalacion().obtenerInstalacionXId(int.Parse(reader["idInstalacion"].ToString())),
                            new Profesor()
                        
                        );
                        entrenamientos.Add(ent);
                    }
                }
            }

            Conexion.closeConnection(connection);

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
                    TimeSpan nuevaHoraD = new TimeSpan(entrenamiento.HoraDesde.Hour, entrenamiento.HoraDesde.Minute, entrenamiento.HoraDesde.Second);
                    TimeSpan nuevaHoraH = new TimeSpan(entrenamiento.HoraHasta.Hour, entrenamiento.HoraHasta.Minute, entrenamiento.HoraHasta.Second);
                    command.Parameters.AddWithValue("@HoraDesde", nuevaHoraD);
                    command.Parameters.AddWithValue("@HoraHasta", nuevaHoraH);
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

