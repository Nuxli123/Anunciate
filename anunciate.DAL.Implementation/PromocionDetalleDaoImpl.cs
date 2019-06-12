using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anunciate.Domain
;
using anunciate.DAL;
using anunciate.DataContext;
using Microsoft.EntityFrameworkCore;
using anunciate.Domain.Virtual.Response;

namespace anunciate.DAL.Implementation
{
	public class PromocionDetalleDaoImpl : Abstracts.BaseDaoImpl, PromocionDetalleDao
	{
		public List<PromocionDetalle> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.PromocionesDetalle.FromSql("dbo.usp_PromocionDetalleSelect @Id={0}", parameters).ToList();
		}

		public PromocionDetalle SelectByKey(PromocionDetalle entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.PromocionesDetalle.FromSql("dbo.usp_PromocionDetalleSelect @Id={0}", parameters).FirstOrDefault();
		}

		public PromocionDetalle Update(PromocionDetalle entity)
		{
			object[] parameters = new object[] { entity.Id, entity.PromocionId, entity.TxtProducto, entity.TxtPromocion, entity.FechaInicial, entity.FechaFinal };
			return Context.PromocionesDetalle.FromSql("dbo.usp_PromocionDetalleUpdate @Id={0}, @PromocionId={1}, @TxtProducto={2}, @TxtPromocion={3},@FechaInicial={4},@FechaFinal={5}", parameters).FirstOrDefault();
		}

		public PromocionDetalle Insert(PromocionDetalle entity)
		{
			object[] parameters = new object[] { entity.PromocionId, entity.TxtProducto, entity.TxtPromocion, entity.FechaInicial, entity.FechaFinal };
			return Context.PromocionesDetalle.FromSql("dbo.usp_PromocionDetalleInsert @PromocionId={0}, @TxtProducto={1}, @TxtPromocion={2},@FechaInicial={3},@FechaFinal={4}", parameters).FirstOrDefault();
		}

		public bool Delete(PromocionDetalle entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_PromocionDetalleDelete @Id={0}", parameters) == -1 ? true : false);
		}

        public List<PromocionDetalle> ObtieneDetallePromocionByNegocio(int NegocioId)
        {
            object[] parameters = new object[] { NegocioId };
            return Context.PromocionesDetalle.FromSql("usp_ObtieneDetallePromocionNegocio @NegocioId={0}", parameters).ToList();
        }

    }
}
