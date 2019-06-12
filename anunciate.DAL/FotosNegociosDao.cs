using System;
using anunciate.DAL.IGenerics;
using anunciate.Domain;
namespace anunciate.DAL
{
	/// <summary>
	/// Autor: Roberto Carlos Luna Morales
	/// Comentarios: Interfaz para generar el CRUD
	/// </summary>
	public interface FotosNegociosDao : ISelect<FotosNegocios>, IUpdate<FotosNegocios>, IInsert<FotosNegocios>, IDelete<FotosNegocios>
	{
	}
}
