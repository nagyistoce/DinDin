using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace DinDin.EntityFramework.Repositories
{
    public abstract class DinDinRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<DinDinDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected DinDinRepositoryBase(IDbContextProvider<DinDinDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class DinDinRepositoryBase<TEntity> : DinDinRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected DinDinRepositoryBase(IDbContextProvider<DinDinDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
