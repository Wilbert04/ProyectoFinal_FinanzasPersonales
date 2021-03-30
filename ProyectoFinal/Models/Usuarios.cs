using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string TipoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime Fecha { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            TipoUsuario = string.Empty;
            Nombre = string.Empty;
            Usuario = string.Empty;
            Contraseña = string.Empty;
            Fecha = DateTime.Now;
        }

    }
}
