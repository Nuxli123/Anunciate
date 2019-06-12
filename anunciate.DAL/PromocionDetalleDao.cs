using System;
using anunciate.DAL.IGenerics;
using anunciate.Domain;
namespace anunciate.DAL
{
	/// <summary>
	/// Autor: Rberto Carlos Luna
	/// Comentarios: Interfaz que rige la estructura del CRUD
	/// </summary>
	public interface PromocionDetalleDao : ISelect<PromocionDetalle>, IUpdate<PromocionDetalle>, IInsert<PromocionDetalle>, IDelete<PromocionDetalle>
	{
	}
}
