using System;
using anunciate.DAL.IGenerics;
using anunciate.Domain;
namespace anunciate.DAL
{
	/// <summary>
	/// Autor: anunciate
	/// Comentarios: Interfaz que rige la estructura del CRUD
	/// </summary>
	public interface UsuariosRolesDao : ISelect<UsuariosRoles>, IUpdate<UsuariosRoles>, IInsert<UsuariosRoles>, IDelete<UsuariosRoles>
	{
	}
}
