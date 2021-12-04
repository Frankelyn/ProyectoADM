using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominioADM.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Clave { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Email { get; set; }
    }
}
