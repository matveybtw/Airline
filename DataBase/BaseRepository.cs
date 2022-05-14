using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBase
{
    public class BaseRepository<TEntity, TIdType> : IBaseRepository<TEntity, TIdType> where TEntity : class, IEntity<TIdType>
    {
        private DataBaseContext dbctx;
        public BaseRepository()
        {
            dbctx = new DataBaseContext();
        }
        public bool Add(TEntity entity)
        {
            try
            {
                dbctx.Add(entity);
                dbctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(TIdType id)
        {
            try
            {
                var item = dbctx.Set<TEntity>().Find(id);
                if (item!=null)
                {
                    dbctx.Set<TEntity>().Remove(item);
                    dbctx.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbctx.Set<TEntity>().AsQueryable();
        }
        public TEntity GetById(TIdType id)
        {
            return dbctx.Set<TEntity>().Find(id);
        }
        public bool Update(TEntity entity)
        {
            try
            {
                dbctx.Update(entity);
                dbctx.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}