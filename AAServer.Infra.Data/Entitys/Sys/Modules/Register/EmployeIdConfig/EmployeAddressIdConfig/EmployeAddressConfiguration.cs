using AAServer.Domain.Sys.Modules.Register.EmployeDo.EmployeAddressDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.Register.EmployeIdConfig.EmployeAddressIdConfig
{
    public class EmployeAddressConfiguration : IEntityTypeConfiguration<EmployeAddress>
    {
        public void Configure(EntityTypeBuilder<EmployeAddress> builder)
        {
            // Common data
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID_EMPLOYE_ADDRESS");
            builder.Property(x => x.IdEmploye).HasColumnName("ID_FATHER_EMPLOYE_ADDRESS");
            builder.Property(x => x.ZipCode).HasColumnName("ZIPCODE_EMPLOYE_ADDRESS");
            builder.Property(x => x.PublicPlace).HasColumnName("PUBLIC_PLACE_EMPLOYE_ADDRESS");
            builder.Property(x => x.Number).HasColumnName("NUMBER_EMPLOYE_ADDRESS");
            builder.Property(x => x.Complement).HasColumnName("COMPLEMENT_EMPLOYE_ADDRESS");
            builder.Property(x => x.Neighborhood).HasColumnName("NEIGHBORHOOD_EMPLOYE_ADDRESS");
            builder.Property(x => x.City).HasColumnName("CITY_EMPLOYE_ADDRESS");

            // Children
            builder.HasOne(x => x.EmployeFather)
                   .WithMany(c => c.Addresses)
                   .HasForeignKey(u => u.IdEmploye);

            // Table Name
            builder.ToTable("TEmployeAddress");
        }
    }
}
