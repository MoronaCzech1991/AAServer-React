using AAServer.Application.BaseViewAp;
using AAServer.Domain.Sys.Modules.ServiceSys.ServiceDo;

namespace AAServer.Application.Sys.Modules.RegisterSys.ServiceAp.View
{
    public class ServiceView
    {
        public Service Viwer(ServiceView view)
        {
            return ViewBaseApp<Service>.NewSelect(view);
        }
    }
}
