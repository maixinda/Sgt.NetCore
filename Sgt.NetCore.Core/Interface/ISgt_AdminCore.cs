/***
 * 描述：本项目只为了在NetCore上开发WebApi的一个示例。项目中使用了Ef、Autofac、Newtonsoft.Json、Async、Repository、SqlServer等技术
 * 作者：Andre
 * 邮箱：xifucom@163.com
 * Github： https://github.com/xifucom/Sgt.NetCore
 ***/


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
        /// <summary>
        /// 异步获取指定条件筛选后的所有数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<List<Sgt_Admin>> GetAllAsync(Expression<Func<Sgt_Admin, bool>> predicate);
    }
}
