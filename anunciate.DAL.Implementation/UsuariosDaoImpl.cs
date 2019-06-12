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
	public class UsuariosDaoImpl : Abstracts.BaseDaoImpl, UsuariosDao
	{
		public List<Usuarios> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Usuarios.FromSql("dbo.usp_UsuariosSelect @Id={0}", parameters).ToList();
		}

		public Usuarios SelectByKey(Usuarios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return Context.Usuarios.FromSql("dbo.usp_UsuariosSelect @Id={0}", parameters).FirstOrDefault();
		}

		public Usuarios Update(Usuarios entity)
		{
			object[] parameters = new object[] { entity.Id, entity.Nombre, entity.NombreUsuario, entity.Email, entity.Password, entity.FechaRegistro, entity.FechaUltimoAcceso, entity.Activo, entity.Verificado, entity.AuthId, entity.Token, entity.ProviderAuth };
			return Context.Usuarios.FromSql("dbo.usp_UsuariosUpdate @Id={0}, @Nombre={1}, @NombreUsuario={2}, @Email={3}, @Password={4}, @FechaRegistro={5}, @FechaUltimoAcceso={6}, @Activo={7}, @Verificado={8}, @AuthId={9}, @Token={10}, @ProviderAuth={11}", parameters).FirstOrDefault();
		}

		public Usuarios Insert(Usuarios entity)
		{
			object[] parameters = new object[] { entity.Nombre, entity.NombreUsuario, entity.Email, entity.Password, entity.FechaRegistro, entity.FechaUltimoAcceso, entity.Activo, entity.Verificado, entity.AuthId, entity.Token, entity.ProviderAuth };
			return Context.Usuarios.FromSql("dbo.usp_UsuariosInsert @Nombre={0}, @NombreUsuario={1}, @Email={2}, @Password={3}, @FechaRegistro={4}, @FechaUltimoAcceso={5}, @Activo={6}, @Verificado={7}, @AuthId={8}, @Token={9}, @ProviderAuth={10}", parameters).FirstOrDefault();
		}

		public bool Delete(Usuarios entity)
		{
			object[] parameters = new object[] { entity.Id };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_UsuariosDelete @Id={0}", parameters) == -1 ? true : false);
		}

        public Usuarios ObtieneUsuariobyEmail(string email)
        {
            object[] parameters = new object[] { email };
            return Context.Usuarios.FromSql("usp_ObtieneUsuariobyEmail @email={0}", parameters).FirstOrDefault();
        }

    }
}
