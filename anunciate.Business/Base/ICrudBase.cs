using System;
using System.Collections.Generic;
using anunciate.Domain.Base;

namespace anunciate.Business.Base
{
	/// <summary>
	/// Autor: Roberto Carlos Luna Morales
	/// Comentarios: Clase de negocio
	/// </summary>
	public interface ICrudBase<TEntity> where TEntity : BaseObjectDomain
	{
		List<TEntity> GetAll();
		TEntity Insert(TEntity entity);
		TEntity Update(TEntity entity);
		bool Delete(TEntity entity);
		TEntity SelectByKey(TEntity entity);
	}
}
