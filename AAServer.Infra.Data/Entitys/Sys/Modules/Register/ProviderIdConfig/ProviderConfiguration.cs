using AAServer.Domain.Sys.Modules.Register.ProviderDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.Register.ProviderIdConfig
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            // Common data
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID_PROVIDER");

            builder.Property(x => x.CodeTenatProvider)
                .HasColumnName("CODE_TENANT_PROVIDER");

            builder.Property(x => x.Type)
                .HasColumnName("TYPE_PROVIDER");

            builder.Property(x => x.IsActive)
                .HasColumnName("ACTIVE_PROVIDER");

            builder.Property(x => x.EnglishCNPJ)
                .HasColumnName("ENGLISHCNPJ_PROVIDER");

            builder.Property(x => x.FantasyName)
                .HasColumnName("FANTASY_NAME_PROVIDER");

            builder.Property(x => x.Name)
                .HasColumnName("NAME_PROVIDER");

            builder.Property(x => x.CodeCadaster)
                .HasColumnName("CODE_CADASTER_PROVIDER");

            // Adtional information
            builder.Property(x => x.Email)
                .HasColumnName("EMAIL_PROVIDER");

            builder.Property(x => x.DDDNumberPhoneComercial)
                .HasColumnName("DDD_PHONE_PROVIDER");

            builder.Property(x => x.NumberPhoneComercial)
                .HasColumnName("NUMBER_PHONE_PROVIDER");

            builder.Property(x => x.DDDCellPhone)
                .HasColumnName("DDD_CELL_PROVIDER");

            builder.Property(x => x.NumberCellPhone)
                .HasColumnName("NUMBER_CELL_PROVIDER");

            // Addresses
            builder.HasMany(x => x.Addresses)
                   .WithOne(c => c.ProviderFather);

            // contacts
            builder.HasMany(x => x.OtherContacts)
                   .WithOne(c => c.ProviderFather);

            // Observations
            builder.Property(x => x.Observations).HasColumnName("OBSERVATION_PROVIDER");

            // Table Name
            builder.ToTable("TProvider");
        }
    }
}
