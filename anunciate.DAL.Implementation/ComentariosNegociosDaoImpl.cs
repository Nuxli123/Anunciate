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
	public class ComentariosNegociosDaoImpl : Abstracts.BaseDaoImpl, ComentariosNegociosDao
	{

		public List<ComentariosNegocios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.ComentariosNegocios.FromSql("dbo.usp_ComentariosNegociosSelect @Id={0}", parameters).ToList();
		}

		public ComentariosNegocios SelectByKey(ComentariosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.ComentariosNegocios.FromSql("dbo.usp_ComentariosNegociosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public ComentariosNegocios Update(ComentariosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id, entity.NegocioId, entity.UsuarioId, entity.Comentario, entity.FechaRegistro, entity.Eliminado };
			return Context.ComentariosNegocios.FromSql("dbo.usp_ComentariosNegociosUpdate @Id={0}, @NegocioId={1}, @UsuarioId={2}, @Comentario={3}, @FechaRegistro={4}, @Eliminado={5}", parameters).FirstOrDefault();
		}

		public ComentariosNegocios Insert(ComentariosNegocios entity)
		{
			object[] parameters = new object[] { entity.NegocioId, entity.UsuarioId, entity.Comentario, entity.FechaRegistro, entity.Eliminado };
			return Context.ComentariosNegocios.FromSql("dbo.usp_ComentariosNegociosInsert @NegocioId={0}, @UsuarioId={1}, @Comentario={2}, @FechaRegistro={3}, @Eliminado={4}", parameters).FirstOrDefault();
		}

		public bool Delete(ComentariosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_ComentariosNegociosDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
