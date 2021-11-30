using AAServer.Application.Sys.Modules.RegisterSys.ServiceAp.View;
using AAServer.Domain.Base.ValidationHttp;
using System.Collections.Generic;

namespace AAServer.Application.Sys.Modules.RegisterSys.ServiceAp
{
    public class AplicService : IAplicService
    {
        public IEnumerable<ServiceView> GetAll(int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public ServiceView GetById(int id, int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ServiceView> GetByIds(IEnumerable<int> ids, int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public ValidationResultHttpServer Save(ServiceView view, int codeTenat)
        {
            throw new System.NotImplementedException();
        }
    }
}
