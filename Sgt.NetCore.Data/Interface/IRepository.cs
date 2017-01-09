/***
 * 描述：本项目只为了在NetCore上开发WebApi的一个示例。项目中使用了Ef、Autofac、Newtonsoft.Json、Async、Repository、SqlServer等技术
 * 作者：Andre
 * 邮箱：xifucom@163.com
 * Github： https://github.com/xifucom/Sgt.NetCore
 ***/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Sgt.NetCore.Data.Interface
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 增加单个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> Add(T entity);


        /// <summary>
        /// 增加或修改集合，根据指定的条件查找对象是否存在，如存在则修改，否则新增
        /// </summary>
        /// <param name="list"></param>
        /// <param name="selectKey"></param>
        /// <param name="updateKey"></param>
        /// <param name="defDate"></param>
        /// <returns></returns>
        Task<int> AddUpdateAsync(List<T> list, string[] selectKey, string[] updateKey, string[] defDate);



        /// <summary>
        /// 根据指定条件获取单个实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);


        /// <summary>
        /// 根据指定条件获取集合
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate);
    }
}
