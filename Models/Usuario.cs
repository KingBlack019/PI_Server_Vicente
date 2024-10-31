using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProyectoIntegradoVMS.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Email { get; set; }
        public string NumTelefono { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaCuentaCreada { get; set; }


        public ICollection<UsuarioRol> UsuarioRoles { get; set; }
        public ICollection<Actividad> Actividades { get; set; }
        public ICollection<Chat> ChatsCreados { get; set; }
        public ICollection<Favorito> Favoritos { get; set; }
        public ICollection<Mensaje> Mensajes { get; set; }
        public ICollection<ParticipanteActividad> Participantes { get; set; }
    }
}
