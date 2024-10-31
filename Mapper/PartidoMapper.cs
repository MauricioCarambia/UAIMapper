using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class PartidoMapper
    {
        public static Partido Map(SqlDataReader reader, Deporte deporte)
        {
            Partido partido = new Partido();
            {
                partido.IdPartido = reader.GetInt32(0);
                partido.EquipoLocal = reader.GetString(2);
                partido.EquipoVisitante = reader.GetString(3);
                partido.FechaRegistro = reader.GetDateTime(4);
                partido.FechaPartido = reader.GetDateTime(5);
                partido.MarcadorLocal = reader.GetInt32(6);
                partido.MarcadorVisitante = reader.GetInt32(7);
                partido.Deporte = deporte;
            }
            return partido;
        }
    }
}
