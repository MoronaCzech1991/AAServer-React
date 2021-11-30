using AAServer.Domain.Sys.Modules.StockSys.MovimentDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.StockSys.MovimentIdConfig
{
    public class MovimentConfiguration : IEntityTypeConfiguration<Moviment>
    {
        public void Configure(EntityTypeBuilder<Moviment> builder)
        {
        }
    }
}
