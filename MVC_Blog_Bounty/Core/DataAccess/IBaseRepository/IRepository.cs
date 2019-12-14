using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.IBaseRepository
{
    public interface IRepository<TEntity, TKey> :
          IAdd<TEntity>,
          IDelete<TEntity>,
          IDeleteById<TKey>,
          IDeleteExp<TEntity>,
          IGetById<TEntity, TKey>,
          IGetExp<TEntity>,
          ISave,
          IUpdate<TEntity>
          where TEntity : class, IEntity, new()
    {

    }
}
