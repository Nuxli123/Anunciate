using System;
using System.Collections.Generic;
using System.Text;

namespace anunciate.Domain.Virtual.Response
{
    public class ResponsePromocionDetalle:ResponseBase
    {
        public List<PromocionDetalle> Promociones { get; set; }
    }
}
