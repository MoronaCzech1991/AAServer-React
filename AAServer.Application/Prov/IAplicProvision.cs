using AAServer.Application.Prov.View;
using AAServer.Domain.Base.ValidationHttp;

namespace AAServer.Application.Provision
{
    public interface IAplicProvision
    {
        ValidationResultHttpServer Provision(ProvisitionView view);
    }
}
