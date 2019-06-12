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
	public class CategoriasNegociosDaoImpl : Abstracts.BaseDaoImpl, CategoriasNegociosDao
	{
		public List<CategoriasNegocios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.CategoriasNegocios.FromSql("dbo.usp_CategoriasNegociosSelect @Id={0}", parameters).ToList();
		}

		public CategoriasNegocios SelectByKey(CategoriasNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.CategoriasNegocios.FromSql("dbo.usp_CategoriasNegociosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public CategoriasNegocios Update(CategoriasNegocios entity)
		{
			object[] parameters = new object[] { entity.Id, entity.Nombre, entity.Icono, entity.ImagenFondo, entity.Tipo };
			return Context.CategoriasNegocios.FromSql("dbo.usp_CategoriasNegociosUpdate @Id={0}, @Nombre={1}, @Icono={2}, @ImagenFondo={3}, @Tipo={4}", parameters).FirstOrDefault();
		}

		public CategoriasNegocios Insert(CategoriasNegocios entity)
		{
			object[] parameters = new object[] { entity.Nombre, entity.Icono, entity.ImagenFondo, entity.Tipo };
			return Context.CategoriasNegocios.FromSql("dbo.usp_CategoriasNegociosInsert @Nombre={0}, @Icono={1}, @ImagenFondo={2}, @Tipo={3}", parameters).FirstOrDefault();
		}

		public bool Delete(CategoriasNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_CategoriasNegociosDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
