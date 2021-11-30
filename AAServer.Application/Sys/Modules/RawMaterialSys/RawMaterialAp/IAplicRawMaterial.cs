using AAServer.Application.Base.Interfaces;
using AAServer.Application.Sys.Modules.RawMaterialSys.RawMaterialAp.View;

namespace AAServer.Application.Sys.Modules.RawMaterialSys.RawMaterialAp
{
    public interface IAplicRawMaterial : IApplicationBase<RawMaterialView>
    {
        bool hasItems();
    }
}
