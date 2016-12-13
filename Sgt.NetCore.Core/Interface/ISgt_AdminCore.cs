using Sgt.NetCore.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sgt.NetCore.Core.Interface
{
    public interface ISgt_AdminCore
    {
        Task<List<Sgt_Admin>> GetAllAsync(Expression<Func<Sgt_Admin, bool>> predicate);
    }
}
