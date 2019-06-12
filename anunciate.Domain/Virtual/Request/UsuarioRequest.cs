using System;
using System.Collections.Generic;
using System.Text;

namespace anunciate.Domain.Virtual.Request
{
    public class UsuarioRequest
    {
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
