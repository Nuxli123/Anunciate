using System;
using System.Collections.Generic;
using System.Text;

namespace anunciate.Domain.Virtual.Response
{
    public class ResponseComentarios:ResponseBase
    {
        public List<ComentariosNegocios> Comentarios { get; set; }
    }
}
