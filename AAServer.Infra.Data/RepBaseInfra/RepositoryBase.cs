using AAServer.Domain.Base.Interfaces;
using AAServer.Infra.Data.ContextInfra;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AAServer.Infra.Data.RepBaseInfra
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        protected ContextModelConfigDB DB = new ContextModelConfigDB(new DbContextOptions<ContextModelConfigDB>());

        public virtual void Add(T obj)
        {
            DB.Set<T>().Add(obj);
            DB.SaveChanges();
        }

        public virtual IList<T> GetALL()
        {
            return DB.Set<T>().ToList();
        }

        public T GetById(int Id)
        {
            return DB.Set<T>().Find(Id);
        }

        public void Remove(T obj)
        {
            DB.Set<T>().Remove(obj);
            DB.SaveChanges();
        }

        public void Update(T obj)
        {
            DB.Entry(obj).State = EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
