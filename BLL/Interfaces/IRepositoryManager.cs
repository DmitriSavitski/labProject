using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IRepositoryManager<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetEntity(Expression<Func<T, bool>> predicate);

        Task CreateNew(T entity);

        void Delete(T entity);

        void DeleteRange(IEnumerable<T> entity);

        Task<T> GetEntityWithoutTracking(Expression<Func<T, bool>> predicate);

        Task SaveChanges();

        void Update(T entity);
    }
}
