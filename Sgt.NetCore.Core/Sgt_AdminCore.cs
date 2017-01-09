/***
 * 描述：本项目只为了在NetCore上开发WebApi的一个示例。项目中使用了Ef、Autofac、Newtonsoft.Json、Async、Repository、SqlServer等技术
 * 作者：Andre
 * 邮箱：xifucom@163.com
 * Github： https://github.com/xifucom/Sgt.NetCore
 ***/


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
    /// <summary>
    /// 业务处理核心层，通过ioc注入获取数据层对象
    /// </summary>
    public class Sgt_AdminCore : ISgt_AdminCore
    {
        private readonly IRepository<Sgt_Admin> Repository;

        public Sgt_AdminCore(IRepository<Sgt_Admin> _Repository)
        {
            Repository = _Repository;
        }



        /// <summary>
        /// 异步获取指定条件筛选后的所有数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<List<Sgt_Admin>> GetAllAsync(Expression<Func<Sgt_Admin, bool>> predicate)
        {
            //……
            
            return await Repository.GetAllAsync(predicate);
        }
    }
}
