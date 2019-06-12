using System;
using anunciate.DataContext;

namespace anunciate.DAL.Implementation.Abstracts
{
	public abstract class BaseDaoImpl : IDisposable
	{
        DataContext.DataContext context = new DataContext.DataContext(new Microsoft.EntityFrameworkCore.DbContextOptions<DataContext.DataContext>());
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }
        public DataContext.DataContext Context
        {
            get { return context; }
            set { context = value; }
        }
    }
}
