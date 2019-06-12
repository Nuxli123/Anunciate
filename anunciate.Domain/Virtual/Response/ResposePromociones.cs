using System;
using System.Collections.Generic;
using System.Text;

namespace anunciate.Domain.Virtual.Response
{
    public class ResposePromociones:ResponseBase
    {
        public List<ResponsePromocionNegocio> Promociones { get; set; }
    }
}
