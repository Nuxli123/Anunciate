using System;
using System.Collections.Generic;
using System.Text;

namespace anunciate.Domain.Virtual.Response
{
    public class ResponseCalificaciones:ResponseBase
    {
        public List<CalificacionesNegocios> Calificaciones { get; set; }
    }
}
