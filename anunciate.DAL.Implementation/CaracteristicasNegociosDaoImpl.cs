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
	public class CaracteristicasNegociosDaoImpl : Abstracts.BaseDaoImpl, CaracteristicasNegociosDao
	{
		public List<CaracteristicasNegocios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.CaracteristicasNegocios.FromSql("dbo.usp_CaracteristicasNegociosSelect @Id={0}", parameters).ToList();
		}

		public CaracteristicasNegocios SelectByKey(CaracteristicasNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.CaracteristicasNegocios.FromSql("dbo.usp_CaracteristicasNegociosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public CaracteristicasNegocios Update(CaracteristicasNegocios entity)
		{
			object[] parameters = new object[] { entity.Id, entity.NegocioId, entity.Descripcion };
			return Context.CaracteristicasNegocios.FromSql("dbo.usp_CaracteristicasNegociosUpdate @Id={0}, @NegocioId={1}, @Descripcion={2}", parameters).FirstOrDefault();
		}

		public CaracteristicasNegocios Insert(CaracteristicasNegocios entity)
		{
			object[] parameters = new object[] { entity.NegocioId, entity.Descripcion };
			return Context.CaracteristicasNegocios.FromSql("dbo.usp_CaracteristicasNegociosInsert @NegocioId={0}, @Descripcion={1}", parameters).FirstOrDefault();
		}

		public bool Delete(CaracteristicasNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_CaracteristicasNegociosDelete @Id={0}", parameters) == -1 ? true : false);
		}

	}
}
