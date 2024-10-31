using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegradoVMS.Models
{
    public class Actividad
    {
        public int IdActividad { get; set; }
        public int IdEncargado { get; set; }
        public Usuario Encargado { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int AforoMaximo { get; set; }
        public int NumRegistrados { get; set; }
        public DateTime FechaCreacion { get; set; }

        public ICollection<ParticipanteActividad> Participantes { get; set; }
        public ICollection<Chat> Chats { get; set; }
        public ICollection<Favorito> Favoritos { get; set; }


        public override string ToString()
        {
            return $"Actividad:\n" +
                   $"- ID: {IdActividad}\n" +
                   $"- Encargado: {IdEncargado}\n" +
                   $"- Título: {Titulo}\n" +
                   $"- Descripción: {Descripcion}\n" +
                   $"- Número de Aforo: {AforoMaximo}\n" +
                   $"- Número de Registrados: {NumRegistrados}\n" +
                   $"- Fecha de Creación: {FechaCreacion.ToShortDateString()}";
        }
    }

}
