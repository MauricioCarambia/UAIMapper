using Entity;
using System.Data.SqlClient;

namespace Mapper
{
    public class DeporteMapper
    {
        public static Deporte Map(SqlDataReader reader)
        {
            Deporte deporte = new Deporte();
            deporte.IdDeporte = reader.GetInt32(0);
            deporte.Descripcion = reader.GetString(1);
            return deporte;
        }
    }
}
