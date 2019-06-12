using System;
using anunciate.DAL.IGenerics;
using anunciate.Domain;
namespace anunciate.DAL
{
	/// <summary>
	/// Autor: Rberto Carlos Luna
	/// Comentarios: Interfaz que rige la estructura del CRUD
	/// </summary>
	public interface PromocionesDao : ISelect<Promociones>, IUpdate<Promociones>, IInsert<Promociones>, IDelete<Promociones>
	{
	}
}
