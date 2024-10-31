using Dal;
using Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class PartidoBusiness
    {
        private PartidoData partidoData = new PartidoData();

        public void GuardarPartido(Partido partido)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    if (string.IsNullOrEmpty(partido.EquipoLocal) || string.IsNullOrEmpty(partido.EquipoVisitante))
                    {
                        throw new Exception("Complete los equipos");
                    }
                    if (partido.EquipoLocal.Length < 5 || partido.EquipoVisitante.Length < 5)
                    {
                        throw new Exception("Los nombres de los equipos deben tener mas de 5 letras");
                    }
                    if (partido.FechaPartido < DateTime.Today)
                    {
                        throw new Exception("La fecha no puede anterior a hoy");
                    }
                    if (partido.Deporte.IdDeporte <= 0)
                    {
                        throw new Exception("Eliga un deporte");
                    }
                    partido.MarcadorLocal = Convert.ToInt32(0);
                    partido.MarcadorVisitante = Convert.ToInt32(0);
                    partido.FechaRegistro = DateTime.Now.Date;
                    partidoData.GuardarPartido(partido);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void GuardarPartidos(List<Partido> partido)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    foreach(Partido partidos in partido)
                    {
                        GuardarPartido(partidos);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<Partido> ObtenerPartidos()
        {
            try
            {
                return partidoData.ObtenerPartidos();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void ModificarPartido(int idPartido, int marcadorLocal, int marcadorVisitante)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    DateTime fechaPartido = partidoData.ObtenerFechaPartido(idPartido);

                    if (fechaPartido.Date != DateTime.Today)
                    {
                        throw new Exception("No se puede modificar partidos el mismo dia del partido");
                    }
                    if (marcadorLocal < 0 || marcadorVisitante < 0)
                    {
                        throw new Exception("El valor del marcador no puede ser menor a 0");
                    }
                    partidoData.ModificarPartido(idPartido, marcadorLocal, marcadorVisitante);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public void EliminarPartido(int idPartido)
        {
            try
            {
                using (var trx = new TransactionScope())
                {
                    string id = idPartido.ToString();
                    if (string.IsNullOrEmpty(id))
                    {
                        throw new Exception("Complete el id");
                    }
                    partidoData.EliminarPartido(idPartido);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
      
    }
}
