using CondominioADM.DAL;
using CondominioADM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.BLL
{
    public class SexosBLL
    {
        public static List<Sexos> GetSexos()
        {
            List<Sexos> lista = new List<Sexos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Sexos.ToList();
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
