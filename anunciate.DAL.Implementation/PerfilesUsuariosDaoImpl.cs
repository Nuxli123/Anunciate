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
	public class PerfilesUsuariosDaoImpl : Abstracts.BaseDaoImpl, PerfilesUsuariosDao
	{
		public List<PerfilesUsuarios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.PerfilesUsuarios.FromSql("dbo.usp_PerfilesUsuariosSelect @UsuarioId={0}", parameters).ToList();
		}

		public PerfilesUsuarios SelectByKey(PerfilesUsuarios entity)
		{
			object[] parameters = new object[] { entity.UsuarioId };
			return Context.PerfilesUsuarios.FromSql("dbo.usp_PerfilesUsuariosSelect @UsuarioId={0}", parameters).FirstOrDefault();
		}

		public PerfilesUsuarios Update(PerfilesUsuarios entity)
		{
			object[] parameters = new object[] { entity.UsuarioId, entity.Foto, entity.FechaNacimiento };
			return Context.PerfilesUsuarios.FromSql("dbo.usp_PerfilesUsuariosUpdate @UsuarioId={0}, @Foto={1}, @FechaNacimiento={2}", parameters).FirstOrDefault();
		}

		public PerfilesUsuarios Insert(PerfilesUsuarios entity)
		{
			object[] parameters = new object[] { entity.UsuarioId, entity.Foto, entity.FechaNacimiento };
			return Context.PerfilesUsuarios.FromSql("dbo.usp_PerfilesUsuariosInsert @UsuarioId={0}, @Foto={1}, @FechaNacimiento={2}", parameters).FirstOrDefault();
		}

		public bool Delete(PerfilesUsuarios entity)
		{
			object[] parameters = new object[] { entity.UsuarioId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_PerfilesUsuariosDelete @UsuarioId={0}", parameters) == -1 ? true : false);
		}

	}
}
