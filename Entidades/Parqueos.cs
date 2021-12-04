using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
    public class Parqueos
    {
        [Key]
        public int ParqueoId { get; set; }
        public int Numero { get; set; }
        public float PrecioRenta { get; set; }
        public bool  Disponible { get; set; }
        public int UsuarioId { get; set; }
    }
}
