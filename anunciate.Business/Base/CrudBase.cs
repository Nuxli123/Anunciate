using System;
using System.Collections.Generic;
using anunciate.Domain.Base;
using anunciate.DAL.IGenerics;
namespace anunciate.Business.Base
{
	/// <summary>
	/// Autor: Roberto Carlos Luna Morales
	/// Comentarios: Clase de negocio
	/// </summary>
	public abstract class CrudBase<TEntity, TDao> : ICrudBase<TEntity>
	where TEntity : BaseObjectDomain
	where TDao : class, IInsert<TEntity>, IDelete<TEntity>, IUpdate<TEntity>, ISelect<TEntity>
	{
		public TDao dao = (TDao)Activator.CreateInstance(typeof(TDao));
		public List<TEntity> GetAll()
		{
			return dao.SelectAll();
		}
		public TEntity Insert(TEntity entity)
		{
			return dao.Insert(entity);
		}
		public TEntity Update(TEntity entity)
		{
			return dao.Update(entity);
		}
		public bool Delete(TEntity entity)
		{
			return dao.Delete(entity);
		}
		public TEntity SelectByKey(TEntity entity)
		{
			return dao.SelectByKey(entity);
		}
	}
}
