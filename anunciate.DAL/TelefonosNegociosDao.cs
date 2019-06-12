using System;
using anunciate.DAL.IGenerics;
using anunciate.Domain;
namespace anunciate.DAL
{
	/// <summary>
	/// Autor: Roberto Carlos Luna Morales
	/// Comentarios: Interfaz para generar el CRUD
	/// </summary>
	public interface TelefonosNegociosDao : ISelect<TelefonosNegocios>, IUpdate<TelefonosNegocios>, IInsert<TelefonosNegocios>, IDelete<TelefonosNegocios>
	{
	}
}
