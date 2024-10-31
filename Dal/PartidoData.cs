using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class PartidoData
    {
        private DeporteData deporteData = new DeporteData();
        public void GuardarPartido(Partido partido)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ParcialDBConnection"].ConnectionString);
            try
            {

                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO Partido (ID_DEPORTE, EQUIPO_LOCAL, EQUIPO_VISITANTE, FECHA_REGISTRO, FECHA_PARTIDO, MARCADOR_LOCAL, MARCADOR_VISITANTE)
                                                    VALUES (@deporte, @equipoLocal, @equipoVisitante, @fechaRegistro, @fechaPartido, @marcadorLocal, @marcadorVisitante)", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@deporte", partido.Deporte.IdDeporte);
                        cmd.Parameters.AddWithValue("@equipoLocal", partido.EquipoLocal);
                        cmd.Parameters.AddWithValue("@equipoVisitante", partido.EquipoVisitante);
                        cmd.Parameters.AddWithValue("@fechaRegistro", partido.FechaRegistro);
                        cmd.Parameters.AddWithValue("@fechaPartido", partido.FechaPartido);
                        cmd.Parameters.AddWithValue("@marcadorLocal", partido.MarcadorLocal);
                        cmd.Parameters.AddWithValue("@marcadorVisitante", partido.MarcadorVisitante);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        public List<Partido> ObtenerPartidos()
        {
            List<Partido> listaPartidos = new List<Partido>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ParcialDBConnection"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Partido", conn);
                    using (cmd)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {
                            while (reader.Read())
                            {
                                int idDeporte = Convert.ToInt32(reader["ID_DEPORTE"].ToString());
                                Deporte deporte = deporteData.ObtenerId(idDeporte);
                                Partido partido = PartidoMapper.Map(reader, deporte);
                                listaPartidos.Add(partido);
                            }
                        }

                    }
                }
                return listaPartidos;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public void EliminarPartido(int idPartido)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ParcialDBConnection"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from Partido where ID_PARTIDO = @idPartido", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idPartido", idPartido);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void ModificarPartido(int idPartido, int marcadorLocal, int marcadorVisitante)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ParcialDBConnection"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Partido SET MARCADOR_LOCAL = @marcadorLocal, MARCADOR_VISITANTE = @marcadorVisitante where ID_PARTIDO = @idPartido", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idPartido", idPartido);
                        cmd.Parameters.AddWithValue("@marcadorLocal", marcadorLocal);
                        cmd.Parameters.AddWithValue("@marcadorVisitante", marcadorVisitante);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public DateTime ObtenerFechaPartido(int idPartido)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ParcialDBConnection"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT FECHA_PARTIDO FROM Partido WHERE ID_PARTIDO = @idPartido", conn);
                    using (cmd)
                    {
                        cmd.Parameters.AddWithValue("@idPartido", idPartido);
                        DateTime result = (DateTime)cmd.ExecuteScalar();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

    }
}
