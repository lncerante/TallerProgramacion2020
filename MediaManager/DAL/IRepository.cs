using System.Collections.Generic;

namespace TallerProgramacion2020.MediaManager.DAL
{
    internal interface IRepository<TEntity>
    {
        void Create(TEntity pEntity);
        void Update(TEntity pEntity);
        void Delete(TEntity pEntity);
        TEntity Get(int pId);
        IEnumerable<TEntity> GetAll();
    }
}
