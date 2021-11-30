using AAServer.Domain.Sys.Modules.Register.ProviderDo.ProviderAddressDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.Register.ProviderIdConfig.ProviderAddressIdConfig
{
    public class ProviderAddressConfiguration : IEntityTypeConfiguration<ProviderAddress>
    {
        public void Configure(EntityTypeBuilder<ProviderAddress> builder)
        {
            // Common data
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID_PROVIDER_ADDRESS");

            builder.Property(x => x.IdProvider)
                .HasColumnName("ID_FATHER_PROVIDER_ADDRESS");

            builder.Property(x => x.CountryProvider)
                .HasColumnName("COUNTRY_PROVIDER_ADDRESS");

            builder.Property(x => x.ZipCode)
                .HasColumnName("ZIP_CODE_PROVIDER_ADDRESS");

            builder.Property(x => x.Address)
                .HasColumnName("ADDRESS_PROVIDER_ADDRESS");

            builder.Property(x => x.NumberAddress)
                .HasColumnName("NUMBER_PROVIDER_ADDRESS");

            builder.Property(x => x.State)
                .HasColumnName("STATE_PROVIDER_ADDRESS");

            builder.Property(x => x.City)
                .HasColumnName("CITY_PROVIDER_ADDRESS");

            builder.Property(x => x.Quarter)
                .HasColumnName("QUARTER_PROVIDER_ADDRESS");

            builder.Property(x => x.Complement)
                .HasColumnName("COMPLEMENT_PROVIDER_ADDRESS");

            // Children
            builder.HasOne(x => x.ProviderFather)
                   .WithMany(c => c.Addresses)
                   .HasForeignKey(u => u.IdProvider);

            // Table Name
            builder.ToTable("TProviderAddress");
        }
    }
}
