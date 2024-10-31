using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DeporteData
    {
        public List<Deporte> ObtenerDeporte()
        {
            List<Deporte> listaDeporte = new List<Deporte>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ParcialDBConnection"].ConnectionString);
            try
            {
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Deporte", conn);
                    using (cmd)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        using (reader)
                        {

                            while (reader.Read())
                            {
                                listaDeporte.Add(DeporteMapper.Map(reader));
                            }
                        }
                    }
                }
                return listaDeporte;
            }

            catch (Exception ex)
            {

                throw;
            }


        }
        public Deporte ObtenerId(int id)
        {
            try
            {
                string conectionString = ConfigurationManager.ConnectionStrings["ParcialDBConnection"].ConnectionString;
                using (SqlConnection conection = new SqlConnection(conectionString))
                {
                    conection.Open();
                    string query = "Select ID_DEPORTE, DESCRIPCION FROM Deporte WHERE ID_DEPORTE = @ID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, conection))
                    {
                        sqlCommand.Parameters.AddWithValue("@ID", id);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                return DeporteMapper.Map(reader);
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
