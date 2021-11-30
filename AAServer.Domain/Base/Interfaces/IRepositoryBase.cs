using System.Collections.Generic;

namespace AAServer.Domain.Base.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {

        void Add(T obj);
        T GetById(int Id);
        IList<T> GetALL();
        void Update(T obj);
        void Remove(T obj);
    }
}
