using AAServer.Application.Sys.Modules.RawMaterialSys.RawMaterialAp.View;
using AAServer.Domain.Base.ValidationHttp;
using AAServer.Domain.Sys.Modules.RawMaterialDo;
using System.Collections.Generic;

namespace AAServer.Application.Sys.Modules.RawMaterialSys.RawMaterialAp
{
    public class AplicRawMaterial : IAplicRawMaterial
    {
        private readonly IRepRawMaterial _repRawMAterial;

        public AplicRawMaterial(IRepRawMaterial repRawMAterial)
        {
            _repRawMAterial = repRawMAterial;
        }

        public IEnumerable<RawMaterialView> GetAll(int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public RawMaterialView GetById(int id, int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<RawMaterialView> GetByIds(IEnumerable<int> ids, int codeTenat)
        {
            throw new System.NotImplementedException();
        }

        public bool hasItems()
        {
            throw new System.NotImplementedException();
        }

        public ValidationResultHttpServer Save(RawMaterialView view, int codeTenat)
        {
            throw new System.NotImplementedException();
        }
    }
}
