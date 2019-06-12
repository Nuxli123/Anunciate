using System;
using anunciate.Domain.Base;
namespace anunciate.DAL.IGenerics
{
	/// <summary>
	/// Autor: Novatek generator
	/// Comentarios: Interface for support Update operation
	/// </summary>
	public interface IUpdate<TEntity> where TEntity : BaseObjectDomain
	{
		TEntity Update(TEntity entity);
	}
}
