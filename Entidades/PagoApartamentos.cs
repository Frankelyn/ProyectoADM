using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
    public class PagoApartamentos
    {
        [Key]
        public int PagoApartamentoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public float MontoPago { get; set; }
        public ArriendaApartamentos Arrienda { get; set; }
        public int UsuarioId { get; set; }
    }
}
