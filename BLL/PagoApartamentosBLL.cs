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
    public class PagoApartamentosBLL
    {
        public static bool Guardar(PagoApartamentos Pago)
        {
            if (!Existe(Pago.PagoApartamentoId))
                return Insertar(Pago);
            else
                return Modificar(Pago);
        }

        private static bool Insertar(PagoApartamentos Pago)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Pago.Arrienda = Utilidades.ArriendaA;
                //Pago.Arrienda.NumeroApartamento = Utilidades.ArriendaA.NumeroApartamento;
                //Pago.Arrienda.MontoRenta = Utilidades.ArriendaA.MontoRenta;

                var residente = ResidentesBLL.GetResidentes();
                foreach(var item in residente)
                {
                    if(item.Nombres == Pago.Arrienda.NombreResidente)
                    {
                        item.BalancePendiente -= Pago.Arrienda.MontoRenta;
                        item.MesesPago += 1;
                        contexto.Entry(item).State = EntityState.Modified;
                    }
                }

                contexto.Entry(Pago.Arrienda).State = EntityState.Unchanged;
                
                contexto.PagoApartamentos.Add(Pago);
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

        private static bool Modificar(PagoApartamentos Pago)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if(Utilidades.ArriendaA != null)
                {
                    Pago.Arrienda = Utilidades.ArriendaA;
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

        public static PagoApartamentos Buscar(int id)
        {
            PagoApartamentos Pago;
            Contexto contexto = new Contexto();

            try
            {
                Pago = contexto.PagoApartamentos.Find(id);
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
                var Pago = PagoApartamentosBLL.Buscar(id);

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
                    contexto.PagoApartamentos.Remove(Pago);
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
                encontrado = contexto.PagoApartamentos.Any(x => x.PagoApartamentoId == id);
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

        public static List<PagoApartamentos> GetList(Expression<Func<PagoApartamentos, bool>> Criterio)
        {
            List<PagoApartamentos> lista = new List<PagoApartamentos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.PagoApartamentos.Where(Criterio).ToList();
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
