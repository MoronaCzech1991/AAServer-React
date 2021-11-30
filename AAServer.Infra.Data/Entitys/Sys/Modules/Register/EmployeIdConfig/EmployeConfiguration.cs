using AAServer.Domain.Sys.Modules.Register.EmployeDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Sys.Modules.Register.EmployeIdConfig
{
    public class EmployeConfiguration : IEntityTypeConfiguration<Employe>
    {
        public void Configure(EntityTypeBuilder<Employe> builder)
        {
            // Common data
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID_EMPLOYE");

            builder.Property(x => x.CodeTenatEmploye)
                .HasColumnName("CODE_TENANT_EMPLOYE");

            builder.Property(x => x.Active)
                .HasColumnName("ACTIVE_EMPLOYE");

            builder.Property(x => x.Type)
                .HasColumnName("TYPE_EMPLOYE");

            builder.Property(x => x.Name)
                .HasColumnName("NAME_EMPLOYE");

            builder.Property(x => x.Email)
                .HasColumnName("EMAIL_EMPLOYE");

            // Image
            builder.Property(x => x.image)
                .HasColumnName("IMAGE_EMPLOYE");

            // Table Name
            builder.ToTable("TEmploye");
        }
    }
}
