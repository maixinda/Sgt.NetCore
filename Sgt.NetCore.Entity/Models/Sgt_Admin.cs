/***
 * 描述：本项目只为了在NetCore上开发WebApi的一个示例。项目中使用了Ef、Autofac、Newtonsoft.Json、Async、Repository、SqlServer等技术
 * 作者：Andre
 * 邮箱：xifucom@163.com
 * Github： https://github.com/xifucom/Sgt.NetCore
 ***/


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sgt.NetCore.Entity.Models
{
    /// <summary>
    /// 实体层
    /// </summary>
    public partial class Sgt_Admin
    {
        public System.Guid AdminId { get; set; }

        public System.Guid RoleId { get; set; }
        public System.Guid CompanyId { get; set; }
        public System.Guid ProjectId { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public int DeleteKey { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public System.DateTime UpdateTime { get; set; }



        /// <summary>
        /// This field is used to extend the value, does not exist in the database
        /// </summary>
        [NotMapped]
        public string ExtenKey { get; set; }



        /// <summary>
        /// This field is used to extend the value, does not exist in the database
        /// </summary>
        [NotMapped]
        public List<string> ExtenKeyList { get; set; }
    }
}
