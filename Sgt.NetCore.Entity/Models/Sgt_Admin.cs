using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sgt.NetCore.Entity.Models
{
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
