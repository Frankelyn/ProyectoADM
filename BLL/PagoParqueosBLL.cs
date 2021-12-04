using CondominioADM.DAL;
using CondominioADM.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.BLL
{
    public class PagoParqueosBLL
    {
        public static bool Guardar(PagoParqueo Pago)
        {
            if (!Existe(Pago.PagoParqueoId))
                return Insertar(Pago);
            else
                return Modificar(Pago);
        }

        private static bool Insertar(PagoParqueo Pago)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                Pago.Arrienda = Utilidades.ArriendaP;
                var residente = ResidentesBLL.GetResidentes();
                foreach (var item in residente)
                {
                    if (item.Nombres == Pago.Arrienda.NombreResidente)
                    {
                        item.BalancePendiente -= Pago.Arrienda.MontoRenta;
                        item.MesesPago += 1;
                    }
                }

                contexto.PagoParqueo.Add(Pago);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Modificar(PagoParqueo Pago)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (Utilidades.ArriendaP != null)
                {
                    Pago.Arrienda = Utilidades.ArriendaP;
                }
                contexto.Entry(Pago).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static PagoParqueo Buscar(int id)
        {
            PagoParqueo Pago;
            Contexto contexto = new Contexto();

            try
            {
                Pago = contexto.PagoParqueo.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Pago;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var Pago = PagoParqueosBLL.Buscar(id);

                if (Pago != null)
                {
                    var residente = ResidentesBLL.GetResidentes();
                    foreach (var item in residente)
                    {
                        if (item.Nombres == Pago.Arrienda.NombreResidente)
                        {
                            item.BalancePendiente += Pago.Arrienda.MontoRenta;
                            item.MesesPago -= 1;
                        }
                    }
                    contexto.PagoParqueo.Remove(Pago);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.PagoParqueo.Any(x => x.PagoParqueoId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

        public static List<PagoParqueo> GetList(Expression<Func<PagoParqueo, bool>> Criterio)
        {
            List<PagoParqueo> lista = new List<PagoParqueo>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.PagoParqueo.Where(Criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

    }
}
