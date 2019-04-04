using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GamesFree.Repositoy
{
    public interface IRepositoryBase<T>
    {
       IEnumerable<T> FindAll();
       IEnumerable<T> FindByConditions(Expression<Func<T, bool>> predicate);
       void Create(T entity);
       void Update(T entity);
       void Delete(T entity);
       Task<bool> SaveAsync();
    }
}