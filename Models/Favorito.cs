using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradoVMS.Models
{
    public class Favorito
    {
        public int IdActividad { get; set; }
        public Actividad Actividad { get; set; }

        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }

}
