using System;
using System.Collections.Generic;
using System.Text;

namespace anunciate.Domain.Virtual.Response
{
    public class ResponsePromocionNegocio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public int NegocioId { get; set; }

    }
}
