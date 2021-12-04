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
    public class ArriendaParqueosBLL
    {
        public static bool Guardar(ArriendaParqueos Arrienda)
        {
            if (!Existe(Arrienda.ArriendaParqueosId))
                return Insertar(Arrienda);
            else
                return Modificar(Arrienda);
        }

        private static bool Insertar(ArriendaParqueos Arrienda)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                var parqueo = ParqueosBLL.GetParqueos();

                Arrienda.NombreResidente = Utilidades.Residente.Nombres;
                Arrienda.NumeroParqueo = Utilidades.Parqueo.Numero;
                Arrienda.MontoRenta = Utilidades.Parqueo.PrecioRenta;


                foreach (var item in parqueo)
                {
                    if(item.Numero == Arrienda.NumeroParqueo)
                    {
                        item.Disponible = false;
                        contexto.Entry(item).State = EntityState.Modified;
                    }
                }

                var residente = ResidentesBLL.GetResidentes();
                foreach (var item in residente)
                {
                    if (item.Nombres == Arrienda.NombreResidente)
                    {
                        item.Activo = true;
                        contexto.Entry(item).State = EntityState.Modified;
                    }
                }

                Arrienda.UsuarioId = Utilidades.user.UsuarioId;
                contexto.ArriendaParqueos.Add(Arrienda);
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

        private static bool Modificar(ArriendaParqueos Arrienda)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (Utilidades.Residente != null)
                {
                    Arrienda.NombreResidente = Utilidades.Residente.Nombres;
                }

                if (Utilidades.Parqueo != null)
                {
                    Arrienda.NumeroParqueo = Utilidades.Parqueo.Numero;
                    Arrienda.MontoRenta = Utilidades.Parqueo.PrecioRenta;
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

        public static ArriendaParqueos Buscar(int id)
        {
            ArriendaParqueos arrienda;
            Contexto contexto = new Contexto();

            try
            {
                arrienda = contexto.ArriendaParqueos.Find(id);
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
                var arrienda = ArriendaParqueosBLL.Buscar(id);

                if (arrienda != null)
                {

                    var parqueo = ParqueosBLL.GetParqueos();
                    foreach (var item in parqueo)
                    {
                        if (item.Numero == arrienda.NumeroParqueo)
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
                            contexto.Entry(item).State = EntityState.Modified;
                        }
                    }

                    contexto.ArriendaParqueos.Remove(arrienda);
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
                encontrado = contexto.ArriendaParqueos.Any(x => x.ArriendaParqueosId == id);
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

        public static List<ArriendaParqueos> GetList(Expression<Func<ArriendaParqueos, bool>> Criterio)
        {
            List<ArriendaParqueos> lista = new List<ArriendaParqueos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.ArriendaParqueos.Where(Criterio).ToList();
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
