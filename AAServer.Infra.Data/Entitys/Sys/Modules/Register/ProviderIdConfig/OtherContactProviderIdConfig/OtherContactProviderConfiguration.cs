using AAServer.Domain.Sys.Modules.Register.ProviderDo.OtherContactProviderDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.Register.ProviderIdConfig.OtherContactProviderIdConfig
{
    public class OtherContactProviderConfiguration : IEntityTypeConfiguration<OtherContactProvider>
    {
        public void Configure(EntityTypeBuilder<OtherContactProvider> builder)
        {
            // Common data
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID_PROVIDER_CONTACT");

            builder.Property(x => x.IdProvider)
                .HasColumnName("ID_FATHER_PROVIDER_CONTACT");

            builder.Property(x => x.PersonContact)
                .HasColumnName("PERSON_PROVIDER_CONTACT");

            builder.Property(x => x.EmailContact)
                .HasColumnName("EMAIL_PROVIDER_CONTACT");

            builder.Property(x => x.ContactPhone)
                .HasColumnName("CONTACT_PROVIDER_CONTACT");

            builder.Property(x => x.CellPhone)
                .HasColumnName("CELL_PHONE_PROVIDER_CONTACT");

            builder.Property(x => x.PositionCompany)
                .HasColumnName("POSITION_PROVIDER_CONTACT");

            // Children
            builder.HasOne(x => x.ProviderFather)
                .WithMany(c => c.OtherContacts)
                .HasForeignKey(u => u.IdProvider);

            // Table Name
            builder.ToTable("TProviderContact");
        }
    }
}
