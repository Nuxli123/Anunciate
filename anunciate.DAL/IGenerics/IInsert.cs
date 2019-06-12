using System;
using anunciate.Domain.Base;
namespace anunciate.DAL.IGenerics
{
	/// <summary>
	/// Autor: Novatek generator
	/// Comentarios: Interface for support Insert operation
	/// </summary>
	public interface IInsert<TEntity> where TEntity : BaseObjectDomain
	{
		TEntity Insert(TEntity entity);
	}
}
