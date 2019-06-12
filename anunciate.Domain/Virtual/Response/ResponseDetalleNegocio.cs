using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace anunciate.Domain.Virtual.Response
{
  
    public class ResponseDetalleNegocio:ResponseBase
    {

        public int Id { get; set; } //(int, not null)

        public int CategoriaNegocioId { get; set; } //(int, not null)

        public string Nombre { get; set; } //(varchar(40), not null)

        public string ImagenFondo { get; set; } //(varchar(1000), not null)

        public int Orden { get; set; } //(int, not null)

        public string ImagenFondo2 { get; set; } //(varchar(1000), null)

        public string Latitud { get; set; } //(varchar(10), null)

        public string Longitud { get; set; } //(varchar(10), null)

        public string Altitud { get; set; } //(varchar(10), null)

        public string AcercaDe { get; set; }


        [NotMapped]
        public List<HorariosNegocios> Horarios { get; set; }


        [NotMapped]
        public List<TelefonosNegocios> Telefonos { get; set; }
    }





  
}
