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
    public class DepositoApartamentosBLL
    {
        public static bool Guardar(DepositoApartamento Deposito)
        {
            if (!Existe(Deposito.DepositoApartamentoId))
                return Insertar(Deposito);
            else
                return Modificar(Deposito);
        }

        private static bool Insertar(DepositoApartamento Deposito)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                

                Deposito.NombreResidente = Utilidades.Residente.Nombres;
                Deposito.NumeroApartamento = Utilidades.Apartamento.Numero;     
                Deposito.UsuarioId = Utilidades.user.UsuarioId;
                contexto.DepositoApartamento.Add(Deposito);
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

        private static bool Modificar(DepositoApartamento Deposito)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (Utilidades.Residente != null)
                {
                    Deposito.NombreResidente = Utilidades.Residente.Nombres;
                }

                if (Utilidades.Apartamento != null)
                {
                    Deposito.NumeroApartamento = Utilidades.Apartamento.Numero;
                }

                contexto.Entry(Deposito).State = EntityState.Modified;
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

        public static DepositoApartamento Buscar(int id)
        {
            DepositoApartamento Deposito;
            Contexto contexto = new Contexto();

            try
            {
                Deposito = contexto.DepositoApartamento.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Deposito;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var Deposito = DepositoApartamentosBLL.Buscar(id);

                if (Deposito != null)
                {
                    contexto.DepositoApartamento.Remove(Deposito);
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
                encontrado = contexto.DepositoApartamento.Any(x => x.DepositoApartamentoId == id);
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

        public static List<DepositoApartamento> GetList(Expression<Func<DepositoApartamento, bool>> Criterio)
        {
            List<DepositoApartamento> lista = new List<DepositoApartamento>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.DepositoApartamento.Where(Criterio).ToList();
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
