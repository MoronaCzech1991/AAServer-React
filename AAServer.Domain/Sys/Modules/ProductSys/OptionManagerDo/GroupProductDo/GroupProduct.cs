using AAServer.Domain.Sys.Modules.ProductSys.OptionManagerDo.GroupProductDo.SubGroupProductDo;
using System.Collections.Generic;

namespace AAServer.Domain.Sys.Modules.ProductSys.OptionManagerDo.GroupProductDo
{
    public class GroupProduct
    {
        public GroupProduct()
        {
            SubGroups = new List<SubGroupProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        ICollection<SubGroupProduct> SubGroups { get; set; }
    }
}
