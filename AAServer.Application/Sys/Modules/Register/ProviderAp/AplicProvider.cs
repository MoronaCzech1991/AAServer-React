using AAServer.Application.Sys.Modules.RegisterSys.ProviderAp.View;
using AAServer.Domain.Base.ValidationHttp;
using System;
using System.Collections.Generic;

namespace AAServer.Application.Sys.Modules.RegisterSys.ProviderAp
{
    public class AplicProvider : IAplicProvider
    {
        public IEnumerable<ProviderView> GetAll(int codeTenat)
        {
            throw new NotImplementedException();
        }

        public ProviderView GetById(int id, int codeTenat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProviderView> GetByIds(IEnumerable<int> ids, int codeTenat)
        {
            throw new NotImplementedException();
        }

        public ValidationResultHttpServer Save(ProviderView view, int codeTenat)
        {
            throw new NotImplementedException();
        }
    }
}
