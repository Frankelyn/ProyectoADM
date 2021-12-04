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
    public class DepositoParqueosBLL
    {
        public static bool Guardar(DepositoParqueo Deposito)
        {
            if (!Existe(Deposito.DepositoParqueoId))
                return Insertar(Deposito);
            else
                return Modificar(Deposito);
        }

        private static bool Insertar(DepositoParqueo Deposito)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {

                Deposito.NombreResidente = Utilidades.Residente.Nombres;
                Deposito.NumeroParqueo = Utilidades.Parqueo.Numero;
                Deposito.UsuarioId = Utilidades.user.UsuarioId;
                contexto.DepositoParqueo.Add(Deposito);
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

        private static bool Modificar(DepositoParqueo Deposito)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (Utilidades.Residente != null)
                {
                    Deposito.NombreResidente = Utilidades.Residente.Nombres;
                }

                if (Utilidades.Parqueo != null)
                {
                    Deposito.NumeroParqueo = Utilidades.Parqueo.Numero;
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

        public static DepositoParqueo Buscar(int id)
        {
            DepositoParqueo Deposito;
            Contexto contexto = new Contexto();

            try
            {
                Deposito = contexto.DepositoParqueo.Find(id);
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
                var Deposito = DepositoParqueosBLL.Buscar(id);

                if (Deposito != null)
                {
                    contexto.DepositoParqueo.Remove(Deposito);
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
                encontrado = contexto.DepositoParqueo.Any(x => x.DepositoParqueoId == id);
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

        public static List<DepositoParqueo> GetList(Expression<Func<DepositoParqueo, bool>> Criterio)
        {
            List<DepositoParqueo> lista = new List<DepositoParqueo>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.DepositoParqueo.Where(Criterio).ToList();
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
