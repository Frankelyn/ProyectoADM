using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
   public class EstadosCiviles
    {
        [Key]
        public int EstadoCivilId { get; set; }
        public string Descripcion { get; set; }
    }
}
