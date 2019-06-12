using System;
using System.Collections.Generic;
using System.Text;

namespace anunciate.Domain.Virtual.Request
{
    public class LoginRequest
    {
        public string UsuarioEmail { get; set; }

        public string Password { get; set; }
    }
}
