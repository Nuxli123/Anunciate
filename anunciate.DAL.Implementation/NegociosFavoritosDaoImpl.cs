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
	public class NegociosFavoritosDaoImpl : Abstracts.BaseDaoImpl, NegociosFavoritosDao
	{
		public List<NegociosFavoritos> SelectAll()
		{
			object[] parameters = new object[] { null, null };
			return Context.NegociosFavoritos.FromSql("dbo.usp_NegociosFavoritosSelect @UsuarioId={0}, @NegocioId={1}", parameters).ToList();
		}

		public NegociosFavoritos SelectByKey(NegociosFavoritos entity)
		{
			object[] parameters = new object[] { entity.UsuarioId, entity.NegocioId };
			return Context.NegociosFavoritos.FromSql("dbo.usp_NegociosFavoritosSelect @UsuarioId={0}, @NegocioId={1}", parameters).FirstOrDefault();
		}

		public NegociosFavoritos Update(NegociosFavoritos entity)
		{
			object[] parameters = new object[] { entity.UsuarioId, entity.NegocioId };
			return Context.NegociosFavoritos.FromSql("dbo.usp_NegociosFavoritosUpdate @UsuarioId={0}, @NegocioId={1}", parameters).FirstOrDefault();
		}

		public NegociosFavoritos Insert(NegociosFavoritos entity)
		{
			object[] parameters = new object[] { entity.UsuarioId, entity.NegocioId };
			return Context.NegociosFavoritos.FromSql("dbo.usp_NegociosFavoritosInsert @UsuarioId={0}, @NegocioId={1}", parameters).FirstOrDefault();
		}

		public bool Delete(NegociosFavoritos entity)
		{
			object[] parameters = new object[] { entity.UsuarioId, entity.NegocioId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_NegociosFavoritosDelete @UsuarioId={0}, @NegocioId={1}", parameters) == -1 ? true : false);
		}

	}
}
