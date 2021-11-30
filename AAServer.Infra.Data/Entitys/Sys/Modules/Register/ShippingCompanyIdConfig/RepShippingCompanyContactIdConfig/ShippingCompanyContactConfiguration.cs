using AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo.ShippingCompanyContactDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.Register.ShippingCompanyIdConfig.RepShippingCompanyContactIdConfig
{
    public class ShippingCompanyContactConfiguration : IEntityTypeConfiguration<ShippingCompanyContact>
    {
        public void Configure(EntityTypeBuilder<ShippingCompanyContact> builder)
        {
            // Common data
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID_SHIPPING_SHIPPING_CONTACT");

            builder.Property(x => x.IdShippingCompany)
                .HasColumnName("ID_FATHER_SHIPPING_CONTACT");

            builder.Property(x => x.PersonContact)
                .HasColumnName("PERSON_SHIPPING_CONTACT");

            builder.Property(x => x.EmailContact)
                .HasColumnName("EMAIL_SHIPPING_CONTACT");

            builder.Property(x => x.ContactPhone)
                .HasColumnName("CONTACT_PHONE_SHIPPING_CONTACT");

            builder.Property(x => x.CellPhone)
                .HasColumnName("CELL_PHONE_SHIPPING_CONTACT");

            builder.Property(x => x.PositionCompany)
                .HasColumnName("POSITION_SHIPPING_CONTACT");

            // Children
            builder.HasOne(x => x.ShippingCompanyFather)
                .WithMany(c => c.Contacts)
                .HasForeignKey(u => u.IdShippingCompany);

            // Table Name
            builder.ToTable("TShippingContact");
        }
    }
}
