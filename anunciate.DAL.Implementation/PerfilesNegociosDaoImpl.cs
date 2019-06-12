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
	public class PerfilesNegociosDaoImpl : Abstracts.BaseDaoImpl, PerfilesNegociosDao
	{
		public List<PerfilesNegocios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.PerfilesNegocios.FromSql("dbo.usp_PerfilesNegociosSelect @NegocioId={0}", parameters).ToList();
		}

		public PerfilesNegocios SelectByKey(PerfilesNegocios entity)
		{
			object[] parameters = new object[] { entity.NegocioId };
			return Context.PerfilesNegocios.FromSql("dbo.usp_PerfilesNegociosSelect @NegocioId={0}", parameters).FirstOrDefault();
		}

		public PerfilesNegocios Update(PerfilesNegocios entity)
		{
			object[] parameters = new object[] { entity.NegocioId, entity.ImagenPrincipal, entity.Direccion, entity.Telefono, entity.DiasHorario, entity.Horas, entity.Precios, entity.Descripcion };
			return Context.PerfilesNegocios.FromSql("dbo.usp_PerfilesNegociosUpdate @NegocioId={0}, @ImagenPrincipal={1}, @Direccion={2}, @Telefono={3}, @DiasHorario={4}, @Horas={5}, @Precios={6}, @Descripcion={7}", parameters).FirstOrDefault();
		}

		public PerfilesNegocios Insert(PerfilesNegocios entity)
		{
			object[] parameters = new object[] { entity.NegocioId, entity.ImagenPrincipal, entity.Direccion, entity.Telefono, entity.DiasHorario, entity.Horas, entity.Precios, entity.Descripcion };
			return Context.PerfilesNegocios.FromSql("dbo.usp_PerfilesNegociosInsert @NegocioId={0}, @ImagenPrincipal={1}, @Direccion={2}, @Telefono={3}, @DiasHorario={4}, @Horas={5}, @Precios={6}, @Descripcion={7}", parameters).FirstOrDefault();
		}

		public bool Delete(PerfilesNegocios entity)
		{
			object[] parameters = new object[] { entity.NegocioId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_PerfilesNegociosDelete @NegocioId={0}", parameters) == -1 ? true : false);
		}

	}
}
