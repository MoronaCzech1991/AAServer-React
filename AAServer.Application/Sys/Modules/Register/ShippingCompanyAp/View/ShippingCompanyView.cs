using AAServer.Application.BaseViewAp;
using AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo;

namespace AAServer.Application.Sys.Modules.Register.ShippingCompanyAp.View
{
    public class ShippingCompanyView
    {
        public ShippingCompany Viwer(ShippingCompanyView view)
        {
            return ViewBaseApp<ShippingCompany>.NewSelect(view);
        }
    }
}
