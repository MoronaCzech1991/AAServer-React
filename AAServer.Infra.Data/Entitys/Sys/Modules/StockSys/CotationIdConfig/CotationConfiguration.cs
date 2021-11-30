using AAServer.Domain.Sys.Modules.StockSys.CotationDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.StockSys.CotationIdConfig
{
    public class CotationConfiguration : IEntityTypeConfiguration<Cotation>
    {
        public void Configure(EntityTypeBuilder<Cotation> builder)
        {
        }
    }
}
