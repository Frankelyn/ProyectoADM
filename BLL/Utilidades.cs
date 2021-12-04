using CondominioADM.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.BLL
{
    public class Utilidades
    {
        public static int ToInt(string datos)
        {
            int retorno;
            int.TryParse(datos, out retorno);
            return retorno;
        }

        public static float ToFloat(string datos)
        {
            float retorno;
            float.TryParse(datos, out retorno);
            return retorno;
        }

        public static Usuarios user;

        public static bool ok;

        public static Parqueos Parqueo;

        public static Apartamentos Apartamento;

        public static Residentes Residente;

        public static ArriendaApartamentos ArriendaA = new();

        public static ArriendaParqueos ArriendaP;

        public static PagoApartamentos Pago = new();

        public static string Devuelta;

    }
}
