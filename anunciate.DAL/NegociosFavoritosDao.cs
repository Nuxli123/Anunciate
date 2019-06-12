using System;
using anunciate.DAL.IGenerics;
using anunciate.Domain;
namespace anunciate.DAL
{
	/// <summary>
	/// Autor: Roberto Carlos Luna Morales
	/// Comentarios: Interfaz para generar el CRUD
	/// </summary>
	public interface NegociosFavoritosDao : ISelect<NegociosFavoritos>, IUpdate<NegociosFavoritos>, IInsert<NegociosFavoritos>, IDelete<NegociosFavoritos>
	{
	}
}
