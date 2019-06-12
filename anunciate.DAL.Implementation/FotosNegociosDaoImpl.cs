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
namespace anunciate.DAL.Implementation
{
	public class FotosNegociosDaoImpl : Abstracts.BaseDaoImpl, FotosNegociosDao
	{
		public List<FotosNegocios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.FotosNegocios.FromSql("dbo.usp_FotosNegociosSelect @Id={0}", parameters).ToList();
		}

		public FotosNegocios SelectByKey(FotosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.FotosNegocios.FromSql("dbo.usp_FotosNegociosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public FotosNegocios Update(FotosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id, entity.NegocioId, entity.Foto, entity.Descripcion };
			return Context.FotosNegocios.FromSql("dbo.usp_FotosNegociosUpdate @Id={0}, @NegocioId={1}, @Foto={2}, @Descripcion={3}", parameters).FirstOrDefault();
		}

		public FotosNegocios Insert(FotosNegocios entity)
		{
			object[] parameters = new object[] { entity.NegocioId, entity.Foto, entity.Descripcion };
			return Context.FotosNegocios.FromSql("dbo.usp_FotosNegociosInsert @NegocioId={0}, @Foto={1}, @Descripcion={2}", parameters).FirstOrDefault();
		}

		public bool Delete(FotosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_FotosNegociosDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
