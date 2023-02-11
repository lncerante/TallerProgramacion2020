using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProgramacion2020.MediaManager.DAL
{
    public interface IRepository<TEntity>
    {
        void Create(TEntity pEntity);
        void Update(TEntity pEntity);
        void Delete(TEntity pEntity);
        TEntity Get(int pId);
        IEnumerable<TEntity> GetAll();
    }
}
