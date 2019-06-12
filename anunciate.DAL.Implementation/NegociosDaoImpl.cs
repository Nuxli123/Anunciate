using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using anunciate.Domain;
using anunciate.DAL;
using anunciate.DataContext;
using Microsoft.EntityFrameworkCore;
using anunciate.Domain.Virtual.Response;

namespace anunciate.DAL.Implementation
{
	public class NegociosDaoImpl : Abstracts.BaseDaoImpl, NegociosDao
	{
		public List<Negocios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Negocios.FromSql("dbo.usp_NegociosSelect @Id={0}", parameters).ToList();
		}

		public Negocios SelectByKey(Negocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Negocios.FromSql("dbo.usp_NegociosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public Negocios Update(Negocios entity)
		{
			object[] parameters = new object[] { entity.Id, entity.CategoriaNegocioId, entity.Nombre, entity.ImagenFondo, entity.Orden, entity.ImagenFondo2, entity.Latitud, entity.Longitud, entity.Altitud,entity.AcercaDe };
			return Context.Negocios.FromSql("dbo.usp_NegociosUpdate @Id={0}, @CategoriaNegocioId={1}, @Nombre={2}, @ImagenFondo={3}, @Orden={4}, @ImagenFondo2={5}, @Latitud={6}, @Longitud={7}, @Altitud={8},@AcercaDe={9}", parameters).FirstOrDefault();
		}

		public Negocios Insert(Negocios entity)
		{
			object[] parameters = new object[] { entity.CategoriaNegocioId, entity.Nombre, entity.ImagenFondo, entity.Orden, entity.ImagenFondo2, entity.Latitud, entity.Longitud, entity.Altitud,entity.AcercaDe };
			return Context.Negocios.FromSql("dbo.usp_NegociosInsert @CategoriaNegocioId={0}, @Nombre={1}, @ImagenFondo={2}, @Orden={3}, @ImagenFondo2={4}, @Latitud={5}, @Longitud={6}, @Altitud={7},@AcercaDe={8}", parameters).FirstOrDefault();
		}

		public bool Delete(Negocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_NegociosDelete @Id={0}", parameters) == -1 ? true : false);
		}

        public List<Negocios> ObtieneNegociosByeCategoria(int IdCategoria)
        {
            object[] parameters = new object[] { IdCategoria };
            return Context.Negocios.FromSql("usp_ObtieneNegociosByCategoria @IdCategoria={0}", parameters).ToList();
        }

       

    }
}
