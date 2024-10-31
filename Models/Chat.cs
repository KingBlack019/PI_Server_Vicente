using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradoVMS.Models
{
    public class Chat
    {
        public int IdChat { get; set; }
        public int IdActividad { get; set; }
        public Actividad Actividad { get; set; }

        public int IdCreador { get; set; }
        public Usuario Creador { get; set; }

        public DateTime FechaCreacion { get; set; }
        public ICollection<Mensaje> Mensajes { get; set; }
    }

}
