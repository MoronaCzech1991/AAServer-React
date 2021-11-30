using AAServer.Domain.Sys.Modules.ProductSys.ProductDo;
using AAServer.Domain.Sys.Modules.Register.ProviderDo;
using System;
using System.Collections.Generic;

namespace AAServer.Domain.Sys.Modules.StockSys.CotationDo
{
    public class Cotation
    {
        // Common data
        public DateTime Data { get; set; }
        public DateTime DeadlineReceipt { get; set; }

        // Datas
        public ICollection<Provider> Providers { get; set; }
        public ICollection<Product> Products { get; set; }

        // Observations
        public string Observation { get; set; }
    }
}
