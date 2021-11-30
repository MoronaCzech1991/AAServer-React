using AAServer.Domain.Base.ValidationHttp;
using AAServer.Domain.Sys.Modules.ProductSys.SalesValuesDo;
using AAServer.Domain.Sys.Modules.Register.ProviderDo;
using System;
using System.Collections.Generic;

namespace AAServer.Domain.Sys.Modules.ProductSys.ProductDo
{
    public class Product
    {
        public Product()
        {
            Providers = new List<Provider>();
            SalesValues = new List<SalesValue>();
        }

        // Commom Data
        public int Id { get; set; }
        public int CodeTenantProduct { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string InternalCode { get; set; }
        public EnumCategoryProduct Category { get; set; }
        public bool IsVariable { get; set; }

        // Costs 
        public double CostValue { get; set; }
        public double AccessoriesCost { get; set; }
        public double OtherCost { get; set; }
        public double FinalCost { get; private set; }
        public double ProfitPercent { get; set; }
        public double CellValue { get; set; }

        // Stock
        public int NumberInStock { get; set; }
        public int NumberMinumun { get; set; }
        public int NumberMax { get; set; }
        public string CodeBar { get; set; }
        public string QRCode { get; set; }
        public string Observation { get; set; }

        // Detail
        public double Weight { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Description { get; set; }

        // Provider
        public ICollection<Provider> Providers { get; set; }

        // Sales Values
        public ICollection<SalesValue> SalesValues { get; set; }

        // Validation
        public ValidationResultHttpServer ValidateNumberInStock(double numberInStock) 
        {
            return new ValidationResultHttpServer();
        }

        public ValidationResultHttpServer ValidateNumberMinumun(double numberMinumun) 
        {
            return new ValidationResultHttpServer();
        }

        public ValidationResultHttpServer ValidateNumberMax(double numberMax)
        {
            return new ValidationResultHttpServer();
        }
    }
}
