using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradoVMS.Models
{
    public class Rol
    {
        public string IdRol { get; set; }
        public string NombreRol { get; set; }

        public ICollection<UsuarioRol> UsuarioRoles { get; set; }
    }
}
