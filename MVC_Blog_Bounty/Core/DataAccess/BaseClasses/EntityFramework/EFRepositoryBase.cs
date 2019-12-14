using Core.DataAccess.IBaseRepository;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Core.DataAccess.BaseClasses.EntityFramework
{
    public class EFRepositoryBase<TEntity, TKey, TContext> : IRepository<TEntity, TKey>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()//abstract classları engellemek için
    {
        public readonly TContext _context;
        public readonly DbSet<TEntity> _dbset;

        public EFRepositoryBase(DbContext context)
        {
            _context = (TContext)context;
            _dbset = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbset.Add(entity);
            Save();
        }

        public int Delete(TEntity entity)
        {
            _dbset.Remove(entity);
            
            return Save();
        }

        public int Delete(TKey id)
        {
            TEntity entity = GetById(id);
            Delete(entity);
            return Save();
        }

        public int Delete(Expression<Func<TEntity, bool>> exp)
        {
            List<TEntity> silinecekler = _dbset.Where(exp).ToList();
            _dbset.RemoveRange(silinecekler);
            return Save();
        }

        public List<TEntity> Get(Expression<Func<TEntity, bool>> exp = null)
        {
            if (exp == null)
                return _dbset.ToList();
            else
                return _dbset.Where(exp).ToList();
        }

        public TEntity GetById(TKey id)
        {
            return _dbset.Find(id);
        }

        public int Save()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return Save();
        }
    }
}
