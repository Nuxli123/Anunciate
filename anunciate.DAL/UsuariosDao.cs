using System;
using anunciate.DAL.IGenerics;
using anunciate.Domain;
namespace anunciate.DAL
{
	/// <summary>
	/// Autor: Roberto Carlos Luna Morales
	/// Comentarios: Interfaz para generar el CRUD
	/// </summary>
	public interface UsuariosDao : ISelect<Usuarios>, IUpdate<Usuarios>, IInsert<Usuarios>, IDelete<Usuarios>
	{
	}
}
