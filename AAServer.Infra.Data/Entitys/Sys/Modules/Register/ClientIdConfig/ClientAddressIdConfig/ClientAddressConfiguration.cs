using AAServer.Domain.Sys.Modules.Register.ClientDo.ClientAddressDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.Register.ClientIdConfig.ClientAddressIdConfig
{
    public class ClientAddressConfiguration : IEntityTypeConfiguration<ClientAddress>
    {
        public void Configure(EntityTypeBuilder<ClientAddress> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID_CLIENT_ADDRESS");
            builder.Property(x => x.IdClient).HasColumnName("ID_FATHER_CLIENT_ADDRESS");
            builder.Property(x => x.ZipCode).HasColumnName("ZIPCODE_CLIENT_ADDRESS");
            builder.Property(x => x.PublicPlace).HasColumnName("PUBLIC_PLACE_CLIENT_ADDRESS");
            builder.Property(x => x.Number).HasColumnName("NUMBER_CLIENT_ADDRESS");
            builder.Property(x => x.Complement).HasColumnName("COMPLEMENT_CLIENT_ADDRESS");
            builder.Property(x => x.Neighborhood).HasColumnName("NEIGHBORHOOD_CLIENT_ADDRESS");
            builder.Property(x => x.City).HasColumnName("CITY_CLIENT_ADDRESS");

            // Children
            builder.HasOne(x => x.ClientFather)
                   .WithMany(c => c.Addresses)
                   .HasForeignKey(u => u.IdClient);

            // Table Name
            builder.ToTable("TClientAddress");
        }
    }
}
