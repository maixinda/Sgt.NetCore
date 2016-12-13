using Sgt.NetCore.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Sgt.NetCore.Data.Context;
using Sgt.NetCore.Data.Base;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Sgt.NetCore.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public async Task<int> Add(T entity)
        {
            using (var db = new SGT_RFID_BaseContext())
            {
                db.Add(entity);
                return await db.SaveChangesAsync();
            }
        }



        public async Task<int> AddUpdateAsync(List<T> list, string[] selectKey, string[] updateKey, string[] defDate)
        {
            using (SGT_RFID_BaseContext db = new SGT_RFID_BaseContext())
            {
                try
                {
                    foreach (var current in list)
                    {
                        var t = db.Set<T>().Where(EfUtils.And<T>(selectKey, current)).FirstOrDefault<T>();
                        if (t == null)
                        {
                            foreach (var def in defDate)
                                current.GetType().GetProperty(def).SetValue(current, DateTime.Now, null);
                            db.Set<T>().Add(current);
                        }
                        else
                        {
                            foreach (var k in updateKey)
                            {
                                if (k.Equals("UpdateTime"))
                                {
                                    t.GetType().GetProperty(k).SetValue(t, DateTime.Now, null);
                                }
                                else
                                {
                                    var value = current.GetType().GetProperty(k).GetValue(current, null);
                                    t.GetType().GetProperty(k).SetValue(t, value, null);
                                }
                            }
                            db.Set<T>().Attach(t);
                            db.Entry<T>(t).State = EntityState.Modified;
                        }
                    }

                    return await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    var msg = string.Concat(new object[]
                     {
                        "Message：",
                        ex.Message,
                        "。 Source:",
                        ex.Source,                 
                        "。 InnerException：",
                        ex.InnerException
                     });
                    return -22;
                }
            }
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            using (SGT_RFID_BaseContext db = new SGT_RFID_BaseContext())
            {
                if (predicate == null)
                    return await db.Set<T>().ToListAsync(); 

                return await db.Set<T>().Where(predicate).ToListAsync();
            }
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            using (SGT_RFID_BaseContext db = new SGT_RFID_BaseContext())
            {
                if (predicate == null)
                    return null;

                return await db.Set<T>().Where(predicate).FirstOrDefaultAsync<T>();
            }
        }
    }
}
