using CondominioADM.Entidades;
using CondominioADM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CondominioADM.BLL
{
    public class ArriendaApartamentosBLL
    {
        public static bool Guardar(ArriendaApartamentos Arrienda)
        {
            if (!Existe(Arrienda.ArriendaApartamentoId))
                return Insertar(Arrienda);
            else
                return Modificar(Arrienda);
        }

        private static bool Insertar(ArriendaApartamentos Arrienda)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {  
                Arrienda.NombreResidente = Utilidades.Residente.Nombres;
                Arrienda.NumeroApartamento = Utilidades.Apartamento.Numero;
                Arrienda.MontoRenta = Utilidades.Apartamento.PrecioRenta;

                var apartamento = ApartamentosBLL.GetApartamentos();
                foreach (var item in apartamento)
                {
                    if(item.Numero == Arrienda.NumeroApartamento)
                    {
                        item.Disponible = false;
                        contexto.Entry(item).State = EntityState.Modified;
                    }
                }

                var meses = Arrienda.FechaRenovacion.Month - Arrienda.FechaInicio.Month;

                var residente = ResidentesBLL.GetResidentes();
                foreach(var item in residente)
                {
                    if(item.Nombres == Arrienda.NombreResidente)
                    {
                        item.Activo = true;
                        item.BalancePendiente = Arrienda.MontoRenta * meses;
                        contexto.Entry(item).State = EntityState.Modified;
                    }
                }
                Arrienda.UsuarioId = Utilidades.user.UsuarioId;
                contexto.ArriendaApartamentos.Add(Arrienda);

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

        private static bool Modificar(ArriendaApartamentos Arrienda)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if(Utilidades.Residente != null)
                {
                    Arrienda.NombreResidente = Utilidades.Residente.Nombres;
                }
               
                if(Utilidades.Apartamento != null)
                {
                    Arrienda.NumeroApartamento = Utilidades.Apartamento.Numero;
                    Arrienda.MontoRenta = Utilidades.Apartamento.PrecioRenta;
                }


                contexto.Entry(Arrienda).State = EntityState.Modified;
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

        public static ArriendaApartamentos Buscar(int id)
        {
            ArriendaApartamentos arrienda;
            Contexto contexto = new Contexto();

            try
            {
                arrienda = contexto.ArriendaApartamentos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return arrienda;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var arrienda = ArriendaApartamentosBLL.Buscar(id);

                if (arrienda != null)
                {

                    var apartamentoAnterior = ApartamentosBLL.GetApartamentos();
                    foreach (var item in apartamentoAnterior)
                    {
                        if (item.Numero == arrienda.NumeroApartamento)
                        {
                            item.Disponible = true;
                            contexto.Entry(item).State = EntityState.Modified;
                        }
                    }
                    var residenteAnterior = ResidentesBLL.GetResidentes();
                    foreach (var item in residenteAnterior)
                    {
                        if (item.Nombres == arrienda.NombreResidente)
                        {
                            item.Activo = false;
                            item.BalancePendiente = 0;
                            contexto.Entry(item).State = EntityState.Modified;
                        }
                    }

                    contexto.ArriendaApartamentos.Remove(arrienda);
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
                encontrado = contexto.ArriendaApartamentos.Any(x => x.ArriendaApartamentoId == id);
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

        public static List<ArriendaApartamentos> GetList(Expression<Func<ArriendaApartamentos, bool>> Criterio)
        {
            List<ArriendaApartamentos> lista = new List<ArriendaApartamentos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.ArriendaApartamentos.Where(Criterio).ToList();
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
