using AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo.ShippingCompanyAddressDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.Register.ShippingCompanyIdConfig.RepShippingCompanyAddressIdConfig
{
    public class ShippingCompanyAddressConfiguration : IEntityTypeConfiguration<ShippingCompanyAddress>
    {
        public void Configure(EntityTypeBuilder<ShippingCompanyAddress> builder)
        {
            // Common data
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID_SHIPPING_SHIPPING_ADDRESS");

            builder.Property(x => x.IdShippingCompany)
                .HasColumnName("ID_FATHER_SHIPPING_ADDRESS");

            builder.Property(x => x.CountryProvider)
                .HasColumnName("COUNTRY_SHIPPING_ADDRESS");

            builder.Property(x => x.ZipCode)
                .HasColumnName("ZIPCODE_SHIPPING_ADDRESS");

            builder.Property(x => x.PublicPlace)
                .HasColumnName("PUBLIC_PLACE_SHIPPING_ADDRESS");

            builder.Property(x => x.Number)
                .HasColumnName("NUMBER_SHIPPING_ADDRESS");

            builder.Property(x => x.Complement)
                .HasColumnName("COMPLEMENT_SHIPPING_ADDRESS");

            builder.Property(x => x.Neighborhood)
                .HasColumnName("NEIGHBORHOOD_SHIPPING_ADDRESS");

            builder.Property(x => x.City)
                .HasColumnName("CITY_SHIPPING_ADDRESS");

            // Children
            builder.HasOne(x => x.ShippingCompanyFather)
                .WithMany(c => c.Addresses)
                .HasForeignKey(u => u.IdShippingCompany);

            // Table Name
            builder.ToTable("TShippingAddress");
        }
    }
}
