using AAServer.Application.BaseViewAp;
using AAServer.Domain.Sys.Modules.Register.ProviderDo;

namespace AAServer.Application.Sys.Modules.RegisterSys.ProviderAp.View
{
    public class ProviderView
    {
        public Provider Viwer(ProviderView view)
        {
            return ViewBaseApp<Provider>.NewSelect(view);
        }
    }
}
