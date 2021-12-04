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
    public class ResidentesBLL
    {
        public static bool Guardar(Residentes Residente)
        {
            if (!Existe(Residente.ResidenteId))
                return Insertar(Residente);
            else
                return Modificar(Residente);
        }

        private static bool Insertar(Residentes Residente)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Residentes.Add(Residente);
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

        private static bool Modificar(Residentes Residente)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(Residente).State = EntityState.Modified;
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

        public static Residentes Buscar(int id)
        {
            Residentes residente;
            Contexto contexto = new Contexto();

            try
            {
                residente = contexto.Residentes.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return residente;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var residente = ResidentesBLL.Buscar(id);

                if(residente != null)
                {
                    contexto.Residentes.Remove(residente);
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
                encontrado = contexto.Residentes.Any(x => x.ResidenteId == id);
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

        public static List<Residentes> GetList(Expression<Func<Residentes, bool>> Criterio)
        {
            List<Residentes> lista = new List<Residentes>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Residentes.Where(Criterio).ToList();
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

        public static List<Residentes> GetResidentes()
        {
            List<Residentes> lista = new List<Residentes>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Residentes.ToList();
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
