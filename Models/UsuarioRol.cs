using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradoVMS.Models
{
    public class UsuarioRol
    {
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public string IdRol { get; set; }
        public Rol Rol { get; set; }
    }
}
