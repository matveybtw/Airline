using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBase
{
    public interface IBaseRepository<TEntity, TIDType>
    {
        public IQueryable<TEntity> GetAll();
        public bool Add(TEntity entity);
        public bool Delete(TIDType id);
        public bool Update(TEntity entity);
        public TEntity GetById(TIDType id);
    }
}