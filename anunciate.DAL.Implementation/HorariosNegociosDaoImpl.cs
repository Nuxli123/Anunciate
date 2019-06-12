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
	public class HorariosNegociosDaoImpl : Abstracts.BaseDaoImpl, HorariosNegociosDao
	{
		public List<HorariosNegocios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.HorariosNegocios.FromSql("dbo.usp_HorariosNegociosSelect @Id={0}", parameters).ToList();
		}

		public HorariosNegocios SelectByKey(HorariosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.HorariosNegocios.FromSql("dbo.usp_HorariosNegociosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public HorariosNegocios Update(HorariosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id, entity.NegocioId, entity.HoraInicio, entity.HoraFin, entity.Dias };
			return Context.HorariosNegocios.FromSql("dbo.usp_HorariosNegociosUpdate @Id={0}, @NegocioId={1}, @HoraInicio={2}, @HoraFin={3}, @Dias={4}", parameters).FirstOrDefault();
		}

		public HorariosNegocios Insert(HorariosNegocios entity)
		{
			object[] parameters = new object[] { entity.NegocioId, entity.HoraInicio, entity.HoraFin, entity.Dias };
			return Context.HorariosNegocios.FromSql("dbo.usp_HorariosNegociosInsert @NegocioId={0}, @HoraInicio={1}, @HoraFin={2}, @Dias={3}", parameters).FirstOrDefault();
		}

		public bool Delete(HorariosNegocios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_HorariosNegociosDelete @Id={0}", parameters) == -1 ? true : false);
		}


        public List<HorariosNegocios> ObtieneHorariosNegocioById(int NegocioId)
        {
            object[] parameters = new object[] { NegocioId };
            return Context.HorariosNegocios.FromSql("usp_ObtieneHorariosNegocioByNegocioId @NegocioId={0}", parameters).ToList();
        }
    }
}
