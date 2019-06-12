using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anunciate.Domain;
using anunciate.DAL;
using anunciate.DataContext;
using Microsoft.EntityFrameworkCore;

namespace anunciate.DAL.Implementation
{
	public class PromocionesDaoImpl : Abstracts.BaseDaoImpl, PromocionesDao
	{
		public List<Promociones> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Promociones.FromSql("dbo.usp_PromocionesSelect @Id={0}", parameters).ToList();
		}

		public Promociones SelectByKey(Promociones entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Promociones.FromSql("dbo.usp_PromocionesSelect @Id={0}", parameters).FirstOrDefault();
		}

		public Promociones Update(Promociones entity)
		{
			object[] parameters = new object[] { entity.Id, entity.NegocioId, entity.Imagen, entity.FechaInicial, entity.FechaFinal };
			return Context.Promociones.FromSql("dbo.usp_PromocionesUpdate @Id={0}, @NegocioId={1}, @Imagen={2}, @FechaInicial={3}, @FechaFinal={4}", parameters).FirstOrDefault();
		}

		public Promociones Insert(Promociones entity)
		{
			object[] parameters = new object[] { entity.NegocioId, entity.Imagen, entity.FechaInicial, entity.FechaFinal };
			return Context.Promociones.FromSql("dbo.usp_PromocionesInsert @NegocioId={0}, @Imagen={1}, @FechaInicial={2}, @FechaFinal={3}", parameters).FirstOrDefault();
		}

		public bool Delete(Promociones entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_PromocionesDelete @Id={0}", parameters) == -1 ? true : false);
		}


        public List<Domain.Virtual.Response.ResponsePromocionNegocio> ObtenerPromocionesNegocios()
        {
            object[] parameters = new object[] { null };
            return Context.promocionNegocio.FromSql("usp_ObtienePromoconesNegocios", parameters).ToList();
        }
    }
}
