/***
 * 描述：本项目只为了在NetCore上开发WebApi的一个示例。项目中使用了Ef、Autofac、Newtonsoft.Json、Async、Repository、SqlServer等技术
 * 作者：Andre
 * 邮箱：xifucom@163.com
 * Github： https://github.com/xifucom/Sgt.NetCore
 ***/


using Microsoft.EntityFrameworkCore;
using Sgt.NetCore.Entity.Models;

namespace Sgt.NetCore.Data.Context
{
    public partial class SGT_RFID_BaseContext : DbContext
    {
        static SGT_RFID_BaseContext()
        {
            //Database.SetInitializer<SGT_RFID_BaseContext>(null);
        }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=10.1.8.63;Initial Catalog=SGT_RFID_Base;Persist Security Info=True;User ID=sa;Password=service;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sgt_Admin>().ToTable("Sgt_Admin").HasKey(p => p.AdminId);         
            base.OnModelCreating(modelBuilder);
        }
    }
}
