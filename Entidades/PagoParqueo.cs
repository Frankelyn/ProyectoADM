using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
    public class PagoParqueo
    {
        [Key]
        public int PagoParqueoId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public float MontoPago { get; set; }
        public ArriendaParqueos Arrienda { get; set; }

        public int UsuarioId { get; set; }
    }
}
