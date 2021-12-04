using CondominioADM.DAL;
using CondominioADM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.BLL
{
    public class EstadosCivilesBLL
    {
        public static List<EstadosCiviles> GetEstadosCiviles()
        {
            List<EstadosCiviles> lista = new List<EstadosCiviles>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.EstadosCiviles.ToList();
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
