using AAServer.Domain.Sys.Modules.Register.ClientDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.Register.ClientIdConfig
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            // Common data
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID_CLIENT")
                .IsRequired();

            builder.Property(x => x.CodeTenantClient)
                .HasColumnName("CODE_TENANT_CLIENT")
                .IsRequired();

            builder.Property(x => x.Type).HasColumnName("TYPE_CLIENT");

            builder.Property(x => x.Active).HasColumnName("ACTIVE_CLIENT");

            builder.Property(x => x.Name)
                .HasColumnName("NAME_CLIENT")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Email)
                .HasColumnName("EMAIL_CLIENT")
                .HasMaxLength(100);

            // Phone
            builder.Property(x => x.DDDNumberPhoneComercial).HasColumnName("DDD_NUMBER_PHONE_CLIENT");

            builder.Property(x => x.NumberPhoneComercial).HasColumnName("NUMBER_PHONE_CLIENT");

            builder.Property(x => x.DDDCellPhone).HasColumnName("DDD_CELL_PHONE_CLIENT");

            builder.Property(x => x.NumberCellPhone).HasColumnName("NUMBER_CELL_PHONE_CLIENT");

            builder.Property(x => x.Site).HasColumnName("SITE_CLIENT");

            builder.Property(x => x.Skipe).HasColumnName("SKIPE_CLIENT");

            // Addresses
            builder.HasMany(x => x.Addresses)
                   .WithOne(c => c.ClientFather);

            // Image
            builder.Property(x => x.ImagePath).HasColumnName("IMAGE_PATH_CLIENT");

            // Financial
            builder.Property(x => x.LimitCredit).HasColumnName("LIMIT_CREDIT_CLIENT");

            // Observation
            builder.Property(x => x.Observation).HasColumnName("OBSERVATION_CLIENT");

            // Table Name
            builder.ToTable("TClient");
        }
    }
}
