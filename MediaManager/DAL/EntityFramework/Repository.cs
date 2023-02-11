using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.DAL.EntityFramework
{
    internal abstract class Repository<TEntity, TDbContext> : IRepository<TEntity>
    {
        protected readonly TDbContext iDbContext;

        public Repository(TDbContext pContext)
        {
            iDbContext = pContext;
        }

        public abstract void Create(TEntity pEntity);
        public abstract void Update(TEntity pEntity);
        public abstract void Delete(TEntity pEntity);
        public abstract TEntity Get(int pId);
        public abstract IEnumerable<TEntity> GetAll();
    }
}
