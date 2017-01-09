/***
 * ����������ĿֻΪ����NetCore�Ͽ���WebApi��һ��ʾ������Ŀ��ʹ����Ef��Autofac��Newtonsoft.Json��Async��Repository��SqlServer�ȼ���
 * ���ߣ�Andre
 * ���䣺xifucom@163.com
 * Github�� https://github.com/xifucom/Sgt.NetCore
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
