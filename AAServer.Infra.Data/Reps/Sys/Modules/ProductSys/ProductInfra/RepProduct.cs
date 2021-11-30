using AAServer.Domain.LoginAndIdentificationDo;
using AAServer.Domain.Sys.Modules.ProductSys.ProductDo;
using AAServer.Infra.Data.RepBaseInfra;
using System.Collections.Generic;
using System.Linq;

namespace AAServer.Infra.Data.Reps.Sys.Modules.ProductSys.ProductInfra
{
    public class RepProduct : RepositoryBase<Product>, IRepProduct
    {
        private readonly IUser _user;

        public RepProduct(IUser user)
        {
            _user = user;
        }

        public override void Add(Product obj) 
        {
            obj.Name = _user.Name;

            DB.Set<Product>().Add(obj);
            DB.SaveChanges();
        }

        public override IList<Product> GetALL()
        {
            string Name = _user.Name;

            return base.GetALL().Where(x => x.Name == Name).ToList();
        }
    }
}
