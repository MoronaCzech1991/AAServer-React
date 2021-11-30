using AAServer.Domain.Sys.Modules.StockSys.PurchasesDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.StockSys.PurchaseIdConfig
{
    public class PurchasesConfiguration : IEntityTypeConfiguration<Purchases>
    {
        public void Configure(EntityTypeBuilder<Purchases> builder)
        {
        }
    }
}
