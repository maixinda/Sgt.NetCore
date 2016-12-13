using Sgt.NetCore.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sgt.NetCore.Entity.Models;
using System.Linq.Expressions;
using Sgt.NetCore.Data.Interface;

namespace Sgt.NetCore.Core
{
    public class Sgt_AdminCore : ISgt_AdminCore
    {
        private readonly IRepository<Sgt_Admin> Repository;

        public Sgt_AdminCore(IRepository<Sgt_Admin> _Repository)
        {
            Repository = _Repository;
        }


        public async Task<List<Sgt_Admin>> GetAllAsync(Expression<Func<Sgt_Admin, bool>> predicate)
        {
            return await Repository.GetAllAsync(predicate);
        }
    }
}
