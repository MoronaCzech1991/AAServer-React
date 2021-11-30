using AAServer.Application.Sys.Modules.Register.ShippingCompanyAp.View;
using AAServer.Domain.Base.ValidationHttp;
using System.Collections.Generic;

namespace AAServer.Application.Sys.Modules.Register.ShippingCompanyAp
{
    public class AplicShippingCompany : IAplicShippingCompany
    {
        public AplicShippingCompany()
        {
        }

        public IEnumerable<ShippingCompanyView> GetAll(int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public ShippingCompanyView GetById(int id, int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ShippingCompanyView> GetByIds(IEnumerable<int> ids, int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public ValidationResultHttpServer Save(ShippingCompanyView view, int codeTenat)
        {
            throw new System.NotImplementedException();
        }
    }
}
