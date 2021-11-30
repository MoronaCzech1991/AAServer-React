using AAServer.Domain.Sys.Modules.ProductSys.ProductDo;
using AAServer.Domain.Sys.Modules.RawMaterialDo;
using System.Collections.Generic;

namespace AAServer.Domain.Sys.Modules.StockSys.PurchasesDo
{
    public class Purchases
    {
        public Purchases()
        {
            Products = new List<Product>();
            RawMaterials = new List<RawMaterial>();
        }

        public ICollection<Product> Products { get; set; }
        public ICollection<RawMaterial> RawMaterials { get; set; }

        // Transport
        // i will do it after

        // Total
        public double TotalCost { get; set; }
        public double TaxesCost { get; set; }
        public double Discount { get; set; }
        public double DiscountPercetage { get; set; }
        public double TotalPurchase { get; set; }

        // Payment
        //public TypePayment payment;
        // I wil doit after

        public string Observation { get; set; }
    }
}
