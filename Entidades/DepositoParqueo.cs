using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
    public class DepositoParqueo
    {
        [Key]
        public int DepositoParqueoId { get; set; }
        public int NumeroParqueo { get; set; }
        public string NombreResidente { get; set; }
        public float Monto { get; set; }

        public int UsuarioId { get; set; }
    }
}
