using System;
using anunciate.DAL.IGenerics;
using anunciate.Domain;

namespace anunciate.DAL
{
	/// <summary>
	/// Autor: Roberto Carlos Luna Morales
	/// Comentarios: Interfaz para generar el CRUD
	/// </summary>
	public interface CalificacionesNegociosDao : ISelect<CalificacionesNegocios>, IUpdate<CalificacionesNegocios>, IInsert<CalificacionesNegocios>, IDelete<CalificacionesNegocios>
	{
	}
}
