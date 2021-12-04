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
    public class ApartamentosBLL
    {
        public static bool Guardar(Apartamentos Apartamento)
        {
            if (!Existe(Apartamento.ApartamentoId))
                return Insertar(Apartamento);
            else
                return Modificar(Apartamento);
        }

        private static bool Insertar(Apartamentos Apartamento)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Apartamentos.Add(Apartamento);
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

        private static bool Modificar(Apartamentos Apartamento)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(Apartamento).State = EntityState.Modified;
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

        public static Apartamentos Buscar(int id)
        {
            Apartamentos apartamento;
            Contexto contexto = new Contexto();

            try
            {
                apartamento = contexto.Apartamentos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return apartamento;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var apartamento = ApartamentosBLL.Buscar(id);

                if (apartamento != null)
                {
                    contexto.Apartamentos.Remove(apartamento);
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
                encontrado = contexto.Apartamentos.Any(x => x.ApartamentoId == id);
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

        public static List<Apartamentos> GetList(Expression<Func<Apartamentos, bool>> Criterio)
        {
            List<Apartamentos> lista = new List<Apartamentos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Apartamentos.Where(Criterio).ToList();
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

        public static List<Apartamentos> GetApartamentos()
        {
            List<Apartamentos> lista = new List<Apartamentos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Apartamentos.ToList();
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
