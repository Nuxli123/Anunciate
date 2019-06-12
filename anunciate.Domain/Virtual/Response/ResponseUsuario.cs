using System;
using System.Collections.Generic;
using System.Text;

namespace anunciate.Domain.Virtual.Response
{
    public class ResponseUsuario:ResponseBase
    {
        public UsuarioBase Usuario { get; set; }

    }

    public class UsuarioBase
    {
        public int IdUsuario { get; set; }

        public string NombreUsuario { get; set; }

    }
}
