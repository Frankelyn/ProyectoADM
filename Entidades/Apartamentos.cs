using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
    public class Apartamentos
    {
        [Key]
        public int ApartamentoId { get; set; }
        public int Numero { get; set; }
        public int Habitaciones { get; set; }
        public bool Disponible { get; set; }
        public float PrecioRenta { get; set; }
        public int UsuarioId { get; set; }
    }
}
