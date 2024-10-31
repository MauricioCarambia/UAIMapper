
using Dal;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DeporteBusiness
    {
        private DeporteData deporteData = new DeporteData();

        public List<Deporte> ObtenerDeporte()
        {
            try
            {
                return deporteData.ObtenerDeporte();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
