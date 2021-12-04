using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
    public class DepositoApartamento
    {
        [Key]
        public int DepositoApartamentoId { get; set; }
        public int NumeroApartamento {get; set;}
        public string NombreResidente { get; set; }
        public float Monto { get; set; }

        public int UsuarioId { get; set; }

    }
}
