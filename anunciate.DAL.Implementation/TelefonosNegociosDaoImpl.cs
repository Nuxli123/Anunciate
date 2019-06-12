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
	public class TelefonosNegociosDaoImpl : Abstracts.BaseDaoImpl, TelefonosNegociosDao
	{
		public List<TelefonosNegocios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.TelefonosNegocios.FromSql("dbo.usp_TelefonosNegociosSelect @Id={0}", parameters).ToList();
		}

		public TelefonosNegocios SelectByKey(TelefonosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.TelefonosNegocios.FromSql("dbo.usp_TelefonosNegociosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public TelefonosNegocios Update(TelefonosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id, entity.NegocioId, entity.Telefono };
			return Context.TelefonosNegocios.FromSql("dbo.usp_TelefonosNegociosUpdate @Id={0}, @NegocioId={1}, @Telefono={2}", parameters).FirstOrDefault();
		}

		public TelefonosNegocios Insert(TelefonosNegocios entity)
		{
			object[] parameters = new object[] { entity.NegocioId, entity.Telefono };
			return Context.TelefonosNegocios.FromSql("dbo.usp_TelefonosNegociosInsert @NegocioId={0}, @Telefono={1}", parameters).FirstOrDefault();
		}

		public bool Delete(TelefonosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_TelefonosNegociosDelete @Id={0}", parameters) == -1 ? true : false);
		}

        public List<TelefonosNegocios> ObtieneTelefonosNegocioId(int NegocioId)
        {
            object[] parameters = new object[] { NegocioId };
            return Context.TelefonosNegocios.FromSql("usp_ObtieneTelefonosNeogcioByNegocioId @NegocioId={0}", parameters).ToList();
        }

    }
}
