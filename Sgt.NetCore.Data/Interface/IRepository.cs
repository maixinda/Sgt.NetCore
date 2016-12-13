using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sgt.NetCore.Data.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<int> Add(T entity);

        Task<int> AddUpdateAsync(List<T> list, string[] selectKey, string[] updateKey, string[] defDate);


        Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
    }
}
