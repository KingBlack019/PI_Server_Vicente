using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradoVMS.Models
{
    public class Mensaje
    {
        public int IdMensaje { get; set; }
        public int IdChat { get; set; }
        public Chat Chat { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public string Contenido { get; set; }
        public DateTime FechaEnvio { get; set; }
    }

}
