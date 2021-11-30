using AAServer.Domain.Base.ValidationHttp;
using System.Collections.Generic;

namespace AAServer.Application.Base.Interfaces
{
    public interface IApplicationBase<T> where T : class
    {
        ValidationResultHttpServer Save(T view, int codeTenat);

        IEnumerable<T> GetAll(int codeTenat);

        IEnumerable<T> GetByIds(IEnumerable<int> ids, int codeTenat);

        T GetById(int id, int codeTenat);
    }
}
