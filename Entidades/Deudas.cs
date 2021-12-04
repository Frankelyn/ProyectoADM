using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
    public class Deudas
    {
        [Key]
        public int DeudaId { get; set; }
        public float Monto { get; set; }
        public int Tiempo { get; set; }
        public int ResidenteId { get; set; }

        [ForeignKey("ResidenteId")]
        public virtual Residentes Residente { get; set; }
    }
}
