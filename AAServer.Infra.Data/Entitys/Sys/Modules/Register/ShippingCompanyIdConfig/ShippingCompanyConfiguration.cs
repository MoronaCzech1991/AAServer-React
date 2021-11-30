using AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.Register.ShippingCompanyIdConfig
{
    public class ShippingCompanyConfiguration : IEntityTypeConfiguration<ShippingCompany>
    {
        public void Configure(EntityTypeBuilder<ShippingCompany> builder)
        {
            // Common data
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID_SHIPPING_COMPANY");

            builder.Property(x => x.CodeTenantShippingCompany)
                .HasColumnName("CODE_TENANT_SHIPPING_COMPANY");

            builder.Property(x => x.Type)
                .HasColumnName("TYPE_SHIPPING_COMPANY");

            builder.Property(x => x.IsActive)
                .HasColumnName("IS_ACTIVE_SHIPPING_COMPANY");

            builder.Property(x => x.Name)
                .HasColumnName("NAME_SHIPPING_COMPANY");

            // Adtional information 
            builder.Property(x => x.Email)
                .HasColumnName("DDD_PHONE_SHIPPING_COMPANY");

            builder.Property(x => x.DDDNumberPhoneComercial)
                .HasColumnName("PHONE_SHIPPING_COMPANY");

            builder.Property(x => x.NumberPhoneComercial)
                .HasColumnName("DDD_CELL_SHIPPING_COMPANY");

            builder.Property(x => x.DDDCellPhone)
                .HasColumnName("CELL_SHIPPING_COMPANY");

            builder.Property(x => x.NumberCellPhone)
                .HasColumnName("SITE_SHIPPING_COMPANY");

            // Addresses
            builder.HasMany(x => x.Addresses)
                   .WithOne(c => c.ShippingCompanyFather);

            // Contacts
            builder.HasMany(x => x.Contacts)
                   .WithOne(c => c.ShippingCompanyFather);

            // Table Name
            builder.ToTable("TShippingCompany");
        }
    }
}
