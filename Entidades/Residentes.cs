using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
    public class Residentes
    {
        [Key]
        public int ResidenteId { get; set; }
        public string Nombres { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public int SexoId { get; set; }

        public int MesesPago { get; set; }
        public int EstadoCivilId { get; set; }
        public bool Activo { get; set; }

        public float BalancePendiente { get; set; }
        public int UsuarioId { get; set; }

        [ForeignKey("SexoId")]
        public virtual Sexos Sexo { get; set; }

        [ForeignKey("EstadoCivilId")]
        public virtual EstadosCiviles EstadoCivil { get; set; }

    }
}
