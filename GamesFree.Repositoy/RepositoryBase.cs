using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GamesFree.Repositoy
{
    public class RepositoryBase<T> :  IRepositoryBase<T> where T: class
    {
        private readonly DataContext _context;

        public RepositoryBase(DataContext context)
       {
            _context = context;
        }

        public void Create(T entity)
        {
          _context.Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
           return _context.Set<T>();
        }
        public IEnumerable<T> FindByConditions(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public async Task<bool> SaveAsync()
        {
            return ( await _context.SaveChangesAsync()> 0);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }

}