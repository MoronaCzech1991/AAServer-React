using AAServer.Domain.Sys.Modules.ProductSys.ProductDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.ProductSys.ProductIdConfig
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Primary Key
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID_PRODUCT")
                .IsRequired();

            // Foreign Key
            builder.Property(x => x.CodeTenantProduct)
                .HasColumnName("CODE_TENANT_PRODUCT")
                .IsRequired();

            builder.Property(x => x.Active)
                .HasColumnName("ACTIVE_PRODUCT");

            builder.Property(x => x.Name)
                .HasColumnName("NAME_PRODUCT")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.InternalCode)
                .HasColumnName("INTERNAL_CODE_PRODUCT")
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Category)
                .HasColumnName("CATEGORY_PRODUCT");

            builder.Property(x => x.IsVariable)
                .HasColumnName("IS_VARIABLE_PRODUCT");

            // Costs
            builder.Property(x => x.CostValue)
                .HasColumnName("COST_PRODUCT");

            builder.Property(x => x.AccessoriesCost)
                .HasColumnName("ACCESSORIES_PRODUCT");

            builder.Property(x => x.OtherCost)
                .HasColumnName("OTHER_COST_PRODUCT");

            builder.Property(x => x.FinalCost)
                .HasColumnName("FINAL_COST_PRODUCT");

            builder.Property(x => x.ProfitPercent)
                .HasColumnName("PROFIT_PERCENT_PRODUCT");

            builder.Property(x => x.CellValue)
                .HasColumnName("CELL_VALUE_PRODUCT");

            // Stock
            builder.Property(x => x.NumberInStock)
                .HasColumnName("NUMBER_STOCK_PRODUCT");

            builder.Property(x => x.NumberMinumun)
                .HasColumnName("NUMBER_MINUMUN_PRODUCT");

            builder.Property(x => x.NumberMax)
                .HasColumnName("NUMBER_MAX_PRODUCT");

            builder.Property(x => x.CodeBar)
                .HasColumnName("CODEBAR_PRODUCT");

            builder.Property(x => x.QRCode)
                .HasColumnName("QRCODE_PRODUCT");

            builder.Property(x => x.Observation)
                .HasColumnName("OBSERVATION_PRODUCT");

            // Detail
            builder.Property(x => x.Weight)
                .HasColumnName("WEIGHT_PRODUCT");

            builder.Property(x => x.Width)
                .HasColumnName("WIDTH_PRODUCT");

            builder.Property(x => x.Height)
                .HasColumnName("HEIGHT_PRODUCT");

            builder.Property(x => x.Length)
                .HasColumnName("LENGTH_PRODUCT");

            builder.Property(x => x.ExpirationDate)
                .HasColumnName("EXPIRATION_DATE_PRODUCT");

            builder.Property(x => x.Description)
                .HasColumnName("DESCRIPTION_PRODUCT");

            // Table Name
            builder.ToTable("TProduct");
        }
    }
}
