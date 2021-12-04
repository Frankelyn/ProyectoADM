using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
    public class ArriendaApartamentos
    {
        [Key]
        public int ArriendaApartamentoId { get; set; }
        public int NumeroApartamento { get; set; }
        public string NombreResidente { get; set; }

        public float MontoRenta { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaRenovacion { get; set; }
        public int UsuarioId { get; set; }

    }
}
