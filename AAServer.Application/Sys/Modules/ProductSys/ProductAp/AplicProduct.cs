using AAServer.Application.Sys.Modules.Register.ProductSys.ProductAp.View;
using AAServer.Domain.Base.ValidationHttp;
using AAServer.Domain.Sys.Modules.ProductSys.ProductDo;
using System;
using System.Collections.Generic;

namespace AAServer.Application.Sys.Modules.Register.ProductSys.ProductAp
{
    public class AplicProduct : IAplicProduct
    {
        private readonly IRepProduct _repProduct;

        public AplicProduct(IRepProduct repProduct)
        {
            _repProduct = repProduct;
        }

        public IEnumerable<ProductView> GetAll(int codeTenat)
        {
            throw new NotImplementedException();
        }

        public ProductView GetById(int id, int codeTenat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductView> GetByIds(IEnumerable<int> ids, int codeTenat)
        {
            throw new NotImplementedException();
        }

        public ValidationResultHttpServer Save(ProductView view, int codeTenat)
        {
            throw new NotImplementedException();
        }
    }
}
