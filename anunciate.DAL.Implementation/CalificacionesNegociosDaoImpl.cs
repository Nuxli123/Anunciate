using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anunciate.Domain;
using anunciate.DAL;
using anunciate.DataContext;
using Microsoft.EntityFrameworkCore;
namespace anunciate.DAL.Implementation
{
	public class CalificacionesNegociosDaoImpl : Abstracts.BaseDaoImpl, CalificacionesNegociosDao
	{
		public List<CalificacionesNegocios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.CalificacionesNegocios.FromSql("dbo.usp_CalificacionesNegociosSelect @Id={0}", parameters).ToList();
		}

		public CalificacionesNegocios SelectByKey(CalificacionesNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.CalificacionesNegocios.FromSql("dbo.usp_CalificacionesNegociosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public CalificacionesNegocios Update(CalificacionesNegocios entity)
		{
			object[] parameters = new object[] { entity.Id, entity.NegocioId, entity.UsuarioId, entity.FechaRegistro, entity.Calificacion };
			return Context.CalificacionesNegocios.FromSql("dbo.usp_CalificacionesNegociosUpdate @Id={0}, @NegocioId={1}, @UsuarioId={2}, @FechaRegistro={3}, @Calificacion={4}", parameters).FirstOrDefault();
		}

		public CalificacionesNegocios Insert(CalificacionesNegocios entity)
		{
			object[] parameters = new object[] { entity.NegocioId, entity.UsuarioId, entity.FechaRegistro, entity.Calificacion };
			return Context.CalificacionesNegocios.FromSql("dbo.usp_CalificacionesNegociosInsert @NegocioId={0}, @UsuarioId={1}, @FechaRegistro={2}, @Calificacion={3}", parameters).FirstOrDefault();
		}

		public bool Delete(CalificacionesNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_CalificacionesNegociosDelete @Id={0}", parameters) == -1 ? true : false);
		}

        public List<CalificacionesNegocios> ObtieneCalificacionbyNegocioId(int NegocioId)
        {
            object[] parameters = new object[] { NegocioId };
            return Context.CalificacionesNegocios.FromSql("ObtieneCalificacionesByNegocioId @NegocioId={0}", parameters).ToList();
        }


    }
}
