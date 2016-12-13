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
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ISgt_AdminCore Sgt_AdminCore;


        public ValuesController(ISgt_AdminCore _Sgt_AdminCore)
        {
            Sgt_AdminCore = _Sgt_AdminCore;
        }

        // GET rapi/values
        [HttpGet]
        public async Task<List<Sgt_Admin>> Get()
        {
            var list = await Sgt_AdminCore.GetAllAsync(null);
            return list;
        }

        // GET rapi/values
        [HttpGet]
        [Route("{name}/{pwd}")]
        public async Task<List<Sgt_Admin>> Get(string name, string pwd)
        {
            var list = await Sgt_AdminCore.GetAllAsync(p => p.Name.Equals(name) && p.Pwd.Equals(pwd));
            return list;
        }
    }
}
