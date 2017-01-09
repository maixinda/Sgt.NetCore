/***
 * 描述：本项目只为了在NetCore上开发WebApi的一个示例。项目中使用了Ef、Autofac、Newtonsoft.Json、Async、Repository、SqlServer等技术
 * 作者：Andre
 * 邮箱：xifucom@163.com
 * Github： https://github.com/xifucom/Sgt.NetCore
 ***/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sgt.NetCore.Data.Interface;
using Sgt.NetCore.Entity.Models;
using Sgt.NetCore.Core.Interface;
using Newtonsoft.Json;

namespace Sgt.NetCore.Service.Controllers
{
    /// <summary>
    /// api接口，通过ioc注入获取核心业务层对象
    /// </summary>
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ISgt_AdminCore Sgt_AdminCore;


        public ValuesController(ISgt_AdminCore _Sgt_AdminCore)
        {
            Sgt_AdminCore = _Sgt_AdminCore;
        }

        /// <summary>
        /// 获取全部对象
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<Sgt_Admin>> Get()
        {
            var list = await Sgt_AdminCore.GetAllAsync(null);
            return list;
        }

        /// <summary>
        /// 根据账号、密码获取对象
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{name}/{pwd}")]
        public async Task<List<Sgt_Admin>> Get(string name, string pwd)
        {
            var list = await Sgt_AdminCore.GetAllAsync(p => p.Name.Equals(name) && p.Pwd.Equals(pwd));
            return list;
        }
    }
}
