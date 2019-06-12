using System;
using anunciate.DAL.IGenerics;
using anunciate.Domain;
namespace anunciate.DAL
{
	/// <summary>
	/// Autor: anunciate
	/// Comentarios: Interfaz que rige la estructura del CRUD
	/// </summary>
	public interface RolesDao : ISelect<Roles>, IUpdate<Roles>, IInsert<Roles>, IDelete<Roles>
	{
	}
}
