using AAServer.Domain.Sys.Modules.RawMaterialDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.RawMaterialSys.RawMaterialIdConfig
{
    public class RawMaterialConfiguration : IEntityTypeConfiguration<RawMaterial>
    {
        public void Configure(EntityTypeBuilder<RawMaterial> builder)
        {
            // Commom Data
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID_RAW_MATERIAL")
                .IsRequired();

            builder.Property(x => x.CodeTenantRawMaterial)
                .HasColumnName("CODE_TENANT_RAW_MATERIAL")
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("NAME_RAW_MATERIAL")
                .IsRequired();

            builder.Property(x => x.InternalCode)
                .HasColumnName("INTERNAL_CODE_RAW_MATERIAL");

            builder.Property(x => x.IsVariable)
                .HasColumnName("IS_VARIABLE_RAW_MATERIAL");

            // Costs
            builder.Property(x => x.CostValue)
                .HasColumnName("COST_RAW_MATERIAL");

            builder.Property(x => x.AccessoriesCost)
                .HasColumnName("ACCESSORIES_RAW_MATERIAL");

            builder.Property(x => x.OtherCost)
                .HasColumnName("OTHER_COST_RAW_MATERIAL");

            builder.Property(x => x.FinalCost)
                .HasColumnName("FINAL_COST_RAW_MATERIAL");

            builder.Property(x => x.ProfitPercent)
                .HasColumnName("PROFIT_PERCENT_RAW_MATERIAL");

            builder.Property(x => x.CellValue)
                .HasColumnName("CELL_VALUE_RAW_MATERIAL");

            // Stock
            builder.Property(x => x.NumberInStock)
                .HasColumnName("NUMBER_STOCK_RAW_MATERIAL");

            builder.Property(x => x.NumberMinumun)
                .HasColumnName("NUMBER_MINUMUN_RAW_MATERIAL");

            builder.Property(x => x.NumberMax)
                .HasColumnName("NUMBER_MAX_RAW_MATERIAL");

            builder.Property(x => x.CodeBar)
                .HasColumnName("CODEBAR_RAW_MATERIAL");

            builder.Property(x => x.QRCode)
                .HasColumnName("QRCODE_RAW_MATERIAL");

            builder.Property(x => x.Observation)
                .HasColumnName("OBSERVATION_RAW_MATERIAL");

            // Detail
            builder.Property(x => x.Weight)
                .HasColumnName("WEIGHT_RAW_MATERIAL");

            builder.Property(x => x.Width)
                .HasColumnName("WIDTH_RAW_MATERIAL");

            builder.Property(x => x.Height)
                .HasColumnName("HEIGHT_RAW_MATERIAL");

            builder.Property(x => x.Length)
                .HasColumnName("LENGTH_RAW_MATERIAL");

            builder.Property(x => x.ExpirationDate)
                .HasColumnName("EXPIRATION_DATE_RAW_MATERIAL");

            builder.Property(x => x.Description)
                .HasColumnName("DESCRIPTION_RAW_MATERIAL");

            // Table Name
            builder.ToTable("TRawMaterial");
        }
    }
}
