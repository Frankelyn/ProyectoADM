using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
    public class Sexos
    {
        [Key]
        public int SexoId { get; set; }
        public string Descripcion { get; set; }
    }
}
