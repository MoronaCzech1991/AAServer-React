using AAServer.Application.BaseViewAp;
using AAServer.Domain.Sys.Modules.ProductSys.ProductDo;

namespace AAServer.Application.Sys.Modules.Register.ProductSys.ProductAp.View
{
    public class ProductView
    {
        public Product Viwer(ProductView view)
        {
            return ViewBaseApp<Product>.NewSelect(view);
        }
    }
}
