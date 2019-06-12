using System;
using anunciate.DAL.IGenerics;
using anunciate.Domain;
namespace anunciate.DAL
{
	/// <summary>
	/// Autor: Roberto Carlos Luna Morales
	/// Comentarios: Interfaz para generar el CRUD
	/// </summary>
	public interface ComentariosNegociosDao : ISelect<ComentariosNegocios>, IUpdate<ComentariosNegocios>, IInsert<ComentariosNegocios>, IDelete<ComentariosNegocios>
	{
	}
}
