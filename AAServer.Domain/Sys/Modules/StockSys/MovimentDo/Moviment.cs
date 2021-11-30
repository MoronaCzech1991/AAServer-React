using AAServer.Domain.Sys.Modules.ProductSys.ProductDo;
using AAServer.Domain.Sys.Modules.RawMaterialDo;
using System.Collections.Generic;

namespace AAServer.Domain.Sys.Modules.StockSys.MovimentDo
{
    public class Moviment
    {
        public Moviment()
        {
            Products = new List<Product>();
            RawMaterials = new List<RawMaterial>();
        }

        // Common data
        public int Id { get; set; }
        public EnumMoviment Type { get; set; }
        public double ShippingCost { get; set; }
        public double TotalCost { get; private set; }

        // Materials or Products
        public ICollection<Product> Products { get; set; }
        public ICollection<RawMaterial> RawMaterials { get; set; }

        // Observation
        public string Observation { get; set; }       
    }
}
