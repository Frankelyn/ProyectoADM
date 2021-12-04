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
    public class ParqueosBLL
    {
        public static bool Guardar(Parqueos Parqueo)
        {
            if (!Existe(Parqueo.ParqueoId))
                return Insertar(Parqueo);
            else
                return Modificar(Parqueo);
        }

        private static bool Insertar(Parqueos Parqueo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Parqueos.Add(Parqueo);
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

        private static bool Modificar(Parqueos Parqueo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(Parqueo).State = EntityState.Modified;
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

        public static Parqueos Buscar(int id)
        {
            Parqueos parqueo;
            Contexto contexto = new Contexto();

            try
            {
                parqueo = contexto.Parqueos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return parqueo;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var parqueo = ParqueosBLL.Buscar(id);

                if (parqueo != null)
                {
                    contexto.Parqueos.Remove(parqueo);
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
                encontrado = contexto.Parqueos.Any(x => x.ParqueoId == id);
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

        public static List<Parqueos> GetList(Expression<Func<Parqueos, bool>> Criterio)
        {
            List<Parqueos> lista = new List<Parqueos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Parqueos.Where(Criterio).ToList();
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

        public static List<Parqueos> GetParqueos()
        {
            List<Parqueos> lista = new List<Parqueos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Parqueos.ToList();
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
